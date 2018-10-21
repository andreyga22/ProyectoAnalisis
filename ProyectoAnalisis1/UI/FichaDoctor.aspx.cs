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
            BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
            BLFichaDoctor doc = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
            motivoText.Text = doc.motivoConsulta;
            examenText.Text = doc.examenFisico;
            planText.Text = doc.plan;
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
            blm.insertar(new BLFichaDoctor(0, 1, motivoText.Text.Trim(), examenText.Text.Trim(), planText.Text.Trim()));
        }
    }
}