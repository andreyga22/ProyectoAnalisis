using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI {
    public partial class mainMaster : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void linkCerrarSesion_Click(object sender, EventArgs e) {
            Response.Redirect("InicioDeSesion.aspx");
        }

        protected void linkConfigEmplea_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfigEmplead.aspx");
        }

        protected void cambiar() {
            if (((BLEmpleado)Session["empleado"]).rol.Equals("Admin")) {
                Response.Redirect("Administrador.aspx");
            } else {
                Response.Redirect("PaginaPrincipal.aspx");
            }
        }

        protected void linkAyuda_Click(object sender, EventArgs e) {
            Response.Redirect("Ayuda.aspx");
        }
    }
}