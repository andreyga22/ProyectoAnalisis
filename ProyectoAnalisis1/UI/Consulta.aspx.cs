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
            if(!IsPostBack) {
                Response.Write(Convert.ToInt32(Session["idConsulta"]));
                BLManejadorConsulta blm = new BLManejadorConsulta();
                BLConsulta con = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
                fecha.Text = Convert.ToString(con.fecha);
                precioText.Text = Convert.ToString(con.precio_Consulta);
            }
        }
        

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            BLManejadorConsulta blm = new BLManejadorConsulta();
            string precio = precioText.Text.Trim();
            blm.modificar(Convert.ToInt32(Session["idConsulta"]), Convert.ToInt32( precioText.Text.Trim()));
        }

        protected void entrarDoctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaDoctor.aspx");
        }

        protected void entrarParamedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaParamedico.aspx");
        }
    }
}