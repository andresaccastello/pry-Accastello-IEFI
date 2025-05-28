using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Accastello_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentosFallidos = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Auditoria;Trusted_Connection=True";
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;
            

            string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @nombre AND Contraseña = @contraseña";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", username);
                    cmd.Parameters.AddWithValue("@contraseña", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        Form productos = new frmInicio();
                        productos.Show();
                        this.Hide();
                    }
                    else
                    {
                        intentosFallidos++; // Aumentar el contador
                        MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentosFallidos + " de 3.");

                        if (intentosFallidos >= 3)
                        {
                            MessageBox.Show("Demasiados intentos fallidos. El formulario se cerrará.");
                            this.Close(); // Cierra el formulario actual
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
