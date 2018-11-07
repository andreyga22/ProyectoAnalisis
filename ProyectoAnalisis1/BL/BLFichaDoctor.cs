using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLFichaDoctor
    {
        public int idDoctor { get; set; }
        public int idConsulta { get; set; }
        public string motivoConsulta { get; set; }
        public string examenFisico { get; set; }
        public string plan { get; set; }
        public string idEmpleado { get; set; }

        public BLFichaDoctor(int idDoctor,  int idConsulta, string idEmpleado, string motivoConsulta, string examenFisico, string plan) {
            this.idDoctor = idDoctor;
            this.idConsulta = idConsulta;
            this.idEmpleado = idEmpleado;
            this.motivoConsulta = motivoConsulta;
            this.examenFisico = examenFisico;
            this.plan = plan;
        }
    }
}
