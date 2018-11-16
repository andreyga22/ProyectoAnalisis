using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOEmpleado
    {
        public String id { get; set; }
        public String contrasenna { get; set; }
        public String nombreEmpleado { get; set; }
        public String rol { get; set; }
        public Boolean estado { get; set; }


        public TOEmpleado()
        {

        }

        public TOEmpleado(String id, String contra, String rol, String nombreEmpleado, Boolean estado)
        {
            this.id = id;
            this.contrasenna = contra;
            this.rol = rol;
            this.nombreEmpleado = nombreEmpleado;
            this.estado = estado;
        }
    }
}
