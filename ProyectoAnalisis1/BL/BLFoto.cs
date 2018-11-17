using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLFoto
    {
        public string url { get; set; }
        public int idDoctor { get; set; }

        public BLFoto(string url, int idDoctor) {
            this.url = url;
            this.idDoctor = idDoctor;
        }

        public BLFoto() { }
    }
}
