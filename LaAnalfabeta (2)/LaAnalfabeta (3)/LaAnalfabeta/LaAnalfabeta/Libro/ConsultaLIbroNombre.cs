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
    public partial class ConsultaLIbroNombre : Form
    {
        public ConsultaLIbroNombre()
        {
            InitializeComponent();
        }
        private readonly string nomBD = "analfabeta";
        private void button1_Click(object sender, EventArgs e)
        {
            string codigo=txCodigo.Text;

            SqlConnection objConector = ManejoDB.db.conectar(nomBD);

            if (objConector != null)
            {
                string sql = @"SELECT LibroID, Codigo, Titulo, Autor, Editorial, AnioPublicacion,
                                      Categoria, ISBN, ImagenRuta, Stock, Disponible
                               FROM Libros 
                               WHERE Titulo = '" + codigo + "';";

                SqlDataReader tabla = ManejoDB.db.consulta(sql, objConector);

                if (tabla != null && tabla.Read())
                {
                    
                    txInformacion.Text = "CAMPO\t\tVALOR\r\n";
                    txInformacion.Text += "─────────────────────────────────────────\r\n";
                    txInformacion.Text += "Código\t\t" + tabla["Codigo"].ToString() + "\r\n";
                    txInformacion.Text += "Título\t\t" + tabla["Titulo"].ToString() + "\r\n";
                    txInformacion.Text += "Autor\t\t" + tabla["Autor"].ToString() + "\r\n";
                    txInformacion.Text += "Editorial\t" + (tabla["Editorial"] == DBNull.Value ? "—" : tabla["Editorial"].ToString()) + "\r\n";
                    txInformacion.Text += "Año\t\t" + (tabla["AnioPublicacion"] == DBNull.Value ? "—" : tabla["AnioPublicacion"].ToString()) + "\r\n";
                    txInformacion.Text += "Categoría\t" + (tabla["Categoria"] == DBNull.Value ? "—" : tabla["Categoria"].ToString()) + "\r\n";
                    txInformacion.Text += "ISBN\t\t" + (tabla["ISBN"] == DBNull.Value ? "—" : tabla["ISBN"].ToString()) + "\r\n";
                    txInformacion.Text += "Stock\t\t" + tabla["Stock"].ToString() + "\r\n";
                    txInformacion.Text += "Disponible\t" + (Convert.ToBoolean(tabla["Disponible"]) ? "Sí" : "No") + "\r\n";

                    
                    string nombreImagen = tabla["ImagenRuta"] == DBNull.Value
                        ? null
                        : tabla["ImagenRuta"].ToString();
                    MostrarImagen(nombreImagen);
                }
                else
                {
                    MessageBox.Show("El libro no existe.");
                    txInformacion.Clear();
                    LimpiarImagen();
                }

                if (tabla != null) tabla.Close();
                ManejoDB.db.cerrar(objConector);
            }
        }

        
        private void MostrarImagen(string nombreArchivo)
        {
            LimpiarImagen();

            if (string.IsNullOrEmpty(nombreArchivo)) return;

            
            string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string rutaCompleta = Path.Combine(rutaProyecto, "Imagenes", nombreArchivo);

            if (File.Exists(rutaCompleta))
            {
                using (var stream = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
                {
                    picPortada.Image = Image.FromStream(stream);
                }
            }
            else
            {
                
                MessageBox.Show("No se encontró la imagen en:\n" + rutaCompleta);
            }
        }


        
        private void LimpiarImagen()
        {
            if (picPortada.Image != null)
            {
                picPortada.Image.Dispose();
                picPortada.Image = null;
            }
        }

        private void FrmConsultarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarImagen();
        }

        private void picPortada_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

