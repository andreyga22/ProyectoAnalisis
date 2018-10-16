using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLConsulta
    {
        public int idConsulta { get; set; }
        public DateTime fecha { get; set; }
        public String cedula{ get; set; }
        public int precio_Consulta { get; set; }

        public BLConsulta(int idConsulta, DateTime fecha, String cedula, int precio_Consulta) {
            this.idConsulta = idConsulta;
            this.fecha = fecha;
            this.cedula = cedula;
            this.precio_Consulta = precio_Consulta;
        }

        public BLConsulta()
        {

        }
    }
}
