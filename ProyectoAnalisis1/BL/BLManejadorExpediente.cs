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

        public void insertarModificar(BLExpediente bl) {
            DAOExpediente dao = new DAOExpediente();
            try
            {
                dao.guardarActualizar(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public List<BLExpediente> consultarListaExpedNombre(string nombre)
        {
            try
            {
                DAOExpediente dao = new DAOExpediente();
                List<TOExpediente> listaTO = dao.consultarListaExpedNombre(nombre);
                List<BLExpediente> listaBL = new List<BLExpediente>();
                foreach (TOExpediente consulta in listaTO)
                {
                    listaBL.Add(convert(consulta));
                }
                return listaBL;
            } catch (Exception) {
                throw;
            }
        }

        public BLExpediente consultarExpediente(string cedula) {
            try {
                DAOExpediente dao = new DAOExpediente();
                return convert(dao.consultar(cedula));
            } catch (Exception) {
                throw;
            }
        }

        

        private TOExpediente convert(BLExpediente exp) {
            return new TOExpediente(exp.cedula, 
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido, 
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil, 
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
        }

        private BLExpediente convert(TOExpediente exp)
        {
            return new BLExpediente(exp.cedula,
                exp.primer_nombre, exp.segundo_nombre, exp.primer_apellido, exp.segundo_apellido,
                exp.fecha_nacimiento, exp.num_telefono, exp.religion, exp.estado_civil,
                exp.tipo_trabajo, exp.sexo, exp.tel2, exp.tel3, exp.descripcion_tel2, exp.descripcion_tel3);
        }

        public void prueba() {
            DAOExpediente dao = new DAOExpediente();
            dao.pruebaConexion();
        }

        public void actualizarExpediente(BLExpediente bl)
        {
            DAOExpediente dao = new DAOExpediente();
            dao.actualizar(convert(bl));
        }

        
    }
}
