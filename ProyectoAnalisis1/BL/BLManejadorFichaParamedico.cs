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
            try
            {
                DAOFichaParamedico dao = new DAOFichaParamedico();
                //return dao.insertar(convert(bl));
                dao.guardarModificar(convert(bl));
            } catch (Exception) {
                throw;
            }
        }

        public BLFichaParamedico consultar(int idConsulta) {
            try
            {
                DAOFichaParamedico dao = new DAOFichaParamedico();
                return convert(dao.consultar(idConsulta));
            } catch (Exception) {
                throw;
            }
        }

        private TOFichaParamedico convert(BLFichaParamedico exp)
        {
            return new TOFichaParamedico(exp.id_Paramedico,
                exp.idConsulta, exp.idEmpleado,exp.presionArterial, exp.temperatura, exp.estatura,
                exp.peso, exp.glicemia, exp.oximetria_Pulso, exp.observacion, exp.glasgow, 
                exp.frec_card, exp.frec_resp, exp.pupilas, exp.piel, exp.nota_param);
        }

        private BLFichaParamedico convert(TOFichaParamedico exp)
        {
            return new BLFichaParamedico(exp.id_Paramedico,
                exp.idConsulta, exp.idEmpleado, exp.presionArterial, exp.temperatura, exp.estatura,
                exp.peso, exp.glicemia, exp.oximetria_Pulso, exp.observacion, exp.glasgow,
                exp.frec_card, exp.frec_resp, exp.pupilas, exp.piel, exp.nota_param);
        }
    }
}
