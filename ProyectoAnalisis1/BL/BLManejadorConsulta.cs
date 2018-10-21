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
            DAOConsulta dao = new DAOConsulta();
            dao.insertar(convert(bl));
        }

        public BLConsulta consultar(int idConsulta) {
            return convert( new DAOConsulta().consultar(idConsulta));
        }

        public List<BLConsulta> listaConsultas(String cedula) {
            DAOConsulta dao = new DAOConsulta();
            List<TOConsulta> listaTO = dao.listaConsulta(cedula);
            List<BLConsulta> listaBL = new List<BLConsulta>();
            foreach (TOConsulta consulta in listaTO)
            {
                listaBL.Add(convert(consulta));
            }
            return listaBL;
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
