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
    public partial class PrestarLibro : Form
    {
        public PrestarLibro()
        {
            InitializeComponent();
        }
        private readonly string nomBD = "analfabeta";
        private int libroIDActual = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe ingresar el código del libro (ej. LIB-001).");
                txCodigo.Focus();
                return;
            }

            SqlConnection objConector = ManejoDB.db.conectar(nomBD);
            if (objConector == null) return;

            try
            {
                string sql = @"SELECT LibroID, Codigo, Titulo, Autor, Editorial, AnioPublicacion,
                                      Categoria, ISBN, ImagenRuta, Stock, Disponible
                               FROM Libros
                               WHERE Codigo = @codigo;";

                using (SqlCommand cmd = new SqlCommand(sql, objConector))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader tabla = cmd.ExecuteReader())
                    {
                        if (tabla.Read())
                        {
                            libroIDActual = Convert.ToInt32(tabla["LibroID"]);
                            bool disponible = Convert.ToBoolean(tabla["Disponible"]);
                            int stock = Convert.ToInt32(tabla["Stock"]);

                            txInformacion.Text = "CAMPO\t\tVALOR\r\n";
                            txInformacion.Text += "─────────────────────────────────────────\r\n";
                            txInformacion.Text += "Código\t\t" + tabla["Codigo"] + "\r\n";
                            txInformacion.Text += "Título\t\t" + tabla["Titulo"] + "\r\n";
                            txInformacion.Text += "Autor\t\t" + tabla["Autor"] + "\r\n";
                            txInformacion.Text += "Editorial\t" + (tabla["Editorial"] == DBNull.Value ? "—" : tabla["Editorial"].ToString()) + "\r\n";
                            txInformacion.Text += "Año\t\t" + (tabla["AnioPublicacion"] == DBNull.Value ? "—" : tabla["AnioPublicacion"].ToString()) + "\r\n";
                            txInformacion.Text += "Categoría\t" + (tabla["Categoria"] == DBNull.Value ? "—" : tabla["Categoria"].ToString()) + "\r\n";
                            txInformacion.Text += "ISBN\t\t" + (tabla["ISBN"] == DBNull.Value ? "—" : tabla["ISBN"].ToString()) + "\r\n";
                            txInformacion.Text += "Stock\t\t" + stock + "\r\n";
                            txInformacion.Text += "Disponible\t" + (disponible ? "Sí" : "No") + "\r\n";

                            string nombreImagen = tabla["ImagenRuta"] == DBNull.Value
                                ? null
                                : tabla["ImagenRuta"].ToString();
                            MostrarImagen(nombreImagen);

                            btnPrestar.Enabled = disponible && stock > 0;

                            if (!btnPrestar.Enabled)
                                MessageBox.Show("Este libro no está disponible para préstamo.");
                        }
                        else
                        {
                            MessageBox.Show("No existe un libro con el código: " + codigo);
                            ResetearFormulario();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro:\n" + ex.Message);
            }
            finally
            {
                ManejoDB.db.cerrar(objConector);
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (libroIDActual == 0)
            {
                MessageBox.Show("Primero busque un libro válido.");
                return;
            }

            string identificacion = txIdentificacion.Text.Trim();
            if (string.IsNullOrEmpty(identificacion))
            {
                MessageBox.Show("Debe ingresar el carnet del estudiante o la cédula del profesor.");
                txIdentificacion.Focus();
                return;
            }

            if (dtpFechaDevolucion.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior a hoy.");
                return;
            }

            int? estudianteID = null;
            int? profesorID = null;

            SqlConnection objConector = ManejoDB.db.conectar(nomBD);
            if (objConector == null) return;

            try
            {
                if (rbtEstudiante.Checked)
                {
                    string sqlEst = "SELECT EstudianteID FROM Estudiantes WHERE Carnet = @carnet AND Activo = 1;";
                    using (SqlCommand cmd = new SqlCommand(sqlEst, objConector))
                    {
                        cmd.Parameters.AddWithValue("@carnet", identificacion);
                        object res = cmd.ExecuteScalar();
                        if (res == null)
                        {
                            MessageBox.Show("No existe un estudiante activo con ese carnet.");
                            return;
                        }
                        estudianteID = Convert.ToInt32(res);
                    }
                }
                else
                {
                    string sqlProf = "SELECT ProfesorID FROM Profesores WHERE Cedula = @cedula AND Activo = 1;";
                    using (SqlCommand cmd = new SqlCommand(sqlProf, objConector))
                    {
                        cmd.Parameters.AddWithValue("@cedula", identificacion);
                        object res = cmd.ExecuteScalar();
                        if (res == null)
                        {
                            MessageBox.Show("No existe un profesor activo con esa cédula.");
                            return;
                        }
                        profesorID = Convert.ToInt32(res);
                    }
                }


                string sqlInsert = @"INSERT INTO Prestamos
                    (LibroID, EstudianteID, ProfesorID, FechaPrestamo,
                     FechaDevolucionEsperada, Estado)
                    VALUES
                    (@libroID, @estudianteID, @profesorID, GETDATE(),
                     @fechaDevolucion, 'Prestado');";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, objConector))
                {
                    cmd.Parameters.AddWithValue("@libroID", libroIDActual);
                    cmd.Parameters.AddWithValue("@estudianteID", (object)estudianteID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@profesorID", (object)profesorID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaDevolucion", dtpFechaDevolucion.Value.Date);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No se pudo registrar el préstamo.");
                        return;
                    }
                }


                string sqlUpdate = "UPDATE Libros SET Stock = 0, Disponible = 0 WHERE LibroID = @libroID;";
                using (SqlCommand cmd = new SqlCommand(sqlUpdate, objConector))
                {
                    cmd.Parameters.AddWithValue("@libroID", libroIDActual);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Préstamo registrado correctamente.\n\nDevolución esperada: " +
                                dtpFechaDevolucion.Value.ToString("dd/MM/yyyy"));

                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo:\n" + ex.Message);
            }
            finally
            {
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

        private void ResetearFormulario()
        {
            libroIDActual = 0;
            txCodigo.Clear();
            txIdentificacion.Clear();
            txInformacion.Clear();
            LimpiarImagen();
            btnPrestar.Enabled = false;
            txCodigo.Focus();
        }

        private void FrmPrestarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarImagen();
        }

        private void PrestarLibro_Load(object sender, EventArgs e)
        {

        }

        private void txCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

