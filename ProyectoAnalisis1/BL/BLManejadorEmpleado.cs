using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;


namespace BL
{
    public class BLManejadorEmpleado
    {

        public BLEmpleado buscarEmpleado(string idEmpleado, string contra)
        {
            try
            {
                DAOEmpleado daoEmplead = new DAOEmpleado();
                TOEmpleado empleadoTO = daoEmplead.buscarEmpleado(idEmpleado, contra);
                if (empleadoTO == null)
                {
                    return null;
                }
                return new BLEmpleado(empleadoTO.id, empleadoTO.contrasenna, empleadoTO.rol, empleadoTO.nombreEmpleado, empleadoTO.estado);
            }catch (Exception)
            {
                throw;
            }
        }

        public BLEmpleado obtenerEmpleado(string idEmpleado)
        {
            try
            {
                DAOEmpleado daoEmplead = new DAOEmpleado();
                TOEmpleado empleadoTO = daoEmplead.obtenerEmpleado(idEmpleado);
                //if (empleadoTO == null)
                //{
                //    return null;
                //}


                return convert(empleadoTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void crearActualizarEmpleado(BLEmpleado empleado)
        {
                DAOEmpleado dao = new DAOEmpleado();
                try
                {
                    dao.insertarActualizar(convert(empleado));
                }
                catch (Exception)
                {
                    throw;
                }

        }

        public List<BLEmpleado> listaEmpleado()
        {
            try
            {
                DAOEmpleado dao = new DAOEmpleado();
                List<TOEmpleado> listaTO = dao.listaEmpleados();
                List<BLEmpleado> listaBL = new List<BLEmpleado>();
                foreach (TOEmpleado consulta in listaTO)
                {
                    listaBL.Add(convert(consulta));
                }
                return listaBL;
            }
            catch (Exception)
            {
                throw;
            }

        }



        private TOEmpleado convert(BLEmpleado emp)
        {
            return new TOEmpleado(emp.id, emp.contrasenna, emp.rol, emp.nombreEmpleado, emp.estado);
        }

        private BLEmpleado convert(TOEmpleado emp)
        {
            return new BLEmpleado(emp.id, emp.contrasenna, emp.rol, emp.nombreEmpleado, emp.estado);
        }

    }
}
