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
        public BLExpediente expediente { get; set; }
        public BLFichaParamedico fichaParam { get; set; }
        public BLFichaDoctor fichaDoctor { get; set; }

        public TOConsulta(int idConsulta)
        {

        }
    }
}
