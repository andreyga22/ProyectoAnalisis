using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOFoto
    {

        public string url { get; set; }
        public int idDoctor { get; set; }

        public TOFoto(string url, int idDoctor)
        {
            this.url = url;
            this.idDoctor = idDoctor;
        }

        public TOFoto() { }
    }
}
