using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAOExpediente
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public void insertar(TOExpediente to) {
            string insert = "insert into expediente (cedula," +
                " nombre1, nombre2, apellido1, apellido2, fecha_Nacimiento, numero_telefono, religion," +
                " estado_civil, tipo_trabajo, sexo) values (@cedula, @nombre1," +
                " @nombre2, @apellido1, @apellido2, @fecha_Nacimiento, @numero_telefono, @religion," +
                " @estado_civil, @tipo_trabajo, @sexo)";
            SqlCommand insertar = new SqlCommand(insert, conexion);
            insertar.Parameters.AddWithValue("@cedula", to.cedula);
            insertar.Parameters.AddWithValue("@nombre1", to.primer_nombre);
            insertar.Parameters.AddWithValue("@nombre2", to.segundo_nombre);
            insertar.Parameters.AddWithValue("@apellido1", to.primer_apellido);
            insertar.Parameters.AddWithValue("@apellido2", to.segundo_apellido);
            insertar.Parameters.AddWithValue("@fecha_nacimiento", to.fecha_nacimiento);
            insertar.Parameters.AddWithValue("@numero_telefono", to.num_telefono);
            insertar.Parameters.AddWithValue("@religion", to.religion);
            insertar.Parameters.AddWithValue("@estado_civil", to.estado_civil);
            insertar.Parameters.AddWithValue("@tipo_trabajo", to.tipo_trabajo);
            insertar.Parameters.AddWithValue("@sexo", to.sexo);

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            insertar.ExecuteNonQuery();

            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public TOExpediente consultar(string expId) {
            //try
            //{
                TOExpediente to = new TOExpediente();

                string select = "select * from expediente where cedula = @ced;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
                sentencia.Parameters.AddWithValue("@ced", expId);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader reader = sentencia.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        to.cedula = reader.GetString(0);
                        to.primer_nombre = reader.GetString(1);
                        to.segundo_nombre = reader.GetString(2);
                        to.primer_apellido = reader.GetString(3);
                        to.segundo_apellido = reader.GetString(4);
                        to.fecha_nacimiento = reader.GetDateTime(5);
                        to.num_telefono = reader.GetString(6);
                        to.religion = reader.GetString(7);
                        to.estado_civil = reader.GetString(8);
                        to.tipo_trabajo = reader.GetString(9);
                        to.sexo = reader.GetString(10);
                    }
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                return to;
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
            //catch (Exception ex2)
            //{
            //    throw ex2;
            //}
            //finally
            //{
            //    conexion.Close();
            //}
        }

        public void actualizar(TOExpediente to) {
            try
            {
                string update = "update expediente set nombre1=@nombre1, nombre2=@nombre2, apellido1=@apellido1, apellido2=@apellido2, fecha_nacimiento=@fecha_nacimiento, numero_telefono =@numero_telefono, religion=@religion, estado_civil=@estado_civil, tipo_trabajo=@tipo_trabajo, sexo=@sexo where cedula=@cedula;";
               
                SqlCommand sentencia = new SqlCommand(update, conexion);
            sentencia.Parameters.AddWithValue("@cedula", to.cedula);
            sentencia.Parameters.AddWithValue("@nombre1", to.primer_nombre);
            sentencia.Parameters.AddWithValue("@nombre2", to.segundo_nombre);
            sentencia.Parameters.AddWithValue("@apellido1", to.primer_apellido);
            sentencia.Parameters.AddWithValue("@apellido2", to.segundo_apellido);
            sentencia.Parameters.AddWithValue("@fecha_nacimiento", to.fecha_nacimiento);
            sentencia.Parameters.AddWithValue("@numero_telefono", to.num_telefono);
            sentencia.Parameters.AddWithValue("@religion", to.religion);
            sentencia.Parameters.AddWithValue("@estado_civil", to.estado_civil);
            sentencia.Parameters.AddWithValue("@tipo_trabajo", to.tipo_trabajo);
            sentencia.Parameters.AddWithValue("@sexo", to.sexo);

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
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void guardarActualizar(TOExpediente to) {
            try
            {
                string update = "begin tran if exists(select * from EXPEDIENTE with (updlock, serializable) where CEDULA = @cedula) begin update expediente set nombre1 = @nombre1, nombre2 = @nombre2, apellido1 = @apellido1, apellido2 = @apellido2, FECHA_NACIMIENTO = @fecha_nacimiento, numero_telefono = @numero_telefono, religion = @religion, estado_civil = @estado_civil, tipo_trabajo = @tipo_trabajo, sexo = @sexo where cedula = @cedula; end else begin insert into expediente(cedula, nombre1, nombre2, apellido1, apellido2, fecha_Nacimiento, numero_telefono, religion, estado_civil, tipo_trabajo, sexo) values(@cedula, @nombre1, @nombre2, @apellido1, @apellido2, @fecha_nacimiento, @numero_telefono, @religion, @estado_civil, @tipo_trabajo, @sexo); end commit tran";
                
                SqlCommand sentencia = new SqlCommand(update, conexion);
            sentencia.Parameters.AddWithValue("@cedula", to.cedula);
            sentencia.Parameters.AddWithValue("@nombre1", to.primer_nombre);
            sentencia.Parameters.AddWithValue("@nombre2", to.segundo_nombre);
            sentencia.Parameters.AddWithValue("@apellido1", to.primer_apellido);
            sentencia.Parameters.AddWithValue("@apellido2", to.segundo_apellido);
            sentencia.Parameters.AddWithValue("@fecha_nacimiento", to.fecha_nacimiento);
            sentencia.Parameters.AddWithValue("@numero_telefono", to.num_telefono);
            sentencia.Parameters.AddWithValue("@religion", to.religion);
            sentencia.Parameters.AddWithValue("@estado_civil", to.estado_civil);
            sentencia.Parameters.AddWithValue("@tipo_trabajo", to.tipo_trabajo);
            sentencia.Parameters.AddWithValue("@sexo", to.sexo);

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
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                conexion.Close();
            }
        }













        public void pruebaConexion() {
            
                SqlCommand insertar = new SqlCommand("Insert into DIRECCION values (2, 'alajuela', 'san ramon', 'san ramon', 'porahi')", conexion);
                //insertar.Parameters.AddWithValue("@Id", direccion.idDireccion);
                //insertar.Parameters.AddWithValue("@Prov", direccion.provincia);
                //insertar.Parameters.AddWithValue("@Cant", direccion.canton);
                //insertar.Parameters.AddWithValue("@Dist", direccion.distrito);
                //insertar.Parameters.AddWithValue("@Otras", direccion.otrasSenas);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
        }
    }
}
