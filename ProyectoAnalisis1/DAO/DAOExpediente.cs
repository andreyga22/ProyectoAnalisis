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
            string insert = "insert into expediente (cedula," +
                " nombre1, nombre2, apellido1, apellido2, fecha_Nacimiento, numero_telefono, religion," +
                " estado_civil, tipo_trabajo, sexo) values (@cedula, @nombre1," +
                " @nombre2, @apellido1, @apellido2, @fecha_Nacimiento, @numero_telefono, @religion," +
                " @estado_civil, @tipo_trabajo, @sexo)";
            SqlCommand insertar = new SqlCommand(insert, conexion);
            insertar.Parameters.AddWithValue("@cedula", to.cedula);
            insertar.Parameters.AddWithValue("@nombre1", to.primer_nombre);
            insertar.Parameters.AddWithValue("@nombre2", to.segundo_nombre);
            insertar.Parameters.AddWithValue("@apellido1", to.primer_apellido);
            insertar.Parameters.AddWithValue("@apellido2", to.segundo_apellido);
            insertar.Parameters.AddWithValue("@fecha_nacimiento", to.fecha_nacimiento);
            insertar.Parameters.AddWithValue("@numero_telefono", to.num_telefono);
            insertar.Parameters.AddWithValue("@religion", to.religion);
            insertar.Parameters.AddWithValue("@estado_civil", to.estado_civil);
            insertar.Parameters.AddWithValue("@tipo_trabajo", to.tipo_trabajo);
            insertar.Parameters.AddWithValue("@sexo", to.sexo);

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
