using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DAO
{
    public class DAOExpediente
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

       
        public TOExpediente consultar(string expId)
        {
            try
            {
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
                        to.descripcion_tel2 = reader.GetString(11);
                        to.descripcion_tel3 = reader.GetString(12);
                        to.tel2 = reader.GetString(13);
                        to.tel3 = reader.GetString(14);
                        
                    }
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return to;
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

        public void guardarActualizar(TOExpediente to)
        {
            try
            {
                string update = "begin tran if exists(select * from EXPEDIENTE with (updlock, serializable) where CEDULA = @cedula) begin update expediente set nombre1 = @nombre1, nombre2 = @nombre2, apellido1 = @apellido1, apellido2 = @apellido2, FECHA_NACIMIENTO = @fecha_nacimiento, numero_telefono = @numero_telefono, religion = @religion, estado_civil = @estado_civil, tipo_trabajo = @tipo_trabajo, sexo = @sexo, tel2 = @tel2, tel3 = @tel3, descripcion_tel2 = @descripcion_tel2, descripcion_tel3 = @descripcion_tel3 where cedula = @cedula; end else begin insert into expediente(cedula, nombre1, nombre2, apellido1, apellido2, fecha_Nacimiento, numero_telefono, religion, estado_civil, tipo_trabajo, sexo, tel2, tel3, descripcion_tel2, descripcion_tel3) values(@cedula, @nombre1, @nombre2, @apellido1, @apellido2, @fecha_nacimiento, @numero_telefono, @religion, @estado_civil, @tipo_trabajo, @sexo, @tel2, @tel3, @descripcion_tel2, @descripcion_tel3); end commit tran";

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
                sentencia.Parameters.AddWithValue("@tel2", to.tel2);
                sentencia.Parameters.AddWithValue("@tel3", to.tel3);
                sentencia.Parameters.AddWithValue("@descripcion_tel2", to.descripcion_tel2);
                sentencia.Parameters.AddWithValue("@descripcion_tel3", to.descripcion_tel3);
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

        public List<TOExpediente> consultarListaExpedNombre(String nombre)
        {
            //try
            //{
                String[] vectorNombreCompleto = Regex.Split(nombre, " ");
                List<TOExpediente> lista = new List<TOExpediente>();
                string select;
                SqlCommand sentencia;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                for (int i = 0; i < vectorNombreCompleto.Length; i++)
                {
                    select = "select * from expediente where lower(Nombre1) like @nomb or lower(Nombre2) like @nomb or lower(Apellido1) like @nomb or " +
                      "lower(Apellido2) like @nomb;";
                    sentencia = new SqlCommand(select, conexion);
                    sentencia.Parameters.AddWithValue("@nomb", vectorNombreCompleto[i]);
                    adapter.SelectCommand = sentencia;
                    adapter.Fill(table);

                    for (int x = 0; x < table.Rows.Count; x++)
                    {
                        TOExpediente expediente = new TOExpediente();
                        expediente.cedula = Convert.ToString(table.Rows[x]["CEDULA"]);
                        expediente.primer_nombre = Convert.ToString(table.Rows[x]["Nombre1"]);
                        expediente.segundo_nombre = Convert.ToString(table.Rows[x]["Nombre2"]);
                        expediente.primer_apellido = Convert.ToString(table.Rows[x]["Apellido1"]);
                        expediente.segundo_apellido = Convert.ToString(table.Rows[x]["Apellido2"]);
                        expediente.fecha_nacimiento = Convert.ToDateTime(table.Rows[x]["FECHA_NACIMIENTO"]);
                        expediente.num_telefono = Convert.ToString(table.Rows[x]["NUMERO_TELEFONO"]);
                        expediente.religion = Convert.ToString(table.Rows[x]["RELIGION"]);
                        expediente.estado_civil = Convert.ToString(table.Rows[x]["ESTADO_CIVIL"]);
                        expediente.tipo_trabajo = Convert.ToString(table.Rows[x]["TIPO_TRABAJO"]);
                        expediente.sexo = Convert.ToString(table.Rows[x]["SEXO"]);
                    expediente.descripcion_tel2 = Convert.ToString(table.Rows[x]["DESCRIPCION_TEL2"]);
                    expediente.descripcion_tel3 = Convert.ToString(table.Rows[x]["DESCRIPCION_TEL3"]);
                    expediente.tel2 = Convert.ToString(table.Rows[x]["TEL2"]);
                        expediente.tel3 = Convert.ToString(table.Rows[x]["TEL3"]);
                        

                        if (lista.Count == 0)
                        {
                            lista.Add(expediente);
                        }
                        else
                        {
                            for (int j = 0; j < lista.Count; j++)
                            {
                                if (!lista[j].cedula.Equals(expediente.cedula))
                                {
                                    lista.Add(expediente);
                                }
                            }
                        }
                    }
                }
                return lista;
            //} catch (SqlException) {
            //    throw;
            //} catch (Exception) {
            //    throw;
            //}
        }














        public void pruebaConexion()
        {

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

        public void insertar(TOExpediente to)
        {
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

        public void actualizar(TOExpediente to)
        {
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
    }
}
