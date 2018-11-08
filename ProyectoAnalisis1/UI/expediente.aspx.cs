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
            if (!IsPostBack)
            {
                BLManejadorExpediente man = new BLManejadorExpediente();
                BLExpediente exp = man.consultarExpediente("504060873");
                idText.Text = exp.cedula;
                firstNameText.Text = exp.primer_nombre;
                secondNameText.Text = exp.segundo_nombre;
                lastNameText.Text = exp.primer_apellido;
                lastNameText2.Text = exp.segundo_apellido;

                diaText.Text = Convert.ToString(exp.fecha_nacimiento.Day);
                mesText.Text = Convert.ToString(exp.fecha_nacimiento.Month);
                AnnoText.Text = Convert.ToString(exp.fecha_nacimiento.Year);
                phoneText.Text = exp.num_telefono;
                religionText.Text = exp.religion;
                estadoCivilText.Text = exp.estado_civil;
                trabajoText.Text = exp.tipo_trabajo;
                sexoText.Text = exp.sexo;
                BLManejadorDireccion dir = new BLManejadorDireccion();
                BLDireccion bl = dir.consultar("504060873");
                provinciaText.Text = bl.provincia;
                cantonText.Text = bl.canton;
                distritoText.Text = bl.distrito;
                otrasText.Text = bl.otrasSenas;
            }
            //if (!IsPostBack) {
            desactivarCampos();
            if (String.IsNullOrEmpty(idText.Text) || (String.IsNullOrWhiteSpace(idText.Text)))
            {
                modificarBtn.Visible = false;
                modificarBtn.Enabled = false;
                ultimaBtn.Visible = false;
                ultimaBtn.Enabled = false;
                historialBtn.Visible = false;
                historialBtn.Enabled = false;
                btnHistorialClinico.Visible = false;
                btnHistorialClinico.Enabled = false;
            }
                //}
            }


        private void desactivarCampos()
        {
            if (!String.IsNullOrEmpty(idText.Text) || (!String.IsNullOrWhiteSpace(idText.Text)))
            {

                idText.Enabled = false;
                firstNameText.Enabled = false;
                secondNameText.Enabled = false;
                lastNameText.Enabled = false;
                lastNameText2.Enabled = false;
                diaText.Enabled = false;
                mesText.Enabled = false;
                AnnoText.Enabled = false;
                phoneText.Enabled = false;
                religionText.Enabled = false;
                estadoCivilText.Enabled = false;
                trabajoText.Enabled = false;
                sexoText.Enabled = false;
                provinciaText.Enabled = false;
                cantonText.Enabled = false;
                distritoText.Enabled = false;
                otrasText.Enabled = false;
                guardarBtn.Enabled = false;
                guardarBtn.Visible = false;
                modificarBtn.Visible = true;
                modificarBtn.Enabled = true;
            }
        }

        private void activarCampos()
        {
            firstNameText.Enabled = true;
            secondNameText.Enabled = true;
            lastNameText.Enabled = true;
            lastNameText2.Enabled = true;
            diaText.Enabled = true;
            mesText.Enabled = true;
            AnnoText.Enabled = true;
            phoneText.Enabled = true;
            religionText.Enabled = true;
            estadoCivilText.Enabled = true;
            trabajoText.Enabled = true;
            sexoText.Enabled = true;
            provinciaText.Enabled = true;
            cantonText.Enabled = true;
            distritoText.Enabled = true;
            otrasText.Enabled = true;
            guardarBtn.Visible = true;
            guardarBtn.Enabled = true;
            modificarBtn.Enabled = false;
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            
            new BLManejadorExpediente().insertarModificar(createBl());
            new BLManejadorDireccion().guardarModificar(new BLDireccion(0, idText.Text.Trim(), provinciaText.Text.Trim(), cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim()));
            //if (!new BLManejadorDireccion().insertar(new BLDireccion(0, idText.Text.Trim(), provinciaText.Text.Trim(),
            //    cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim())))
            //{
            //    Response.Write("<script>alert('ERROR! Dirección no ha sido almacenada exitosamente')</script>");
            //}

        }

        protected void cantonText_TextChanged(object sender, EventArgs e)
        {

        }

        protected void historialBtn_Click(object sender, EventArgs e)
        {
            Session["cedula"] = idText.Text.Trim();
            Response.Redirect("ListaConsultas.aspx");
        }

        protected void modificarBtn_Click(object sender, EventArgs e)
        {
            //if (Convert.ToBoolean(ViewState["listoParaGuardar"]) == true)
            //{
            //    new BLManejadorExpediente().actualizarExpediente(createBl());
            //    ViewState["listoParaGuardar"] = false;
            //}
            //else
            //{
                activarCampos();
            //    ViewState["listoParaGuardar"] = true;
            //    modificarBtn.Text = "Guardar";
            //}
        }

        private BLExpediente createBl()
        {
            return new BLExpediente(idText.Text.Trim(),
                firstNameText.Text.Trim(), secondNameText.Text.Trim(), lastNameText.Text.Trim(),
                lastNameText2.Text.Trim(), new DateTime(Convert.ToInt32(AnnoText.Text.Trim()), Convert.ToInt32(mesText.Text.Trim()), Convert.ToInt32(diaText.Text.Trim())), phoneText.Text.Trim(),
                religionText.Text.Trim(), estadoCivilText.Text.Trim(), trabajoText.Text.Trim(),
                sexoText.SelectedValue);
        }

        protected void ultimaBtn_Click(object sender, EventArgs e)
        {
            Session["cedula"] = idText.Text.Trim();
            BLManejadorConsulta man = new BLManejadorConsulta();
            Session["idConsulta"] = man.consultarUltimo(Convert.ToString(idText.Text.Trim()));
            Response.Redirect("Consulta.aspx");
        }

        protected void mesTextt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            Session["cedula"] = idText.Text.Trim();
            Response.Redirect("HistorialClinico.aspx");
        }
    }
}