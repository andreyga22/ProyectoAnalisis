using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class BLManejadorFichaParamedico
    {
        public void insertar(BLFichaParamedico bl) {
            DAOFichaParamedico dao = new DAOFichaParamedico();
            dao.insertar(convert(bl));
        }

        public BLFichaParamedico consultar(int idConsulta) {
            DAOFichaParamedico dao = new DAOFichaParamedico();
            return convert(dao.consultar(idConsulta));
        }

        private TOFichaParamedico convert(BLFichaParamedico exp)
        {
            return new TOFichaParamedico(exp.id_Paramedico,
                exp.idConsulta, exp.presionArterial, exp.temperatura, exp.estatura,
                exp.peso, exp.glicemia, exp.oximetria_Pulso, exp.observacion);
        }

        private BLFichaParamedico convert(TOFichaParamedico exp)
        {
            return new BLFichaParamedico(exp.id_Paramedico,
                exp.idConsulta, exp.presionArterial, exp.temperatura, exp.estatura,
                exp.peso, exp.glicemia, exp.oximetria_Pulso, exp.observacion);
        }
    }
}
