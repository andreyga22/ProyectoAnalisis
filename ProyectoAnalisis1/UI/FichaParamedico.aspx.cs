using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class FichaParamedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLManejadorFichaParamedico blm = new BLManejadorFichaParamedico();
            BLFichaParamedico param = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
            presionText.Text = param.presionArterial;
            temperaturaText.Text = Convert.ToString( param.temperatura);
            estaturaText.Text = Convert.ToString(param.estatura);
            pesoText.Text = Convert.ToString(param.peso);
            glicemiaText.Text = param.glicemia;
            oximetriaText.Text = param.oximetria_Pulso;
            observacionesText.Text = param.observacion;
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            BLManejadorFichaParamedico blm = new BLManejadorFichaParamedico();
            blm.insertar(new BLFichaParamedico(0, 1, presionText.Text.Trim(), Convert.ToInt32( temperaturaText.Text.Trim()), Convert.ToInt32(estaturaText.Text.Trim()), 
                Convert.ToInt32(pesoText.Text.Trim()), glicemiaText.Text.Trim(), oximetriaText.Text.Trim(), observacionesText.Text.Trim()));
        }
    }
}