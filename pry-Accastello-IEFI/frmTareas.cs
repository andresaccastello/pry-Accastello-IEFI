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
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();
      

        private void frmTareas_Load(object sender, EventArgs e)
        {
            dtFecha.MaxDate = DateTime.Today;
            DataTable tarea = objConexion.ObtenerCombos("Tarea");

            cmbTarea.DataSource = tarea;
            cmbTarea.DisplayMember = "Nombre";  // Lo que se muestra
            cmbTarea.ValueMember = "Id";        // El valor real (por ejemplo, para guardar en DB)
            cmbTarea.SelectedIndex = -1;        // Opcional, para que no haya nada seleccionado al inicio
            int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);


            DataTable lugar = objConexion.ObtenerCombos("Lugar");

            cmbLugar.DataSource = lugar;
            cmbLugar.DisplayMember = "Nombre";  // Lo que se muestra
            cmbLugar.ValueMember = "Id";        // El valor real (por ejemplo, para guardar en DB)
            cmbLugar.SelectedIndex = -1;        // Opcional, para que no haya nada seleccionado al inicio
            int idLugar = Convert.ToInt32(cmbLugar.SelectedValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreLugar.Text;

            objConexion.InsertarEnCombo(nombre,"Lugar");

            DataTable lugar = objConexion.ObtenerCombos("Lugar");
            cmbLugar.DataSource = lugar;
            cmbLugar.DisplayMember = "Nombre";
            cmbLugar.ValueMember = "Id"; // Asegúrate de que la tabla tenga esta columna

            txtNombreLugar.Clear();
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTarea.Text;

            objConexion.InsertarEnCombo(nombre, "Tarea");

            DataTable tarea = objConexion.ObtenerCombos("Tarea");
            cmbTarea.DataSource = tarea;
            cmbTarea.DisplayMember = "Nombre";
            cmbTarea.ValueMember = "Id"; // Asegúrate de que la tabla tenga esta columna

            txtNombreTarea.Clear();
        }

        private void btnAgregarG_Click(object sender, EventArgs e)
        {
            int tarea = Convert.ToInt32(cmbTarea.SelectedValue);
            int lugar = Convert.ToInt32(cmbLugar.SelectedValue);
            string fecha = dtFecha.Value.ToString("dd/MM/yyyy");


            objConexion.InsertarTareaSimple(
               tarea,
               lugar,
               fecha,"TareaSimple1");

            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("TareaSimple1");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            dtFecha.Value = DateTime.Today;
        }
    }
}
