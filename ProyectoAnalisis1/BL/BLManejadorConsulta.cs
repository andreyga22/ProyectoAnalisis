using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;


namespace BL
{
    public class BLManejadorConsulta
    {
        public void insertar(BLConsulta bl) {
            try
            {
                DAOConsulta dao = new DAOConsulta();
                dao.insertar(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public BLConsulta consultar(int idConsulta) {
            try { 
            return convert( new DAOConsulta().consultar(idConsulta));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int consultarUltimo(String cedula)
        {
            try { 
            return new DAOConsulta().consultarUltimo(cedula);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int consultarUltimoConsultaID()
        {
            try
            {
                return new DAOConsulta().consultarUltimaConsultaId();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificar(int idConsulta, int precio) {
            try { 
            DAOConsulta dao = new DAOConsulta();
            dao.modificar(idConsulta, precio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BLConsulta> listaConsultas(String cedula) {
            try { 
            DAOConsulta dao = new DAOConsulta();
            List<TOConsulta> listaTO = dao.listaConsulta(cedula);
            List<BLConsulta> listaBL = new List<BLConsulta>();
            foreach (TOConsulta consulta in listaTO)
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

        public List<BLConsulta> listaConsultasOrdenado(String cedula)
        {
            try { 
            DAOConsulta dao = new DAOConsulta();
            List<TOConsulta> listaTO = dao.listaConsultaOrdenada(cedula);
            List<BLConsulta> listaBL = new List<BLConsulta>();
            foreach (TOConsulta consulta in listaTO)
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


        public BLConsulta convert(TOConsulta to)
        {
            return new BLConsulta(to.idConsulta, to.fecha, to.cedula, to.precio_Consulta);
        }

        public TOConsulta convert(BLConsulta bl)
        {
            return new TOConsulta(bl.idConsulta, bl.fecha, bl.cedula, bl.precio_Consulta);
        }

        
    }
}
