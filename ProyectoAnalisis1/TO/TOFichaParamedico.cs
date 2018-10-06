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
        public String presionArterial { get; set; }
        public int temperatura { get; set; }
        public int estatura { get; set; }
        public int peso { get; set; }
        public String nivel_Azucar { get; set; }
        public String glicemia { get; set; }
        public String oximetria_Pulso { get; set; }
        public String observacion { get; set; }


        public TOFichaParamedico()
        {

        }

        public TOFichaParamedico(int id_Paramedico, String presionArterial, int temperatura, int estatura,
            int peso, String nivel_Azucar, String glicemia, String oximetria_Pulso, String observacion)
        {
            this.id_Paramedico = id_Paramedico;
            this.presionArterial = presionArterial;
            this.temperatura = temperatura;
            this.estatura = estatura;
            this.peso = peso;
            this.nivel_Azucar = nivel_Azucar;
            this.glicemia = glicemia;
            this.oximetria_Pulso = oximetria_Pulso;
            this.observacion = observacion;
        }
    }
}
