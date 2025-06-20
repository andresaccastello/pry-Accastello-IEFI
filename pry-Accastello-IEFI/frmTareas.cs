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
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("TareaSimple1");
            dgvGrilla.DataSource = datos;


            objConexion.ConectarBD();
            DataTable datos2 = objConexion.ObtenerDatosTabla("TareaCompleta");
            dgvGrilla2.DataSource = datos2;


            cmbTabla.Items.Add("Grilla Mayor");
            cmbTabla.Items.Add("Grilla menor"); 
            cmbTabla.SelectedIndex = 0; 



            dtFecha.MaxDate = DateTime.Today;
            DataTable tarea = objConexion.ObtenerCombos("Tarea");

            cmbTarea.DataSource = tarea;
            cmbTarea.DisplayMember = "Nombre";  
            cmbTarea.ValueMember = "Id";        
            cmbTarea.SelectedIndex = -1;        
            int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);


            DataTable lugar = objConexion.ObtenerCombos("Lugar");

            cmbLugar.DataSource = lugar;
            cmbLugar.DisplayMember = "Nombre";  
            cmbLugar.ValueMember = "Id";        
            cmbLugar.SelectedIndex = -1;        
            int idLugar = Convert.ToInt32(cmbLugar.SelectedValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreLugar.Text;

            objConexion.InsertarEnCombo(nombre,"Lugar");

            DataTable lugar = objConexion.ObtenerCombos("Lugar");
            cmbLugar.DataSource = lugar;
            cmbLugar.DisplayMember = "Nombre";
            cmbLugar.ValueMember = "Id"; 

            txtNombreLugar.Clear();
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTarea.Text;

            objConexion.InsertarEnCombo(nombre, "Tarea");

            DataTable tarea = objConexion.ObtenerCombos("Tarea");
            cmbTarea.DataSource = tarea;
            cmbTarea.DisplayMember = "Nombre";
            cmbTarea.ValueMember = "Id"; 

            txtNombreTarea.Clear();
        }

        private void btnAgregarG_Click(object sender, EventArgs e)
        {
            if (!CamposCompletos1()) return;
            int tarea = Convert.ToInt32(cmbTarea.SelectedValue);
            int lugar = Convert.ToInt32(cmbLugar.SelectedValue);
            string fecha = dtFecha.Value.ToString("dd/MM/yyyy");


            objConexion.InsertarTareaSimple(
               tarea,
               lugar,
               fecha,"TareaSimple1");

            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("TareaSimple1");
            Limpiar();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            dtFecha.Value = DateTime.Today;
        }

        private void btnCargarCompleta_Click(object sender, EventArgs e)
        {
            if (!CamposCompletos()) return;
            int tarea = Convert.ToInt32(cmbTarea.SelectedValue);
            int lugar = Convert.ToInt32(cmbLugar.SelectedValue);
            string fecha = dtFecha.Value.ToString("dd/MM/yyyy");
            string tiempo = "";
            string comentario = txtComentario.Text;
            string pago = "";
            
            if (optTiempoLargo.Checked)
            {
                tiempo = "Duracion: Prolongada";

            }
            else if (optTiempoCorto.Checked) 
            {
                tiempo = "Duracion: Corta";

            }

            if (optEfectuado.Checked)
            {
                pago = "Pago: Efectuado";

            }
            else if (optPendiente.Checked) 
            {
                pago = "Pago : Pendiente";
            }
            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("El campo Comentario no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string detalle = $"{tiempo},{pago}";

            objConexion.InsertarTareaCompleta(
                tarea,
                lugar,
                fecha,
                detalle,
                comentario,"TareaCompleta");
            dgvGrilla2.DataSource = objConexion.ObtenerDatosTabla("TareaCompleta");

            dgvGrilla2.Columns["Detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla2.Columns["Comentario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Limpiar();
           

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            dtFecha.Value = DateTime.Today;
            txtComentario.Text = "";
            optTiempoLargo.Checked= true;
            optEfectuado.Checked= true;
        }
        public void Limpiar() 
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            dtFecha.Value = DateTime.Today;
            optTiempoLargo.Checked = false;
            optTiempoCorto.Checked = false;
            optEfectuado.Checked = false;
            optPendiente.Checked = false;
            txtComentario.Clear();
        }

        public bool CamposCompletos()
        {
            if (cmbTarea.SelectedIndex == -1 || cmbLugar.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Debe seleccionar una tarea, un lugar y completar el comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public bool CamposCompletos1()
        {
            if (cmbTarea.SelectedIndex == -1 || cmbLugar.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe seleccionar una tarea y un lugar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            int idBuscado = (int)numBuscarId.Value;
            int seleccion = cmbTabla.SelectedIndex;
            if (seleccion == -1)
            {
                MessageBox.Show("Debe seleccionar una tabla para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (seleccion == 0)
            {
                DataTable resultado = objConexion.BuscarProductoPorId(idBuscado, "TareaCompleta");

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];

                    dgvGrilla2.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró una tarea con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (seleccion == 1)
            {
                DataTable resultado = objConexion.BuscarProductoPorId(idBuscado, "TareaSimple1");

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];

                    dgvGrilla.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró una tarea con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btnDesacer_Click(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("TareaSimple1");
            dgvGrilla2.DataSource = objConexion.ObtenerDatosTabla("TareaCompleta");
        }
    }
}
