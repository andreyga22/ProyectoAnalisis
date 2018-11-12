using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class HistorialClinico1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    if (!Convert.ToString(Session["cedula"]).Equals(""))
                    {
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
                        furCalend.SelectedDate = histClinica.FUR;
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
            }
            catch (Exception)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al cargar los datos del historial clínico. Regrese a la página principal";
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new BLManejadorHistoriaClinica().insertarActualizarHistorialClinico(createBl());
                Response.Write("<script>alert('Cambio Realizado')</script>");
            }
            catch (Exception)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al guardar los datos del historial clínico. Verifique su conexión y que los datos sean correctos.";
            }
        }

        private BLHistoriaClinica createBl()
        {
            if (furCalend.SelectedDate.Year == 0001 && furCalend.SelectedDate.Month == 1 && furCalend.SelectedDate.Year == 1)
            {
                furCalend.SelectedDate = new DateTime(1800, 01, 01);
            }
            return new BLHistoriaClinica(0, Convert.ToString(Session["cedula"]), txtGrupoSanguineo.Text.Trim(), htaCheck.Checked, dMCheck.Checked, asmaCheck.Checked,
            epilepsiaCheck.Checked, txtenfCardiacas.Text.Trim(), displidemiaCheck.Checked, txtpsiquiatricas.Text.Trim(),
            txtOtraspatolog.Text.Trim(), fumaCheck.Checked, licorCheck.Checked, drogasCheck.Checked, Textalergias.Text.Trim(),
            TextotrasNoPatologicas.Text.Trim(), menarcaCheck.Checked, furCalend.SelectedDate, Convert.ToInt32(embarazosText.Text.Trim()),
            Convert.ToInt32(abortosText.Text.Trim()), Convert.ToInt32(quistesOvaricosText.Text.Trim()), endometriosisCheck.Checked, otrosGinecobstetricoText.Text.Trim(),
            medicamentosText.Text.Trim(), otrosMedicamentosText.Text.Trim(), fracturasText.Text.Trim(), vesiculaText.Text.Trim(),
            apendiceCheck.Checked, cordalesCheck.Checked, litiasisText.Text.Trim(), columnaText.Text.Trim(), otrosQuirugicosText.Text.Trim(),
            dMFamText.Text.Trim(), HTAFamText.Text.Trim(), asmaFamText.Text.Trim(), cancerFamText.Text.Trim(), epilepsiaFamText.Text.Trim(),
            demenciasFamText.Text.Trim(), psicofamiliaresText.Text.Trim(), psicofamiliaresText.Text.Trim());
        }
    }
}