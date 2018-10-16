using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Consulta : System.Web.UI.Page
    {
        private DateTime fecha1 = DateTime.Now;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLManejadorConsulta blm = new BLManejadorConsulta();
            BLConsulta con =  blm.consultar(2);
            fecha.Text = Convert.ToString( con.fecha);
            precioText.Text = Convert.ToString(con.precio_Consulta);
            verCartas();
        }

        private void verCartas() {

            fichaDoctor.Text = "<div class=\"card\" style=\"width: 18rem; \"> " +
                    "<img class=\"card-img-top\" src=\"img/doctor.jpg\" alt=\"Doctor\">"+
                    "<div class=\"card-body\">" +
                        "<h5 class=\"card-title\">Ficha Doctor</h5>" +
                        "<p class=\"card-text\">Ficha con el formulario del doctor(a).</p>" +
                        "<a href = \"#\" class=\"btn btn-primary\">Entrar</a>" +
                    "</div>" +
                "</div>";

            fichaParam.Text = "<div class=\"card\" style=\"width: 18rem; \"> " +
                    "<img class=\"card-img-top\" src=\"img/paramedicos.jpg\" alt=\"Paramedicos\">" +
                    "<div class=\"card-body\">" +
                        "<h5 class=\"card-title\">Ficha Paramedicos</h5>" +
                        "<p class=\"card-text\">Ficha con el formulario del paramedico(a).</p>" +
                        "<a href = \"#\" class=\"btn btn-primary\">Entrar</a>" +
                    "</div>" +
                "</div>";

        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            BLManejadorConsulta blm = new BLManejadorConsulta();
            blm.insertar(new BLConsulta(0, fecha1, "504060873", Convert.ToInt32( precioText.Text.Trim())));
        }
    }
}