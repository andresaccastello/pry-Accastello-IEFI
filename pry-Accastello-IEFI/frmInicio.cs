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
    public partial class frmInicio : Form
    {

        private string nombreUsuario;
        private int idSesion;

        public frmInicio(string usuario, int sesionId)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            idSesion = sesionId;
            this.FormClosing += frmInicio_FormClosing;
        }

     

        private void frmInicio_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Usuario: " + nombreUsuario;
            toolStripStatusLabel2.Text = "Fecha: " + DateTime.Now.ToShortDateString();

            
            if (nombreUsuario.ToLower() != "admin")
            {
                usuariosToolStripMenuItem.Visible = false; 
            }
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=Auditoria;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = @"
                UPDATE Sesiones
                SET 
                    HoraFin = CAST(GETDATE() AS TIME),
                    TiempoTranscurrido = CAST(DATEADD(SECOND, DATEDIFF(SECOND, HoraInicio, CAST(GETDATE() AS TIME)), 0) AS TIME)
                WHERE Id = @idSesion";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@idSesion", idSesion);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la hora de salida: " + ex.Message);
                }
            }
            Application.Exit();
        }

        private void auditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSesiones SESIONES = new frmSesiones();
            SESIONES.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareas tareas = new frmTareas();
            tareas.ShowDialog();
        }
    }
}
