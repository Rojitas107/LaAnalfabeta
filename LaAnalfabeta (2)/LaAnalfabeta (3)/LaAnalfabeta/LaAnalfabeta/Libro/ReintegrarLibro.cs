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
    public partial class ReintegrarLibro : Form
    {
        public ReintegrarLibro()
        {
            InitializeComponent();
        }
        private readonly string nomBD = "analfabeta";
        private int prestamoIDActual = 0;
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string idTexto = txIdPrestamo.Text.Trim();

            if (string.IsNullOrEmpty(idTexto) || !int.TryParse(idTexto, out int idPrestamo))
            {
                MessageBox.Show("Debe ingresar un ID de préstamo válido (número).");
                txIdPrestamo.Focus();
                return;
            }

            SqlConnection objConector = ManejoDB.db.conectar(nomBD);

            if (objConector == null) return;

            try
            {
                string sql = @"SELECT p.PrestamoID, p.LibroID, p.EstudianteID, p.ProfesorID, 
                                      p.Estado, p.Observaciones, l.ImagenRuta
                               FROM Prestamos p
                               INNER JOIN Libros l ON l.LibroID = p.LibroID
                               WHERE p.PrestamoID = @idPrestamo;";

                using (SqlCommand cmd = new SqlCommand(sql, objConector))
                {
                    cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                    using (SqlDataReader tabla = cmd.ExecuteReader())
                    {
                        if (tabla.Read())
                        {
                            string estado = tabla["Estado"].ToString();

                            if (estado == "Devuelto")
                            {
                                MessageBox.Show("Este préstamo ya fue devuelto anteriormente.");
                                ResetearFormulario();
                                return;
                            }

                            
                            prestamoIDActual = idPrestamo;

                            txIdLibro.Text = tabla["LibroID"].ToString();
                            txIdEstudiante.Text = tabla["EstudianteID"] == DBNull.Value ? "—" : tabla["EstudianteID"].ToString();
                            txIdProfesor.Text = tabla["ProfesorID"] == DBNull.Value ? "—" : tabla["ProfesorID"].ToString();

                           
                            txObservaciones.Text = tabla["Observaciones"] == DBNull.Value ? "" : tabla["Observaciones"].ToString();

                            
                            string nombreImagen = tabla["ImagenRuta"] == DBNull.Value
                                ? null
                                : tabla["ImagenRuta"].ToString();
                            MostrarImagen(nombreImagen);

                            btnEntregar.Enabled = true;
                            txObservaciones.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No existe un préstamo con el ID: " + idPrestamo);
                            ResetearFormulario();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el préstamo:\n" + ex.Message);
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
                MessageBox.Show("No se encontró la imagen del libro en:\n" + rutaCompleta);
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
            prestamoIDActual = 0;
            txIdPrestamo.Clear();
            txIdLibro.Clear();
            txIdEstudiante.Clear();
            txIdProfesor.Clear();
            txObservaciones.Clear();
            LimpiarImagen();
            btnEntregar.Enabled = false;
            txIdPrestamo.Focus();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            
            if (prestamoIDActual == 0)
            {
                MessageBox.Show("Primero debe consultar un préstamo válido.");
                return;
            }

            
            var confirm = MessageBox.Show(
                "¿Confirmar la entrega de este libro?\n\nSe marcará como 'Devuelto' y se guardarán las observaciones.",
                "Confirmar Entrega",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            
            SqlConnection objConector = ManejoDB.db.conectar(nomBD);
            if (objConector == null) return;

            try
            {
                
                string sqlUpdate = @"UPDATE Prestamos 
                             SET Estado = 'Devuelto', 
                                 FechaDevolucionReal = GETDATE(),
                                 Observaciones = @observaciones
                             WHERE PrestamoID = @prestamoID;";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, objConector))
                {
                    cmd.Parameters.AddWithValue("@prestamoID", prestamoIDActual);

                    
                    string obs = txObservaciones.Text.Trim();
                    cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrEmpty(obs) ? (object)DBNull.Value : obs);

                    
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡Libro reintegrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        ResetearFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el préstamo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la entrega:\n" + ex.Message);
            }
            finally
            {
                
                ManejoDB.db.cerrar(objConector);
            }
        }
    }
}
