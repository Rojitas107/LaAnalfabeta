using LaAnalfabeta.Libro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAnalfabeta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void codigoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLibro obj = new ConsultaLibro();
            obj.Show();
        }

        private void nombreLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLIbroNombre obj = new ConsultaLIbroNombre();
            obj.Show();
        }

        private void ingresarNuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.Show();
        }

        private void eliminarUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLibro eliminarLibro = new EliminarLibro();  
            eliminarLibro.Show();
        }

        private void actualizarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarLibro obj = new ActualizarLibro();
            obj.Show();
        }

        private void prestarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestarLibro obj = new PrestarLibro();
            obj.Show();
        }

        private void reintegrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReintegrarLibro obj = new ReintegrarLibro();
            obj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            
            this.Text = "Sistema Bibliotecario - " + SesionGlobal.NombreUsuario + " (" + SesionGlobal.Rol + ")";
            MessageBox.Show(SesionGlobal.Rol);
            
            if (SesionGlobal.Rol == "Administrador" || SesionGlobal.Rol == "Bibliotecario")
            {
                
                consultaToolStripMenuItem.Enabled = true;
                actualizacionToolStripMenuItem.Enabled = true;
                novedadesToolStripMenuItem.Enabled = true;
                aplicacionWebToolStripMenuItem.Enabled = true;
            }
            else if (SesionGlobal.Rol == "Estudiante" || SesionGlobal.Rol == "Profesor")
            {
                
                consultaToolStripMenuItem.Enabled = true;
                actualizacionToolStripMenuItem.Enabled = false; 
                novedadesToolStripMenuItem.Enabled = true;      
                aplicacionWebToolStripMenuItem.Enabled = false;
                reintegrarLibroToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                
                MessageBox.Show("Rol no autorizado.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private async void aplicacionWebToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                aplicacionWebToolStripMenuItem.Enabled = false;

                
                string rutaEjecutable = AppDomain.CurrentDomain.BaseDirectory;


                DirectoryInfo dir = new DirectoryInfo(rutaEjecutable);
                string rutaWeb = "";

                
                while (dir != null)
                {
                    
                    string rutaPosibleWeb = Path.Combine(dir.FullName, "WebAnalfabeta", "WebAnalfabeta");

                    if (Directory.Exists(rutaPosibleWeb))
                    {
                        rutaWeb = rutaPosibleWeb;
                        break;
                    }

                    
                    dir = dir.Parent;
                }

                if (string.IsNullOrEmpty(rutaWeb))
                {
                    MessageBox.Show("No se pudo encontrar la carpeta de la aplicación web.\nAsegúrate de que las carpetas estén juntas.", "Error de Ruta");
                    return;
                }

                
                string urlWeb = "https://localhost:7026";
                string argumentos = $"/c cd /d \"{rutaWeb}\" && dotnet watch run --urls \"{urlWeb}\"";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = argumentos,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized,
                    UseShellExecute = true
                });

                
                bool servidorListo = false;
                int intentos = 0;

                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (_, cert, chain, ssl) => true;

                using (HttpClient checkClient = new HttpClient(handler))
                {
                    while (!servidorListo && intentos < 20)
                    {
                        try
                        {
                            var response = await checkClient.GetAsync(urlWeb);
                            servidorListo = true;
                        }
                        catch
                        {
                            intentos++;
                            await Task.Delay(1000);
                        }
                    }
                }

                
                if (servidorListo)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = urlWeb,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("La aplicación web tardó demasiado en iniciar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar la aplicación web:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aplicacionWebToolStripMenuItem.Enabled = true;
            }
        }
    }
}







