using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAnalfabeta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnEnviar.Enabled = false;
            btnEnviar.Text = "Validando...";

            try
            {
                
                var loginData = new
                {
                    usuario = txtUsuario.Text,
                    contrasena = txtContrasena.Text
                };
                string json = JsonConvert.SerializeObject(loginData);

                
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";

                    
                    ServicePointManager.ServerCertificateValidationCallback = (s, cert, chain, ssl) => true;

                    string urlApi = "https://localhost:7225/api/Auth/login";

                    
                    string responseString = client.UploadString(urlApi, "POST", json);

                    
                    JObject respuesta = JObject.Parse(responseString);

                    SesionGlobal.Token = respuesta["token"].ToString();
                    SesionGlobal.Rol = respuesta["rol"].ToString();
                    SesionGlobal.NombreUsuario = txtUsuario.Text;

                    
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
            catch (WebException ex)
            {
                
                if (ex.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEnviar.Enabled = true;
                btnEnviar.Text = "Enviar";
            }
        }
    }
}
