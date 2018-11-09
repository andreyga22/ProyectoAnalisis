using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TO;
using System.Data;

namespace DAO
{
    public class DAOFichaParamedico
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        //public Boolean insertar(TOFichaParamedico ficha)
        //{
        //    try
        //    {
        //        string insert = "insert into FICHA_PARAMEDICO (id_consulta, presion_arterial, " +
        //            "temperatura, estatura, peso, glicemia, oximetria_pulso, observaciones, glasgow, pupilas, piel, frec_card, frec_resp, notas_param, id_cuenta) " +
        //            "values (@id_consulta, @presion, @temperatura, @estatura, @peso, @glicemia, @oximetria_pulso, " +
        //            "@observaciones, @glasgow, @pupilas, @piel, @frec_card, @frec_resp, @notas, @idEmpleado)";

        //        SqlCommand insertar = new SqlCommand(insert, conexion);
        //        insertar.Parameters.AddWithValue("@id_consulta", ficha.idConsulta);
        //        insertar.Parameters.AddWithValue("@presion", ficha.presionArterial);
        //        insertar.Parameters.AddWithValue("@glicemia", ficha.glicemia);
        //        insertar.Parameters.AddWithValue("@temperatura", ficha.temperatura);
        //        insertar.Parameters.AddWithValue("@estatura", ficha.estatura);
        //        insertar.Parameters.AddWithValue("@peso", ficha.peso);
        //        insertar.Parameters.AddWithValue("@oximetria_pulso", ficha.oximetria_Pulso);
        //        insertar.Parameters.AddWithValue("@observaciones", ficha.observacion);
        //        insertar.Parameters.AddWithValue("@glasgow", ficha.glasgow);
        //        insertar.Parameters.AddWithValue("@pupilas", ficha.pupilas);
        //        insertar.Parameters.AddWithValue("@piel", ficha.piel);
        //        insertar.Parameters.AddWithValue("@frec_card", ficha.frec_card);
        //        insertar.Parameters.AddWithValue("@frec_resp", ficha.frec_resp);
        //        insertar.Parameters.AddWithValue("@notas", ficha.nota_param);
        //        insertar.Parameters.AddWithValue("@idEmpleado", ficha.idEmpleado);

        //        if (conexion.State != System.Data.ConnectionState.Open)
        //        {
        //            conexion.Open();
        //        }

        //        insertar.ExecuteNonQuery();

        //        if (conexion.State != System.Data.ConnectionState.Closed)
        //        {
        //            conexion.Close();
        //        }
        //        return true;
        //} catch
        //    {
        //        if(conexion.State != System.Data.ConnectionState.Closed)
        //        {
        //            conexion.Close();
        //        }
        //        return false;
        //    }
        //}

            public void guardarModificar(TOFichaParamedico ficha) {
            try
            {

                SqlCommand insertar = new SqlCommand("begin tran if exists(select * from ficha_paramedico with (updlock, serializable) " +
                    "where id_paramedico = @idParamedico) begin update ficha_paramedico set presion_arterial = @presion, temperatura = @temperatura, estatura = @estatura, peso = @peso, glicemia = @glicemia, oximetria_pulso = @oximetria_pulso, id_consulta = @id_consulta, " +
                    "observaciones = @observaciones, glasgow = @glasgow, pupilas = @pupilas, piel = @piel, frec_card = @frec_card, frec_resp = @frec_resp, notas_param = @notas, id_cuenta = @idEmpleado " +
                    "where id_paramedico = @idParamedico; end else begin insert into ficha_paramedico (id_consulta, presion_arterial, " +
             "temperatura, estatura, peso, glicemia, oximetria_pulso, observaciones, glasgow, pupilas, piel, frec_card, frec_resp, notas_param, id_cuenta) " +
             "values (@id_consulta, @presion, @temperatura, @estatura, @peso, @glicemia, @oximetria_pulso, " +
             "@observaciones, @glasgow, @pupilas, @piel, @frec_card, @frec_resp, @notas, @idEmpleado); end commit tran", conexion);
                insertar.Parameters.AddWithValue("@idParamedico", ficha.id_Paramedico);
                insertar.Parameters.AddWithValue("@id_consulta", ficha.idConsulta);
                insertar.Parameters.AddWithValue("@presion", ficha.presionArterial);
                insertar.Parameters.AddWithValue("@glicemia", ficha.glicemia);
                insertar.Parameters.AddWithValue("@temperatura", ficha.temperatura);
                insertar.Parameters.AddWithValue("@estatura", ficha.estatura);
                insertar.Parameters.AddWithValue("@peso", ficha.peso);
                insertar.Parameters.AddWithValue("@oximetria_pulso", ficha.oximetria_Pulso);
                insertar.Parameters.AddWithValue("@observaciones", ficha.observacion);
                insertar.Parameters.AddWithValue("@glasgow", ficha.glasgow);
                insertar.Parameters.AddWithValue("@pupilas", ficha.pupilas);
                insertar.Parameters.AddWithValue("@piel", ficha.piel);
                insertar.Parameters.AddWithValue("@frec_card", ficha.frec_card);
                insertar.Parameters.AddWithValue("@frec_resp", ficha.frec_resp);
                insertar.Parameters.AddWithValue("@notas", ficha.nota_param);
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
            } catch (Exception) {
                throw;
            }
        }

        public TOFichaParamedico consultar(int idConsulta) {
            try
            {
                TOFichaParamedico to = new TOFichaParamedico();

            string select = "select * from ficha_paramedico where id_consulta = @idConsulta;";
            SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@idconsulta", idConsulta);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    to.presionArterial = reader.GetString(0);
                    to.temperatura = reader.GetInt32(1);
                    to.estatura = reader.GetInt32(2);
                    to.peso = reader.GetInt32(3);
                    to.glicemia = reader.GetString(4);
                    to.oximetria_Pulso = reader.GetString(5);
                    to.id_Paramedico = reader.GetInt32(6);
                    to.idConsulta = reader.GetInt32(7);
                    to.observacion = reader.GetString(8);
                    to.glasgow = reader.GetInt32(9);
                    to.pupilas = reader.GetString(10);
                    to.piel = reader.GetString(11);
                    to.frec_card = reader.GetInt32(12);
                    to.frec_resp = reader.GetInt32(13);
                    to.nota_param = reader.GetString(14);
                    to.idEmpleado = reader.GetString(15);
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
