using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TO;

namespace DAO
{
    public class DAOEmpleado
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public TOEmpleado buscarEmpleado(string idEmpleado, string contra)
        {
            try
            {
                TOEmpleado empleado = new TOEmpleado();
                SqlCommand buscar = new SqlCommand("SELECT * FROM cuenta_empleado WHERE id_cuenta = @id and contrasenna = @contra", conexion);
                buscar.Parameters.AddWithValue("@id", idEmpleado);
                buscar.Parameters.AddWithValue("@contra", contra);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader reader = buscar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        empleado.id = reader.GetString(0);
                        empleado.contrasenna = reader.GetString(1);
                        empleado.rol = reader.GetString(2);
                        empleado.nombreEmpleado = reader.GetString(3);
                        empleado.estado = reader.GetBoolean(4);
                    }
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                return empleado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TOEmpleado obtenerEmpleado(string id)
        {
            try
            {
                TOEmpleado empleado = new TOEmpleado();
                SqlCommand buscar = new SqlCommand("SELECT * FROM cuenta_empleado WHERE id_cuenta = @id", conexion);
                buscar.Parameters.AddWithValue("@id", id);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader reader = buscar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        empleado.id = reader.GetString(0);
                        empleado.contrasenna = reader.GetString(1);
                        empleado.rol = reader.GetString(2);
                        empleado.nombreEmpleado = reader.GetString(3);
                        empleado.estado = reader.GetBoolean(4);
                    }
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                return empleado;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void insertarActualizar(TOEmpleado empleado)
        {
            try
            {
                string update = "begin tran if exists(select * from CUENTA_EMPLEADO with (updlock, serializable) where id_Cuenta = @idCuenta) begin update CUENTA_EMPLEADO set contrasenna = @contra, rol = @rol, nombre = @nombre, estado = @estado where id_Cuenta = @idCuenta; end else begin insert into cuenta_empleado(id_Cuenta, contrasenna, rol, nombre, estado) values(@idCuenta, @contra, @rol, @nombre, @estado); end commit tran";
                SqlCommand sentencia = new SqlCommand(update, conexion);
                sentencia.Parameters.AddWithValue("@idCuenta", empleado.id);
                sentencia.Parameters.AddWithValue("@contra", empleado.contrasenna);
                sentencia.Parameters.AddWithValue("@rol", empleado.rol);
                sentencia.Parameters.AddWithValue("@nombre", empleado.nombreEmpleado);
                sentencia.Parameters.AddWithValue("@estado", empleado.estado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<TOEmpleado> listaEmpleados()
        {
            
                try
                {
                    string select = "select * from cuenta_empleado";
                    SqlCommand sentencia = new SqlCommand(select, conexion);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = sentencia;
                    adapter.Fill(table);
                    List<TOEmpleado> lista = new List<TOEmpleado>();

                    for (int x = 0; x < table.Rows.Count; x++)
                    {
                        TOEmpleado emplead = new TOEmpleado();
                        emplead.id = Convert.ToString(table.Rows[x]["ID_CUENTA"]);
                        emplead.contrasenna = Convert.ToString(table.Rows[x]["CONTRASENNA"]);
                        emplead.rol = Convert.ToString(table.Rows[x]["ROL"]);
                        emplead.nombreEmpleado = Convert.ToString(table.Rows[x]["NOMBRE"]);
                        emplead.estado = Convert.ToBoolean(table.Rows[x]["ESTADO"]);
                        lista.Add(emplead);
                    }

                    return lista;
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
            
        }


    }
}

