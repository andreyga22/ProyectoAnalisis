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

        public void insertar(TOFichaParamedico ficha)
        {
            string insert = "insert into FICHA_PARAMEDICO (id_consulta, presion_arterial, " +
                "temperatura, estatura, peso, glicemia, oximetria_pulso, observaciones, glasgow, pupilas, piel, frec_card, frec_resp, notas_param) " +
                "values (@id_consulta, @presion, @temperatura, @estatura, @peso, @glicemia, @oximetria_pulso, " +
                "@observaciones, @glasgow, @pupilas, @piel, @frec_card, @frec_resp, @notas)";

            SqlCommand insertar = new SqlCommand(insert, conexion);
            insertar.Parameters.AddWithValue("@presion", ficha.presionArterial);
            insertar.Parameters.AddWithValue("@glicemia", ficha.glicemia);
            insertar.Parameters.AddWithValue("@temperatura", ficha.temperatura);
            insertar.Parameters.AddWithValue("@estatura", ficha.estatura);
            insertar.Parameters.AddWithValue("@peso", ficha.peso);
            insertar.Parameters.AddWithValue("@id_consulta", ficha.idConsulta);
            insertar.Parameters.AddWithValue("@oximetria_pulso", ficha.oximetria_Pulso);
            insertar.Parameters.AddWithValue("@observaciones", ficha.observacion);
            insertar.Parameters.AddWithValue("@glasgow", ficha.glasgow);
            insertar.Parameters.AddWithValue("@pupilas", ficha.pupilas);
            insertar.Parameters.AddWithValue("@piel", ficha.piel);
            insertar.Parameters.AddWithValue("@frec_card", ficha.frec_card);
            insertar.Parameters.AddWithValue("@frec_resp", ficha.frec_resp);
            insertar.Parameters.AddWithValue("@notas", ficha.nota_param);

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

        public TOFichaParamedico consultar(int idConsulta) {
            //try
            //{
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
        
    }
}
