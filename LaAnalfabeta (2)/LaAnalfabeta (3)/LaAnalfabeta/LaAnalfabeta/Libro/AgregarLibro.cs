using ManejoDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAnalfabeta.Libro
{
    public partial class AgregarLibro : Form
    {
        private readonly string nomBD = "analfabeta";
        private string rutaImagenSeleccionada = "";
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Seleccionar portada del libro";
                open.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.webp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = open.FileName;

                    
                    using (var stream = new FileStream(rutaImagenSeleccionada, FileMode.Open, FileAccess.Read))
                    {
                        if (picPortada.Image != null) picPortada.Image.Dispose();
                        picPortada.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txCodigo.Text) || string.IsNullOrWhiteSpace(txTitulo.Text) || string.IsNullOrWhiteSpace(txAutor.Text))
            {
                MessageBox.Show("El código, título y autor son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string valorImagenSQL = "NULL"; 

            try
            {

                if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                   
                    string carpetaDestino = @"C:\Users\USUARIO\Desktop\Restaurante\LaAnalfabeta\LaAnalfabeta\Imagenes";

                    if (!Directory.Exists(carpetaDestino))
                        Directory.CreateDirectory(carpetaDestino);

                    
                    string nombreUnico = Guid.NewGuid().ToString() + Path.GetExtension(rutaImagenSeleccionada);
                    string rutaDestinoCompleta = Path.Combine(carpetaDestino, nombreUnico);

                    
                    File.Copy(rutaImagenSeleccionada, rutaDestinoCompleta, true);

                    
                    valorImagenSQL = "'" + nombreUnico + "'";
                }


                string codigo = txCodigo.Text.Trim().Replace("'", "''");
                string titulo = txTitulo.Text.Trim().Replace("'", "''");
                string autor = txAutor.Text.Trim().Replace("'", "''");

                
                string editorial = string.IsNullOrWhiteSpace(txEditorial.Text) ? "NULL" : "'" + txEditorial.Text.Trim().Replace("'", "''") + "'";
                string categoria = string.IsNullOrWhiteSpace(txCategoria.Text) ? "NULL" : "'" + txCategoria.Text.Trim().Replace("'", "''") + "'";
                string isbn = string.IsNullOrWhiteSpace(txISBN.Text) ? "NULL" : "'" + txISBN.Text.Trim().Replace("'", "''") + "'";

                string anio = ((int)numAnio.Value).ToString();
                string stock = ((int)numStock.Value).ToString();
                string disponible = chDisponible.Checked ? "1" : "0";

                
                string sql = $@"INSERT INTO Libros (Codigo, Titulo, Autor, Editorial, AnioPublicacion, Categoria, ISBN, ImagenRuta, Stock, Disponible) 
                                VALUES ('{codigo}', '{titulo}', '{autor}', {editorial}, {anio}, {categoria}, {isbn}, {valorImagenSQL}, {stock}, {disponible})";

                
                SqlConnection con = db.conectar(nomBD);

                if (con != null)
                {
                    int filasAfectadas = db.operar(sql, con);
                    db.cerrar(con);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Libro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el libro. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAgregarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (picPortada.Image != null)
            {
                picPortada.Image.Dispose();
                picPortada.Image = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void picPortada_Paint(object sender, PaintEventArgs e)
        {
            Color colorVerdeBosque = Color.FromArgb(44, 95, 45);

            Pen plumaBorde = new Pen(colorVerdeBosque, 2);


            e.Graphics.DrawRectangle(plumaBorde, 0, 0, picPortada.Width - 1, picPortada.Height - 1);


            plumaBorde.Dispose();
        }
    }
}
