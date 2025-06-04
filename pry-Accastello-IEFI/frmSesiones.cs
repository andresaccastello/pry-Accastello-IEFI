using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Accastello_IEFI
{
    public partial class frmSesiones : Form
    {
        public frmSesiones()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();
        private void frmSesiones_Load(object sender, EventArgs e)
        {
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("Sesiones");
            dgvGrilla.DataSource = datos;
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Sesiones");
        }
    }
}
