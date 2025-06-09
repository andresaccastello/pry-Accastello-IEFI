using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Accastello_IEFI
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = @"Server=.\SQLEXPRESS;Database=Auditoria;Trusted_Connection=True;";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }

        public DataTable ObtenerDatosTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $"SELECT * FROM {nombreTabla}";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }


        public void InsertarContacto(string nombre, string contraseña, int telefono, string correo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = @"
                         INSERT INTO Usuarios (Nombre, Contraseña, Telefono, Correo)
                         VALUES (@Nombre, @Contraseña, @Telefono, @Correo)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Contraseña", contraseña);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Correo", correo);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Contacto insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el contacto: " + ex.Message);
            }
        }

        public void ModificarProducto(int id, string nombre, string contraseña, int telefono, string correo)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Usuarios SET Nombre = @nombre, Contraseña = @contraseña, Telefono = @telefono, Correo = @correo WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@telefono",telefono );
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Usuarios WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarProductoPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Usuarios WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerCombos(string nombreTabla)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = $"SELECT Id, Nombre FROM {nombreTabla}"; 
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public void InsertarEnCombo(string nombre, string nombreTabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $@"
                     INSERT INTO {nombreTabla} (Nombre)
                     VALUES (@Nombre)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show($"{nombreTabla} insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        public void InsertarTareaSimple(int tarea, int lugar, string fecha, string nombreTabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $@"
                INSERT INTO {nombreTabla} (Tarea, Lugar, Fecha)
                VALUES (@Tarea, @Lugar, @Fecha)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tarea", tarea);
                        comando.Parameters.AddWithValue("@Lugar", lugar);
                        comando.Parameters.AddWithValue("@Fecha", fecha);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show($"{nombreTabla} insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }
        public void InsertarTareaCompleta(int tarea, int lugar, string fecha, string tiempo,string pago,string comentario, string nombreTabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $@"
                INSERT INTO {nombreTabla} (Tarea, Lugar, Fecha)
                VALUES (@Tarea, @Lugar, @Fecha)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tarea", tarea);
                        comando.Parameters.AddWithValue("@Lugar", lugar);
                        comando.Parameters.AddWithValue("@Fecha", fecha);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show($"{nombreTabla} insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }
    }

}
