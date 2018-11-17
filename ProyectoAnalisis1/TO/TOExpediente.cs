using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOExpediente
    {
        public String cedula { get; set; }
        public String primer_nombre { get; set; }
        public String segundo_nombre { get; set; }
        public String primer_apellido { get; set; }
        public String segundo_apellido { get; set; }
        private DateTime FechaNacimiento;
        public DateTime fecha_nacimiento {
            get { return FechaNacimiento; }
            set {
                FechaNacimiento = value.Date;
            }
        }
        public String num_telefono { get; set; }
        public String religion { get; set; }
        public String estado_civil { get; set; }
        public String tipo_trabajo { get; set; }
        public String sexo { get; set; }
        public String tel2 { get; set; }
        public String tel3 { get; set; }
        public String descripcion_tel2 { get; set; }
        public String descripcion_tel3 { get; set; }

        public TOExpediente(string cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, DateTime fecha_nacimiento, string num_telefono, string religion, string estado_civil, string tipo_trabajo, String sexo, string tel2, string tel3, string descripcion_tel2, string descripcion_tel3)
        {
            this.cedula = cedula;
            this.primer_nombre = primer_nombre;
            this.segundo_nombre = segundo_nombre;
            this.primer_apellido = primer_apellido;
            this.segundo_apellido = segundo_apellido;
            this.fecha_nacimiento = fecha_nacimiento.Date;
            this.num_telefono = num_telefono;
            this.religion = religion;
            this.estado_civil = estado_civil;
            this.tipo_trabajo = tipo_trabajo;
            this.sexo = sexo;
            this.tel2 = tel2;
            this.tel3 = tel3;
            this.descripcion_tel2 = descripcion_tel2;
            this.descripcion_tel3 = descripcion_tel3;
        }

        public TOExpediente()
        {
        }
    }

}


