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

        public void insertar(TOFichaDoctor ficha)
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

        public TOFichaDoctor consultar(int idConsulta) {
            //try
            //{
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
