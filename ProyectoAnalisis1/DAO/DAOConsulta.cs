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
    public class DAOConsulta
    {
        SqlConnection conexion = new SqlConnection(/*Properties.Settings.Default.conexion*/);

        public Boolean insertarConsulta(TOConsulta consulta)
        {
            try
            {
                SqlCommand insertar = new SqlCommand("Insert into CONSULTA values (@fecha, @idConsulta, @ced, @idParam, @idDoct, @precConsult)", conexion);
                insertar.Parameters.AddWithValue("@fecha", consulta.fecha);
                insertar.Parameters.AddWithValue("@idConsulta", consulta.idConsulta);
                insertar.Parameters.AddWithValue("@ced", consulta.cedula);
                insertar.Parameters.AddWithValue("@idParam", consulta.idParamedico);
                insertar.Parameters.AddWithValue("@idDoct", consulta.idDoctor);
                insertar.Parameters.AddWithValue("@idDoct", consulta.precio_Consulta);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
