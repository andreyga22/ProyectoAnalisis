using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TODireccion
    {
        public int idDireccion { get; set; }
        public string cedula { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public string otrasSenas { get; set; }

        public TODireccion(int idDireccion, string cedula, string provincia, string canton, string distrito, string otrasSenas)
        {
            this.idDireccion = idDireccion;
            this.cedula = cedula;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.otrasSenas = otrasSenas;
        }

        public TODireccion()
        {
        }
    }
}
