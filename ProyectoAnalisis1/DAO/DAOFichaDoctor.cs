using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data;


namespace DAO
{
    public class DAOFichaDoctor
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public void insertarMod(TOFichaDoctor to) {
            try
            {
                string update = "begin tran if exists(select * from ficha_doctor with (updlock, serializable) where id_doctor = @id_doctor) begin update ficha_doctor set id_consulta = @id_consulta, motivo_consulta= @motivo_consulta, examen_fisico = @examen_fisico, recomendacion = @recomendacion, id_cuenta = @id_cuenta where id_doctor = @id_doctor; end else begin insert into Ficha_doctor(id_doctor, id_consulta, motivo_consulta, examen_fisico, recomendacion, id_cuenta) values (@id_doctor, @id_consulta, @motivo_consulta, @examen_fisico, @recomendacion, @id_cuenta); end commit tran";

                SqlCommand sentencia = new SqlCommand(update, conexion);
                sentencia.Parameters.AddWithValue("@id_doctor", to.idDoctor);
                sentencia.Parameters.AddWithValue("@id_consulta", to.idConsulta);
                sentencia.Parameters.AddWithValue("@motivo_consulta", to.motivoConsulta);
                sentencia.Parameters.AddWithValue("@examen_fisico", to.examenFisico);
                sentencia.Parameters.AddWithValue("@recomendacion", to.plan);
                sentencia.Parameters.AddWithValue("@id_cuenta", to.idEmpleado);
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

        public void insertar(TOFichaDoctor ficha)
        {
            try
            {
                string insert = "insert into ficha_doctor (id_consulta, motivo_consulta, " +
                    "examen_fisico, recomendacion, id_cuenta) values (@id_consulta, @motivo, @examen, @plan, @idEmpleado)";

                SqlCommand insertar = new SqlCommand(insert, conexion);
                insertar.Parameters.AddWithValue("@id_consulta", ficha.idConsulta);
                insertar.Parameters.AddWithValue("@motivo", ficha.motivoConsulta);
                insertar.Parameters.AddWithValue("@examen", ficha.examenFisico);
                insertar.Parameters.AddWithValue("@plan", ficha.plan);
                insertar.Parameters.AddWithValue("@idEmpleado", ficha.idEmpleado);


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
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                conexion.Close();
            }
        }

        public TOFichaDoctor consultar(int idConsulta) {
            try
            {
                TOFichaDoctor to = new TOFichaDoctor();

            string select = "select * from ficha_doctor where id_Consulta = @idConsulta;";
            SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@idConsulta", idConsulta);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    to.idDoctor = reader.GetInt32(0);
                    to.idConsulta = reader.GetInt32(1);
                    to.motivoConsulta = reader.GetString(2);
                    to.examenFisico = reader.GetString(3);
                    to.plan = reader.GetString(4);
                    to.idEmpleado = reader.GetString(5);
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

        public void insertarFoto(TOFoto foto)
        {
            try
            {
                string insert = "insert into Foto_Ficha_Doctor (URLFoto, ID_CONSULTA) values (@url, @id)";

                SqlCommand insertar = new SqlCommand(insert, conexion);
                insertar.Parameters.AddWithValue("@url", foto.url);
                insertar.Parameters.AddWithValue("@id", foto.idDoctor);
                
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

        public TOFoto consultarFoto(int idConsulta) {
            try
            {
                TOFoto to = new TOFoto();

                string select = "select * from foto_ficha_doctor where id_Consulta = @idConsulta;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
                sentencia.Parameters.AddWithValue("@idConsulta", idConsulta);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader reader = sentencia.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        to.url = reader.GetString(0);
                        to.idDoctor= reader.GetInt32(1);
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
    }
}
