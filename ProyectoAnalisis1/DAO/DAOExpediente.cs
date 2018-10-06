using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
namespace DAO
{
    public class DAOExpediente
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conection);
        public void insertar(TOExpediente to) {

        }

        public void pruebaConexion() {
            
                SqlCommand insertar = new SqlCommand("Insert into DIRECCION values (2, 'alajuela', 'san ramon', 'san ramon', 'porahi')", conexion);
                //insertar.Parameters.AddWithValue("@Id", direccion.idDireccion);
                //insertar.Parameters.AddWithValue("@Prov", direccion.provincia);
                //insertar.Parameters.AddWithValue("@Cant", direccion.canton);
                //insertar.Parameters.AddWithValue("@Dist", direccion.distrito);
                //insertar.Parameters.AddWithValue("@Otras", direccion.otrasSenas);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
        }
    }
}
