using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class InicioDeSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Master.FindControl("linkCerrarSesion").Visible = false;
            Session["iEmpleado"] = "";
            Session["rolEmpleado"] = "";
            Session["cedula"] = "";
            Session["idConsulta"] = "";
            lblError.Visible = false;
        }

        protected void entrarBtn_Click(object sender, EventArgs e)
        {
            String idUsuario = txtId.Text;
            String contra = txtContra.Text;

            BLEmpleado empleado = new BLManejadorEmpleado().buscarEmpleado(idUsuario, contra);

            try
            {
                if (empleado.id != null && !empleado.id.Equals(""))
                {
                    Session["iEmpleado"] = empleado.id;
                    Session["rolEmpleado"] = empleado.rol;
                    if (empleado.rol.Equals("Admin"))
                    {
                        Response.Redirect("Administrador.aspx");
                    }
                    else
                    {
                        Response.Redirect("PaginaPrincipal.aspx");
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            catch (Exception)
            {
                lblError.Text = "Error. Recargue la página";
                lblError.Visible = true;
            }
        }
    }
}