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
            string connectionString = @"Server=.\SQLEXPRESS;Database=Auditoria;Trusted_Connection=True;";
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Buscar ID del usuario
                    string query = "SELECT Id FROM Usuarios WHERE Nombre = @nombre AND Contraseña = @contraseña";
                    int idUsuario = -1;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", username);
                        cmd.Parameters.AddWithValue("@contraseña", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            idUsuario = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    if (idUsuario != -1)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");

                        // 2. Insertar sesión y obtener ID de la sesión
                        int idSesion = -1;
                        string insertSesion = @"
                    INSERT INTO Sesiones (IdUsuario, FechaInicio, HoraInicio, HoraFin, TiempoTranscurrido)
                    OUTPUT INSERTED.Id
                    VALUES (@id, CAST(GETDATE() AS DATE), CAST(GETDATE() AS TIME), NULL, NULL)";

                        using (SqlCommand insertCmd = new SqlCommand(insertSesion, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@id", idUsuario);
                            idSesion = (int)insertCmd.ExecuteScalar(); // Guardo el ID insertado
                        }

                        // 3. Abrir formulario principal y pasarle el nombre + idSesion
                        Form inicio = new frmInicio(username, idSesion);
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        intentosFallidos++;
                        MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentosFallidos + " de 3.");

                        if (intentosFallidos >= 3)
                        {
                            MessageBox.Show("Demasiados intentos fallidos. El formulario se cerrará.");
                            this.Close();
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
