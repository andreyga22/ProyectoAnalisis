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
    public class DAODireccion
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);
        public void insertarDireccion(TODireccion direccion)
        {
            //try
            //{
            SqlCommand insertar = new SqlCommand("Insert into DIRECCION (cedula, provincia, canton, distrito, otras_senas) values (@ced, @Prov, @Cant, @Dist, @Otras)", conexion);
            insertar.Parameters.AddWithValue("@ced", direccion.cedula);
            insertar.Parameters.AddWithValue("@Prov", direccion.provincia);
            insertar.Parameters.AddWithValue("@Cant", direccion.canton);
            insertar.Parameters.AddWithValue("@Dist", direccion.distrito);
            insertar.Parameters.AddWithValue("@Otras", direccion.otrasSenas);

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            insertar.ExecuteNonQuery();

            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}

        }


        public TODireccion consultar(String ced) {
            //try
            //{
            TODireccion to = new TODireccion();

            string select = "select * from direccion where cedula = @ced;";
            SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@ced", ced);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    to.idDireccion = reader.GetInt32(0);
                    to.cedula = reader.GetString(1);
                    to.provincia = reader.GetString(2);
                    to.canton = reader.GetString(3);
                    to.distrito = reader.GetString(4);
                    to.otrasSenas = reader.GetString(5);
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
