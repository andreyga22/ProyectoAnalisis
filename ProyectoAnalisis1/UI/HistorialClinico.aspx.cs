using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class HistorialClinico1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorLbl.Visible = true;
            errorLbl.Text = "Error al cargar los datos del historial clinico. Regrese a la pagina principal.";
            errorLbl.Text = "Error al guardar los datos del historial clinico. Verifique que los datos sean correctos.";
        }
    }
}