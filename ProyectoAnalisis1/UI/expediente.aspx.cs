using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI
{
    public partial class expediente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {

            new BLManejadorExpediente().insertarExpediente(new BLExpediente(idText.Text.Trim(),
                firstNameText.Text.Trim(), secondNameText.Text.Trim(), lastNameText.Text.Trim(), 
                lastNameText2.Text.Trim(), fechaNacimiento.SelectedDate, phoneText.Text.Trim(), 
                religionText.Text.Trim(), estadoCivilText.Text.Trim(), trabajoText.Text.Trim(), 
                sexoText.SelectedValue));

            new BLManejadorDireccion().insertarDireccion(new BLDireccion(0, provinciaText.Text.Trim(), 
                cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim()));
        }

        protected void cantonText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}