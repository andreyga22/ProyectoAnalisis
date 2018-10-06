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
            SqlCommand comando = new SqlCommand("insert into Direccion values () ");
        }
    }
}
