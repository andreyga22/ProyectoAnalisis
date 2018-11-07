using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEmpleado
    {
        public String id { get; set; }
        public String contrasenna { get; set; }
        public String nombreEmpleado { get; set; }

        public BLEmpleado() {

        }

        public BLEmpleado(String id, String contra, String nombreEmpleado)
        {
            this.id = id;
            this.contrasenna = contra;
            this.nombreEmpleado = nombreEmpleado;
        }
    }
}
