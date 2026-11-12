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
    public partial class ActualizarLibro : Form
    {
        private string nombreImagenOriginal = null;
        private string rutaImagenNueva = null;
        private bool quitarImagen = false;
        private readonly string nomBD = "analfabeta";

        public ActualizarLibro()
        {
            InitializeComponent();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(txCodigo.Text.Trim(), out int codigoLibro))
            {
                MessageBox.Show("Debe ingresar un código numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string nombreArchivoParaBD = nombreImagenOriginal;

            try
            {
               
                if (quitarImagen)
                {
                    
                    nombreArchivoParaBD = null;
                }
                else if (!string.IsNullOrEmpty(rutaImagenNueva))
                {
                    
                    string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.FullName;
                    string carpetaImagenes = Path.Combine(rutaProyecto, "Imagenes");

                   
                    if (!Directory.Exists(carpetaImagenes))
                    {
                        Directory.CreateDirectory(carpetaImagenes);
                    }

                    
                    string extension = Path.GetExtension(rutaImagenNueva);
                    string nombreUnico = "Libro_" + codigoLibro + "_" + Guid.NewGuid().ToString().Substring(0, 8) + extension;

                    string rutaDestino = Path.Combine(carpetaImagenes, nombreUnico);

                    
                    File.Copy(rutaImagenNueva, rutaDestino, true);

                    
                    nombreArchivoParaBD = nombreUnico;
                }

               
                SqlConnection objConector = ManejoDB.db.conectar(nomBD);

                if (objConector != null)
                {
                    
                    string sql = @"UPDATE Libros SET 
                            Titulo = @Titulo, 
                            Autor = @Autor, 
                            Editorial = @Editorial, 
                            AnioPublicacion = @Anio, 
                            Categoria = @Categoria, 
                            ISBN = @ISBN, 
                            Stock = @Stock, 
                            Disponible = @Disponible, 
                            ImagenRuta = @ImagenRuta 
                       WHERE LibroID = @Codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, objConector))
                    {
                       
                        cmd.Parameters.AddWithValue("@Titulo", txTitulo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Autor", txAutor.Text.Trim());

                        
                        cmd.Parameters.AddWithValue("@Editorial", string.IsNullOrEmpty(txEditorial.Text.Trim()) ? (object)DBNull.Value : txEditorial.Text.Trim());
                        cmd.Parameters.AddWithValue("@Categoria", string.IsNullOrEmpty(txCategoria.Text.Trim()) ? (object)DBNull.Value : txCategoria.Text.Trim());
                        cmd.Parameters.AddWithValue("@ISBN", string.IsNullOrEmpty(txISBN.Text.Trim()) ? (object)DBNull.Value : txISBN.Text.Trim());

                        
                        cmd.Parameters.AddWithValue("@Anio", (int)numAnio.Value);
                        cmd.Parameters.AddWithValue("@Stock", (int)numStock.Value);

                       
                        cmd.Parameters.AddWithValue("@Disponible", chDisponible.Checked);

                        
                        cmd.Parameters.AddWithValue("@ImagenRuta", (object)nombreArchivoParaBD ?? DBNull.Value);

                        
                        cmd.Parameters.AddWithValue("@Codigo", codigoLibro);

                        
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Libro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            nombreImagenOriginal = nombreArchivoParaBD;
                            rutaImagenNueva = null;
                            quitarImagen = false;

                            
                            txTitulo.Enabled = false;
                            txAutor.Enabled = false;
                            txEditorial.Enabled = false;
                            numAnio.Enabled = false;
                            txCategoria.Enabled = false;
                            txISBN.Enabled = false;
                            numStock.Enabled = false;
                            chDisponible.Enabled = false;

                            btSeleccionar.Enabled = false;
                            btQuitar.Enabled = false;
                            btActualizar.Enabled = false;

                           
                            txCodigo.Clear();
                            txCodigo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar. Verifique que el libro aún exista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    ManejoDB.db.cerrar(objConector);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el libro: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void MostrarImagen(string nombreArchivo)
        {
            if (picPortada.Image != null) picPortada.Image.Dispose();
            picPortada.Image = null;

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
        }




        private void btConsultar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Debe ingresar un código numérico válido.");
                return;
            }

            SqlConnection objConector = ManejoDB.db.conectar(nomBD);

            if (objConector != null)
            {
                string sql = @"SELECT LibroID, Codigo, Titulo, Autor, Editorial, AnioPublicacion,
                                  Categoria, ISBN, ImagenRuta, Stock, Disponible
                           FROM Libros 
                           WHERE LibroID = " + codigo + ";";

                SqlDataReader tabla = ManejoDB.db.consulta(sql, objConector);

                if (tabla != null && tabla.Read())
                {
                    
                    txTitulo.Text = tabla["Titulo"].ToString();
                    txAutor.Text = tabla["Autor"].ToString();
                    txEditorial.Text = tabla["Editorial"] == DBNull.Value ? "" : tabla["Editorial"].ToString();

                    
                    numAnio.Maximum = 3000;
                    numAnio.Value = tabla["AnioPublicacion"] == DBNull.Value ? 0 : Convert.ToDecimal(tabla["AnioPublicacion"]);

                   
                    numStock.Maximum = 10000; 
                    numStock.Value = Convert.ToDecimal(tabla["Stock"]);

                    txCategoria.Text = tabla["Categoria"] == DBNull.Value ? "" : tabla["Categoria"].ToString();
                    txISBN.Text = tabla["ISBN"] == DBNull.Value ? "" : tabla["ISBN"].ToString();
                    chDisponible.Checked = Convert.ToBoolean(tabla["Disponible"]);

                   
                    string nombreImagen = tabla["ImagenRuta"] == DBNull.Value
                        ? null
                        : tabla["ImagenRuta"].ToString();
                    MostrarImagen(nombreImagen);

                   
                    nombreImagenOriginal = nombreImagen;
                    rutaImagenNueva = null;
                    quitarImagen = false;

                    
                    txTitulo.ReadOnly = false;
                    txAutor.ReadOnly = false;
                    txEditorial.ReadOnly = false;
                    numAnio.ReadOnly = false;
                    txCategoria.ReadOnly = false;
                    txISBN.ReadOnly = false;
                    numStock.ReadOnly = false;
                    chDisponible.Enabled = true;

                    btSeleccionar.Enabled = true;
                    btQuitar.Enabled = true;
                    btActualizar.Enabled = true;
                }
                else
                {
                   
                    MessageBox.Show("El libro no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    txTitulo.Clear();
                    txAutor.Clear();
                    txEditorial.Clear();
                    numAnio.Value = 0;
                    txCategoria.Clear();
                    txISBN.Clear();
                    numStock.Value = 0;
                    chDisponible.Checked = false;

                    if (picPortada.Image != null) picPortada.Image.Dispose();
                    picPortada.Image = null;

                    
                    txTitulo.Enabled = false;
                    txAutor.Enabled = false;
                    txEditorial.Enabled = false;
                    numAnio.Enabled = false;
                    txCategoria.Enabled = false;
                    txISBN.Enabled = false;
                    numStock.Enabled = false;
                    chDisponible.Enabled = false;

                    btSeleccionar.Enabled = false;
                    btQuitar.Enabled = false;
                    btActualizar.Enabled = false;
                }

                if (tabla != null) tabla.Close();
                ManejoDB.db.cerrar(objConector);
            }
        }

        private void btQuitar_Click_1(object sender, EventArgs e)
        {
            
            if (picPortada.Image != null)
            {
                picPortada.Image.Dispose();
                picPortada.Image = null;
            }

            
            quitarImagen = true;

            
            rutaImagenNueva = null;

        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cancelar? Se perderán los cambios no guardados.",
                                                     "Cancelar",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
               
                this.Close();
            }
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar Portada del Libro";
                ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                        rutaImagenNueva = ofd.FileName;

                        
                        quitarImagen = false;

                        
                        if (picPortada.Image != null)
                        {
                            picPortada.Image.Dispose();
                        }

                        using (var stream = new FileStream(rutaImagenNueva, FileMode.Open, FileAccess.Read))
                        {
                            picPortada.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizarLibro_Load(object sender, EventArgs e)
        {

        }

        private void picPortada_Paint_1(object sender, PaintEventArgs e)
        {
           
        
            
            Color colorVerdeBosque = Color.FromArgb(44, 95, 45);

            
            Pen plumaBorde = new Pen(colorVerdeBosque, 2);

            
            e.Graphics.DrawRectangle(plumaBorde, 0, 0, picPortada.Width - 1, picPortada.Height - 1);

            
            plumaBorde.Dispose();
        
        }

        private void picPortada_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

