using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class BLManejadorFichaDoctor
    {

        public void insertar(BLFichaDoctor bl) {
            try
            {
                DAOFichaDoctor dao = new DAOFichaDoctor();
                dao.insertarMod(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public BLFichaDoctor consultar(int idConsulta) {
            try
            {
                DAOFichaDoctor dao = new DAOFichaDoctor();
                return convert(dao.consultar(idConsulta));
            } catch (Exception) {
                throw;
            }
}

        private TOFichaDoctor convert(BLFichaDoctor exp)
        {
            return new TOFichaDoctor(exp.idDoctor,
                exp.idConsulta, exp.idEmpleado,exp.motivoConsulta, exp.examenFisico, exp.plan);
        }

        private BLFichaDoctor convert(TOFichaDoctor exp)
        {
            return new BLFichaDoctor(exp.idDoctor,
                exp.idConsulta, exp.idEmpleado,exp.motivoConsulta, exp.examenFisico, exp.plan);
        }
    }
}
