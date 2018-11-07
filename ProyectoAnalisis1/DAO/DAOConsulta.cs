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
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);

        public void insertar(TOConsulta consulta)
        {
            //try
            //{
            SqlCommand insertar = new SqlCommand("Insert into consulta (fecha, cedula, precio_consulta) values (@fecha, @cedula, @precio);", conexion);
            insertar.Parameters.AddWithValue("@fecha", consulta.fecha);
            insertar.Parameters.AddWithValue("@cedula", consulta.cedula);
            insertar.Parameters.AddWithValue("@precio", consulta.precio_Consulta);

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

        public int consultarUltimo(String cedula)
        {
            //try
            //{

            string select = "select id_consulta from consulta where cedula = @cedula;";
            SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@cedula", cedula);
            int to = -1;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    to = reader.GetInt32(0);
                }
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return to;
        }

        public TOConsulta consultar(int idConsulta) {
            //try
            //{
            TOConsulta to = new TOConsulta();

            string select = "select * from consulta where id_consulta = @idConsulta;";
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
                    to.fecha = reader.GetDateTime(0);
                    to.idConsulta = reader.GetInt32(1);
                    to.cedula = reader.GetString(2);
                    to.precio_Consulta = reader.GetInt32(3);
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

        public List<TOConsulta> listaConsulta(String cedula) {
            //try
            //{
                string select = "select * from Consulta where cedula = @id;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
            sentencia.Parameters.AddWithValue("@id", cedula);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sentencia;
                adapter.Fill(table);
                List<TOConsulta> lista = new List<TOConsulta>();

                for (int x = 0; x < table.Rows.Count; x++)
                {
                    TOConsulta consulta = new TOConsulta();
                    consulta.fecha = Convert.ToDateTime(table.Rows[x]["FECHA"]);
                    consulta.idConsulta = Convert.ToInt32(table.Rows[x]["ID_CONSULTA"]);
                    consulta.cedula = Convert.ToString(table.Rows[x]["CEDULA"]);
                    consulta.precio_Consulta = Convert.ToInt32(table.Rows[x]["PRECIO_CONSULTA"]);
                    lista.Add(consulta);
                }

                return lista;
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

        public void modificar(int idConsulta, int precio) {
            //try
            //{
                string update = "update consulta set precio_consulta=@precio where id_consulta=@idConsulta;";
                SqlCommand sentencia = new SqlCommand(update, conexion);
                sentencia.Parameters.AddWithValue("@precio", precio);
                sentencia.Parameters.AddWithValue("@idConsulta", idConsulta);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
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
