using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLDireccion
    {
        public int idDireccion { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public string otrasSenas { get; set; }

        public BLDireccion(int idDireccion, string provincia, string canton, string distrito, string otrasSenas) {
            this.idDireccion = idDireccion;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.otrasSenas = otrasSenas;
        }
    }
}
