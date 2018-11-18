using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class FichaParamedico : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            revisarLogin();

            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if ((!emp.rol.Equals("Doctor"))) {
                observacionesText.Enabled = false;
            }


            try {
                if (!IsPostBack) {
                    Response.Write(Session["idConsulta"]);
                    BLManejadorFichaParamedico blm = new BLManejadorFichaParamedico();
                    BLFichaParamedico param = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
                    NotasParamText.Text = param.nota_param;
                    presionText.Text = param.presionArterial;
                    temperaturaText.Text = Convert.ToString(param.temperatura);
                    estaturaText.Text = Convert.ToString(param.estatura);
                    pesoText.Text = Convert.ToString(param.peso);
                    glicemiaText.Text = param.glicemia;
                    oximetriaText.Text = param.oximetria_Pulso;
                    observacionesText.Text = param.observacion;
                    GlasgowText.Text = Convert.ToString(param.glasgow);
                    Frec_CardText.Text = Convert.ToString(param.frec_card);
                    Frec_RespText.Text = Convert.ToString(param.frec_resp);
                    PupilasText.Text = param.pupilas;
                    PielText.Text = param.piel;
                    NotasParamText.Text = param.nota_param;
                }
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al cargar los datos de la ficha paramédico. Por favor vuelva a la pagina principal.";
            }
        }

        private void revisarLogin() {
            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if (emp == null) {
                Response.Redirect("InicioDeSesion.aspx");
            } else {
                if ((!emp.rol.Equals("Doctor")) && (!emp.rol.Equals("Paramedico"))) {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e) {
            try {
                BLManejadorFichaParamedico blm = new BLManejadorFichaParamedico();

                String a = presionText.Text;
                blm.insertar(new BLFichaParamedico(0, Convert.ToInt32(Session["idConsulta"]), "IDEmpleado", presionText.Text.Trim(),
                    Convert.ToInt32(temperaturaText.Text.Trim()), Convert.ToInt32(estaturaText.Text.Trim()),
                    Convert.ToInt32(pesoText.Text.Trim()), glicemiaText.Text.Trim(), oximetriaText.Text.Trim(),
                    observacionesText.Text.Trim(), Convert.ToInt32(GlasgowText.Text.Trim()),
                    Convert.ToInt32(Frec_CardText.Text.Trim()), Convert.ToInt32(Frec_RespText.Text.Trim()),
                    PupilasText.Text.Trim(), PielText.Text.Trim(), NotasParamText.Text.Trim()));
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al guardar los datos de la ficha paramédico. Verifique que los datos sean correctos.";
            }
        }

    }
}