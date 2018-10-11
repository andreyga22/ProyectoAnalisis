using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TO;

namespace DAO
{
    class DAOFichaParamedico
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public void insertar(TOFichaParamedico ficha)
        {
            string insert = "insert into FICHA_PARAMEDICO (presion_arterial, " +
                "temperatura, estatura, peso, niveles_azucar, oximetria_pulso, observaciones) " +
                "values (@presion, @temperatura, @estatura, @peso, @niveles_azucar, @oximetria_pulso, " +
                "@observaciones)";

            SqlCommand insertar = new SqlCommand(insert, conexion);
            insertar.Parameters.AddWithValue("@presion", ficha.presionArterial);
            insertar.Parameters.AddWithValue("@temperatura", ficha.temperatura);
            insertar.Parameters.AddWithValue("@estatura", ficha.estatura);
            insertar.Parameters.AddWithValue("@peso", ficha.peso);
            insertar.Parameters.AddWithValue("@niveles_azucar", ficha.nivel_Azucar);
            insertar.Parameters.AddWithValue("@oximetria_pulso", ficha.oximetria_Pulso);
            insertar.Parameters.AddWithValue("@observaciones", ficha.observacion);

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
