﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOFichaDoctor
    {
        public int idDoctor { get; set; }
        public string motivoConsulta { get; set; }
        public string examenFisico { get; set; }
        public string plan { get; set; }

        public TOFichaDoctor(int idDoctor, string motivoConsulta, string examenFisico, string plan)
        {
            this.idDoctor = idDoctor;
            this.motivoConsulta = motivoConsulta;
            this.examenFisico = examenFisico;
            this.plan = plan;
        }
    }
}
