using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOFichaParamedico
    {
        public int id_Paramedico { get; set; }
        public int idConsulta { get; set; }
        public String presionArterial { get; set; }
        public decimal temperatura { get; set; }
        public decimal estatura { get; set; }
        public decimal peso { get; set; }
        public String glicemia { get; set; }
        public String oximetria_Pulso { get; set; }
        public String observacion { get; set; }
        public int glasgow { get; set; }
        public int frec_card { get; set; }
        public String frec_resp { get; set; }
        public String pupilas { get; set; }
        public String piel { get; set; }
        public String nota_param { get; set; }
        public String idEmpleado { get; set; }

        public TOFichaParamedico()
        {

        }

        public TOFichaParamedico(int id_Paramedico, int idConsulta, String idEmpleado, String presionArterial, decimal temperatura, decimal estatura,
            decimal peso, String glicemia, String oximetria_Pulso, String observacion, int glasgow, int frec_card, String frec_resp,
            String pupilas, String piel, String nota_param)
        {
            this.id_Paramedico = id_Paramedico;
            this.idConsulta = idConsulta;
            this.idEmpleado = idEmpleado;
            this.presionArterial = presionArterial;
            this.temperatura = temperatura;
            this.estatura = estatura;
            this.peso = peso;
            this.glicemia = glicemia;
            this.oximetria_Pulso = oximetria_Pulso;
            this.observacion = observacion;
            this.glasgow = glasgow;
            this.frec_card = frec_card;
            this.frec_resp = frec_resp;
            this.pupilas = pupilas;
            this.piel = piel;
            this.nota_param = nota_param;
        }
    }
}
