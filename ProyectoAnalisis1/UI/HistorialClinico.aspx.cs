using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class HistorialClinico1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            revisarLogin();

            try {
                if (!IsPostBack) {

                    if (!Convert.ToString(Session["cedula"]).Equals("")) {
                        BLManejadorHistoriaClinica manej = new BLManejadorHistoriaClinica();
                        BLHistoriaClinica histClinica = manej.consultarHistorialClinico(Convert.ToString(Session["cedula"]));
                        txtGrupoSanguineo.Text = histClinica.grupo_Sanguineo;
                        htaCheck.Checked = histClinica.HTA;
                        dMCheck.Checked = histClinica.DM;
                        asmaCheck.Checked = histClinica.Asma;
                        epilepsiaCheck.Checked = histClinica.Epilepsia;
                        txtenfCardiacas.Text = histClinica.Enferm_Cardiacas;
                        displidemiaCheck.Checked = histClinica.Displidemias;
                        txtpsiquiatricas.Text = histClinica.Enferm_Psiquiatricas;
                        txtOtraspatolog.Text = histClinica.Otros_Person_Patologic;
                        fumaCheck.Checked = histClinica.Fuma;
                        licorCheck.Checked = histClinica.Licor;
                        drogasCheck.Checked = histClinica.Drogas;
                        Textalergias.Text = histClinica.Alergias;
                        TextotrasNoPatologicas.Text = histClinica.Otros_Person_No_Patologic;
                        menarcaCheck.Checked = histClinica.Menarca;
                        furCalend.Text = histClinica.FUR;
                        embarazosText.Text = Convert.ToString(histClinica.Embarazos);
                        abortosText.Text = Convert.ToString(histClinica.Abortos);
                        quistesOvaricosText.Text = Convert.ToString(histClinica.QuistesOvaricos);
                        endometriosisCheck.Checked = histClinica.Endometriosis;
                        otrosGinecobstetricoText.Text = histClinica.Otros_Ginecobstetrico;
                        medicamentosText.Text = histClinica.Medicamentos;
                        otrosMedicamentosText.Text = histClinica.IndicacionesMedicamentos;
                        fracturasText.Text = histClinica.Fracturas;
                        vesiculaText.Text = histClinica.Vesicula;
                        apendiceCheck.Checked = histClinica.Apendice;
                        cordalesCheck.Checked = histClinica.Cordales;
                        litiasisText.Text = histClinica.Litiasis;
                        columnaText.Text = histClinica.Columna;
                        otrosQuirugicosText.Text = histClinica.Otros_Quirurgico;
                        dMFamText.Text = histClinica.DM_Fam;
                        HTAFamText.Text = histClinica.HTA_Fam;
                        asmaFamText.Text = histClinica.Asma_Fam;
                        cancerFamText.Text = histClinica.Cancer_Fam;
                        epilepsiaFamText.Text = histClinica.Epilepsia_Fam;
                        demenciasFamText.Text = histClinica.Demencias_Fam;
                        psicofamiliaresText.Text = histClinica.Enferm_Psiq_Fam;
                        psicofamiliaresText.Text = histClinica.Otros_Fam;
                    }
                }
            } catch (Exception) {
                lblMensaje.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar los datos del historial clínico </strong>Regrese a la página principal.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
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
                    new BLManejadorHistoriaClinica().insertarActualizarHistorialClinico(createBl());
                    lblMensaje.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Cambio realizado correctamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    lblMensaje.Visible = true;
            } catch (Exception) {
                lblMensaje.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar los datos del historial clínico </strong>Verifique su conexión y que los datos sean correctos.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
            }
        }

        private BLHistoriaClinica createBl() {
            return new BLHistoriaClinica(0, Convert.ToString(Session["cedula"]), txtGrupoSanguineo.Text.Trim(), htaCheck.Checked, dMCheck.Checked, asmaCheck.Checked,
            epilepsiaCheck.Checked, txtenfCardiacas.Text.Trim(), displidemiaCheck.Checked, txtpsiquiatricas.Text.Trim(),
            txtOtraspatolog.Text.Trim(), fumaCheck.Checked, licorCheck.Checked, drogasCheck.Checked, Textalergias.Text.Trim(),
            TextotrasNoPatologicas.Text.Trim(), menarcaCheck.Checked, furCalend.Text.Trim(), Convert.ToInt32(embarazosText.Text.Trim()),
            Convert.ToInt32(abortosText.Text.Trim()), Convert.ToInt32(quistesOvaricosText.Text.Trim()), endometriosisCheck.Checked, otrosGinecobstetricoText.Text.Trim(),
            medicamentosText.Text.Trim(), otrosMedicamentosText.Text.Trim(), fracturasText.Text.Trim(), vesiculaText.Text.Trim(),
            apendiceCheck.Checked, cordalesCheck.Checked, litiasisText.Text.Trim(), columnaText.Text.Trim(), otrosQuirugicosText.Text.Trim(),
            dMFamText.Text.Trim(), HTAFamText.Text.Trim(), asmaFamText.Text.Trim(), cancerFamText.Text.Trim(), epilepsiaFamText.Text.Trim(),
            demenciasFamText.Text.Trim(), psicofamiliaresText.Text.Trim(), psicofamiliaresText.Text.Trim());
        }
    }
}