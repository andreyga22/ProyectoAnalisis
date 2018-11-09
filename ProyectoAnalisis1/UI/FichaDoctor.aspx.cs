using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class HistorialClinico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
                    BLFichaDoctor doc = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
                    motivoText.Text = doc.motivoConsulta;
                    examenText.Text = doc.examenFisico;
                    planText.Text = doc.plan;
                }
            }
            catch (Exception)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al cargar los datos de la ficha doctor. Por favor vuelva a la pagina principal.";
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
                blm.insertar(new BLFichaDoctor(0, Convert.ToInt32(Session["idConsulta"]), "IDEmpleado", motivoText.Text.Trim(), examenText.Text.Trim(), planText.Text.Trim()));
            }
            catch (Exception)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al guardar los datos de la ficha doctor. Verifique que los datos sean correctos.";
            }
        }
    }
}