using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    class DAOFichaDoctor
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public void insertar(TOFichaDoctor ficha)
        {
            string insert = "insert into FICHA_PARAMEDICO (motivo_consulta, " +
                "examen_fisico, plan) values (@motivo, @examen, @plan)";

            SqlCommand insertar = new SqlCommand(insert, conexion);
            insertar.Parameters.AddWithValue("@motivo", ficha.motivoConsulta);
            insertar.Parameters.AddWithValue("@examen", ficha.examenFisico);
            insertar.Parameters.AddWithValue("@plan", ficha.plan);

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
    }
}
