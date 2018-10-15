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
            DAOFichaDoctor dao = new DAOFichaDoctor();
            dao.insertar(convert(bl));
        }

        public BLFichaDoctor consultar(int idConsulta) {
            DAOFichaDoctor dao = new DAOFichaDoctor();
            return convert(dao.consultar(idConsulta));
        }

        private TOFichaDoctor convert(BLFichaDoctor exp)
        {
            return new TOFichaDoctor(exp.idDoctor,
                exp.idConsulta, exp.motivoConsulta, exp.examenFisico, exp.plan);
        }

        private BLFichaDoctor convert(TOFichaDoctor exp)
        {
            return new BLFichaDoctor(exp.idDoctor,
                exp.idConsulta, exp.motivoConsulta, exp.examenFisico, exp.plan);
        }
    }
}
