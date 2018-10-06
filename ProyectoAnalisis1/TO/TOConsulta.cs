using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOConsulta
    {
        public int idConsulta { get; set; }
        public TOExpediente expediente { get; set; }
        public TOFichaParamedico fichaParam { get; set; }
        public TOFichaDoctor fichaDoctor { get; set; }

        public TOConsulta(int idConsulta)
        {

        }
    }
}
