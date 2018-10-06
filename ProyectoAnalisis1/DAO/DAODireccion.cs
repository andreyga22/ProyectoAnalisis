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
        SqlConnection conexion = new SqlConnection();
        public Boolean registrarDireccion(TODireccion direccion) {
            try
            {
                SqlCommand insertar = new SqlCommand("Insert into DIRECCION values (@Id, @Prov, @Cant, @Dist, @Otras)", conexion);
                insertar.Parameters.AddWithValue("@Id", direccion.idDireccion);
                insertar.Parameters.AddWithValue("@Prov", direccion.provincia);
                insertar.Parameters.AddWithValue("@Cant", direccion.canton);
                insertar.Parameters.AddWithValue("@Dist", direccion.distrito);
                insertar.Parameters.AddWithValue("@Otras", direccion.otrasSenas);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
