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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();
        private int codigoSeleccionado = -1;
        private bool modoEdicion = false;
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("Usuarios");
            dgvGrilla.DataSource = datos;


            // Suscribir los eventos de cambio

            txtNombre.TextChanged += new EventHandler(ControlCambio);
            txtContraseña.TextChanged += new EventHandler(ControlCambio);
            txtTelefono.TextChanged += new EventHandler(ControlCambio);
            txtCorreo.TextChanged += new EventHandler(ControlCambio);
            ValidarCampos();

        }

        private void ControlCambio(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            bool camposCompletos =
        !string.IsNullOrWhiteSpace(txtNombre.Text) &&
        !string.IsNullOrWhiteSpace(txtContraseña.Text) &&
        !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
        !string.IsNullOrWhiteSpace(txtCorreo.Text);

            // Solo habilita el botón Cargar si los campos están completos y NO estás en modo edición
            btnCargar.Enabled = camposCompletos && !modoEdicion;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Contraseña= txtContraseña.Text;
            int Telefono;
            if (int.TryParse(txtTelefono.Text, out Telefono))
            {
                // teléfono es un número válido, podés usarlo
            }
            else
            {
                MessageBox.Show("El teléfono debe ser un número válido.");
                txtTelefono.Focus();
                return; // para evitar seguir con la ejecución si es inválido
            }
            string Correo= txtCorreo.Text;

           
            objConexion.InsertarContacto(
               Nombre,
               Contraseña,
               Telefono,
               Correo
            );

            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Usuarios");
        }

        private void dgvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            numBuscarId.Value = 0;
            if (e.RowIndex >= 0)
            {
                modoEdicion = true;
                DataGridViewRow fila = dgvGrilla.Rows[e.RowIndex];

                // Guardamos el Código del producto para luego usarlo en la modificación
                codigoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                // Cargamos los valores en los controles
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                ValidarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (codigoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un producto para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            int telefono;
            if (int.TryParse(txtTelefono.Text, out telefono))
            {
                // teléfono es un número válido, podés usarlo
            }
            else
            {
                MessageBox.Show("El teléfono debe ser un número válido.");
                txtTelefono.Focus();
                return; // para evitar seguir con la ejecución si es inválido
            }
            string correo = txtCorreo.Text;
            // Llamar al método que actualiza en la base de datos
            objConexion.ModificarProducto(
                codigoSeleccionado,
                nombre, 
                contraseña,
                telefono,
                correo  
            );

            // Actualizar la grilla
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Usuarios");

            // Limpiar los controles
            codigoSeleccionado = -1;
            txtNombre.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un Usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            var resultado = MessageBox.Show("¿Estás seguro de que querés eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objConexion.EliminarProducto(codigoSeleccionado);

                // Actualizar la grilla
                dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Usuarios");

                // Limpiar controles
                codigoSeleccionado = -1;
                txtNombre.Clear();
                txtContraseña.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
               
            }
        }

        private void btnDesacer_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            
            txtNombre.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            modoEdicion = false;


            numBuscarId.Value = 0;
          

           
            txtNombre.ReadOnly = false;
            txtContraseña.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtCorreo.ReadOnly = false;
          
            
            dgvGrilla.ClearSelection();
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Usuarios");

            
            codigoSeleccionado = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            int idBuscado = (int)numBuscarId.Value;

            DataTable resultado = objConexion.BuscarProductoPorId(idBuscado,"Usuarios");

            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];

                
                codigoSeleccionado = idBuscado;
                txtNombre.Text = fila["Nombre"].ToString();
                txtContraseña.Text = fila["Contraseña"].ToString();
                txtTelefono.Text = fila["Telefono"].ToString();
                txtCorreo.Text = fila["Correo"].ToString();
               


                dgvGrilla.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontró un Usuario con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
