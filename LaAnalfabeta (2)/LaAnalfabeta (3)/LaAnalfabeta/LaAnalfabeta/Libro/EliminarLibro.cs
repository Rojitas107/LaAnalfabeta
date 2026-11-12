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
    public partial class EliminarLibro : Form
    {
        private readonly string nomBD = "analfabeta";
        private int idLibroEncontrado = 0; 
        private string nombreImagenEncontrada = null;
        public EliminarLibro()
        {
            InitializeComponent();
        }
        private void FrmEliminarLibro_Load(object sender, EventArgs e)
        {
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.Enabled = false; 
            txInformacion.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (idLibroEncontrado == 0) return;

            
            DialogResult respuesta = MessageBox.Show(
                $"¿Está TOTALMENTE seguro de eliminar el libro?\n\nEsta acción borrará el registro y la imagen de la portada para siempre.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                SqlConnection con = ManejoDB.db.conectar(nomBD);
                if (con != null)
                {
                    
                    string sqlDelete = $"DELETE FROM Libros WHERE LibroID = {idLibroEncontrado}";
                    int filas = ManejoDB.db.operar(sqlDelete, con);
                    ManejoDB.db.cerrar(con);

                    if (filas > 0)
                    {
                        
                        if (!string.IsNullOrEmpty(nombreImagenEncontrada))
                        {
                            string rutaImagen = @"C:\Users\USUARIO\Desktop\Restaurante\LaAnalfabeta\LaAnalfabeta\Imagenes\" + nombreImagenEncontrada;

                            if (File.Exists(rutaImagen))
                            {
                                File.Delete(rutaImagen); 
                        }

                        MessageBox.Show("Libro eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        txCodigo.Clear();
                        txInformacion.Clear();
                        LimpiarImagen();
                        btnEliminar.Enabled = false;
                        idLibroEncontrado = 0;
                        nombreImagenEncontrada = null;
                        txCodigo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        
        private void MostrarImagen(string nombreArchivo)
        {
            LimpiarImagen();
            if (string.IsNullOrEmpty(nombreArchivo)) return;

            string rutaCompleta = @"C:\Users\USUARIO\Desktop\Restaurante\LaAnalfabeta\LaAnalfabeta\Imagenes\" + nombreArchivo;

            if (File.Exists(rutaCompleta))
            {
                using (var stream = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
                {
                    picPortada.Image = Image.FromStream(stream);
                }
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

        private void FrmEliminarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarImagen();
        }

private void button1_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(txCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.");
                return;
            }

            SqlConnection con = ManejoDB.db.conectar(nomBD);
            if (con == null) return;

            string sql = $@"SELECT LibroID, Codigo, Titulo, Autor, ImagenRuta 
                            FROM Libros WHERE LibroID = {codigo}";

            SqlDataReader tabla = ManejoDB.db.consulta(sql, con);

            if (tabla != null && tabla.Read())
            {
                
                idLibroEncontrado = Convert.ToInt32(tabla["LibroID"]);
                nombreImagenEncontrada = tabla["ImagenRuta"] == DBNull.Value ? null : tabla["ImagenRuta"].ToString();

                
                txInformacion.Text = "--- LIBRO SELECCIONADO ---\r\n\r\n";
                txInformacion.Text += "Código: " + tabla["Codigo"].ToString() + "\r\n";
                txInformacion.Text += "Título: " + tabla["Titulo"].ToString() + "\r\n";
                txInformacion.Text += "Autor:  " + tabla["Autor"].ToString() + "\r\n";

                
                MostrarImagen(nombreImagenEncontrada);

                
                btnEliminar.Enabled = true;            }
            else
            {
                MessageBox.Show("El libro no existe.");
                idLibroEncontrado = 0;
                nombreImagenEncontrada = null;
                txInformacion.Clear();
                LimpiarImagen();
                btnEliminar.Enabled = false;
            }

            if (tabla != null) tabla.Close();
            ManejoDB.db.cerrar(con);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
