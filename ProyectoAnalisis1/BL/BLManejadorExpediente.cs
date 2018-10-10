using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;
namespace BL
{
    public class BLManejadorExpediente
    {
        public void modificarExpediente() {

        }

        public void insertarExpediente(BLExpediente bl) {
            DAOExpediente dao = new DAOExpediente();
            dao.insertar(convert(bl));
        }

        public void borrarExpediente() {

        }

        public void consultarExpediente(string cedula) {

        }

        private TOExpediente convert(BLExpediente exp) {
            return new TOExpediente(exp.cedula, 
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido, 
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil, 
                exp.tipo_trabajo, exp.sexo);
        }

        private BLExpediente convert(TOExpediente exp)
        {
            return new BLExpediente(exp.cedula,
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido,
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil,
                exp.tipo_trabajo, exp.sexo);
        }

        public void prueba() {
            DAOExpediente dao = new DAOExpediente();
            dao.pruebaConexion();
        }
    }
}
