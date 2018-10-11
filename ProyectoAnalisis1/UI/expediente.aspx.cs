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
            BLManejadorExpediente man = new BLManejadorExpediente();
            BLExpediente exp = man.consultarExpediente("101230546");
            idText.Text = exp.cedula;
            firstNameText.Text = exp.primer_nombre;
            secondNameText.Text = exp.segundo_nombre;
            lastNameText.Text = exp.primer_apellido;
            lastNameText2.Text = exp.segundo_apellido;
            fechaNacimiento.SelectedDate = exp.fecha_nacimiento;
            phoneText.Text = exp.num_telefono;
            religionText.Text = exp.religion;
            estadoCivilText.Text = exp.estado_civil;
            trabajoText.Text = exp.tipo_trabajo;
            sexoText.Text = exp.sexo;
            BLManejadorDireccion dir = new BLManejadorDireccion();
            BLDireccion bl = dir.consultar("101230546");
            provinciaText.Text = bl.provincia;
            cantonText.Text = bl.canton;
            distritoText.Text = bl.distrito;
            otrasText.Text = bl.otrasSenas;

        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {

            new BLManejadorExpediente().insertarExpediente(new BLExpediente(idText.Text.Trim(),
                firstNameText.Text.Trim(), secondNameText.Text.Trim(), lastNameText.Text.Trim(), 
                lastNameText2.Text.Trim(), fechaNacimiento.SelectedDate, phoneText.Text.Trim(), 
                religionText.Text.Trim(), estadoCivilText.Text.Trim(), trabajoText.Text.Trim(), 
                sexoText.SelectedValue));

            new BLManejadorDireccion().insertar(new BLDireccion(0, idText.Text.Trim(),provinciaText.Text.Trim(), 
                cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim()));
        }

        protected void cantonText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}