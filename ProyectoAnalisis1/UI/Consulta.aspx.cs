using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class Consulta : System.Web.UI.Page {
        private DateTime fecha1 = DateTime.Now;
        protected void Page_Load(object sender, EventArgs e) {
            revisarLogin();

            BLEmpleado emp = (BLEmpleado)(Session["empleado"]);
            if ((emp.rol.Equals("Secretaria")) || (emp.rol.Equals("Paramedico"))) {
                entrarDoctor.Visible = false;
            }
            if ((emp.rol.Equals("Secretaria"))) {
                entrarParamedico.Visible = false;
                guardarBtn.Visible = false;
                precioText.Enabled = false;
            }

            if ((emp.rol.Equals("Paramedico"))) {
                guardarBtn.Visible = false;
                precioText.Enabled = false;
            }
            if (!IsPostBack) {
                try {
                    BLManejadorConsulta blm = new BLManejadorConsulta();
                    BLConsulta con = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
                    fecha.Text = Convert.ToString((con.fecha).Day) + "/" + Convert.ToString((con.fecha).Month) + "/" + Convert.ToString((con.fecha).Year) + " " + Convert.ToString((con.fecha).Hour) + ":" + Convert.ToString((con.fecha).Minute);
                    //fecha.Text = Convert.ToString(con.fecha);
                    precioText.Text = Convert.ToString(con.precio_Consulta);
                } catch (Exception) {
                    //errorLbl.Visible = true;
                    //errorLbl.Text = "Error al cargar los datos de la consulta. Regrese a la página principal";
                    lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar los datos de la consulta. </strong> Regrese a la página principal.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    lblError.Visible = true;
                }
            }
        }

        private void revisarLogin() {
            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if (emp == null) {
                Response.Redirect("InicioDeSesion.aspx");
            } else {
                if ( (!emp.rol.Equals("Secretaria")) && (!emp.rol.Equals("Doctor")) && (!emp.rol.Equals("Paramedico"))) {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }


        protected void guardarBtn_Click(object sender, EventArgs e) {
            try {
                BLManejadorConsulta blm = new BLManejadorConsulta();
                string precio = precioText.Text.Trim();
                blm.modificar(Convert.ToInt32(Session["idConsulta"]), Convert.ToInt32(precioText.Text.Trim()));
                lblError.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Información de la consulta guardada exitosamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al guardar los datos de la consulta. </strong>Verifique que los datos sean correctos..<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //errorLbl.Visible = true;
                //errorLbl.Text = "Error al guardar los datos de la consulta. Verifique que los datos sean correctos.";
            }
        }

        protected void entrarDoctor_Click(object sender, EventArgs e) {
            Response.Redirect("FichaDoctor.aspx");
        }

        protected void entrarParamedico_Click(object sender, EventArgs e) {
            Response.Redirect("FichaParamedico.aspx");
        }
    }
}