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
            try
            {
                //Session["nombreEmpleado"] = "";
                //Session["rolEmpleado"] = "";
                if ((Convert.ToString(Session["rolEmpleado"]).Equals("Secretaria")))
                {
                    btnHistorialClinico.Visible = false;
                }
                if (!IsPostBack)
                {
                    if (!Convert.ToString(Session["cedula"]).Equals(""))
                    {
                        BLManejadorExpediente man = new BLManejadorExpediente();
                        BLExpediente exp = man.consultarExpediente(Convert.ToString(Session["cedula"]));
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
                        txtEdad.Text = Convert.ToString(calcularEdad(exp.fecha_nacimiento));

                        //idLabel.Text = exp.cedula;
                        //firstNameLabel.Text = exp.primer_nombre;
                        //secondNameLabel.Text = exp.segundo_nombre;
                        //lastNameLabel.Text = exp.primer_apellido;
                        //lastNameLabel2.Text = exp.segundo_apellido;
                        //diaLabel.Text = Convert.ToString(exp.fecha_nacimiento.Day);
                        //mesLabel.Text = Convert.ToString(exp.fecha_nacimiento.Month);
                        //AnnoLabel.Text = Convert.ToString(exp.fecha_nacimiento.Year);
                        //phoneLabel.Text = exp.num_telefono;
                        //religionLabel.Text = exp.religion;
                        //estadoCivilLabel.Text = exp.estado_civil;
                        //trabajoLabel.Text = exp.tipo_trabajo;
                        //sexoLabel.Text = exp.sexo;

                        BLManejadorDireccion dir = new BLManejadorDireccion();
                        BLDireccion bl = dir.consultar(Convert.ToString(Session["cedula"]));
                        provinciaText.Text = bl.provincia;
                        cantonText.Text = bl.canton;
                        distritoText.Text = bl.distrito;
                        otrasText.Text = bl.otrasSenas;

                        //provinciaLabel.Text = bl.provincia;
                        //cantonLabel.Text = bl.canton;
                        //distritoLabel.Text = bl.distrito;
                        //otrasLabel.Text = bl.otrasSenas;
                    }
                }
                //if (!IsPostBack) {
                desactivarCampos();
                if (String.IsNullOrEmpty(idText.Text) || (String.IsNullOrWhiteSpace(idText.Text)))
                {
                    //modificarBtn.Visible = false;
                    //modificarBtn.Enabled = false;
                    ultimaBtn.Visible = false;
                    ultimaBtn.Enabled = false;
                    historialBtn.Visible = false;
                    historialBtn.Enabled = false;
                    btnHistorialClinico.Visible = false;
                    btnHistorialClinico.Enabled = false;
                }
                //}
            } catch (Exception) {
                errorlbl.Visible = true;
                errorlbl.Text = "Error al cargar los datos del expediente. Verifique su conexion a internet y regrese a la página principal";
            }
            }


        private void desactivarCampos()
        {
            if (!String.IsNullOrEmpty(idText.Text) || (!String.IsNullOrWhiteSpace(idText.Text)))
            {

                idText.Enabled = false;
                if((!Convert.ToString(Session["rolEmpleado"]).Equals("Secretaria"))) {
                    btnHistorialClinico.Visible = true;
                }
                BLManejadorConsulta man = new BLManejadorConsulta();
                List<BLConsulta> bl =  man.listaConsultas(idText.Text.Trim());
                if (bl.Count > 0)
                {
                    ultimaBtn.Visible = true;
                    btnHistorialClinico.Enabled = true;
                    ultimaBtn.Enabled = true;
                    historialBtn.Visible = true;
                    historialBtn.Enabled = true;
                }
                else {
                    btnHistorialClinico.Enabled = true;
                    historialBtn.Visible = true;
                    historialBtn.Enabled = true;
                }
                
                //firstNameText.Visible = false;
                //secondNameText.Visible = false;
                //lastNameText.Visible = false;
                //lastNameText2.Visible = false;
                //diaText.Visible = false;
                //mesText.Visible = false;
                //AnnoText.Visible = false;
                //phoneText.Visible = false;
                //religionText.Visible = false;
                //estadoCivilText.Visible = false;
                //trabajoText.Visible = false;
                //sexoText.Visible = false;
                //provinciaText.Visible = false;
                //cantonText.Visible = false;
                //distritoText.Visible = false;
                //otrasText.Visible = false;
                //guardarBtn.Visible = false;
                //guardarBtn.Visible = false;
                //modificarBtn.Visible = true;
                //modificarBtn.Visible = true;

                //idLabel.Visible = true;
                //firstNameLabel.Visible = true;
                //secondNameLabel.Visible = true;
                //lastNameLabel.Visible = true;
                //lastNameLabel2.Visible = true;
                //diaLabel.Visible = true;
                //mesLabel.Visible = true;
                //AnnoLabel.Visible = true;
                //phoneLabel.Visible = true;
                //religionLabel.Visible = true;
                //estadoCivilLabel.Visible = true;
                //trabajoLabel.Visible = true;
                //sexoLabel.Visible = true;
                //provinciaLabel.Visible = true;
                //cantonLabel.Visible = true;
                //distritoLabel.Visible = true;
                //otrasLabel.Visible = true;
            }
        }

        private void activarCampos()
        {
            idText.Visible = true;
            idText.Enabled = false;
            firstNameText.Visible = true;
            secondNameText.Visible = true;
            lastNameText.Visible = true;
            lastNameText2.Visible = true;
            diaText.Visible = true;
            mesText.Visible = true;
            AnnoText.Visible = true;
            phoneText.Visible = true;
            religionText.Visible = true;
            estadoCivilText.Visible = true;
            trabajoText.Visible = true;
            sexoText.Visible = true;
            provinciaText.Visible = true;
            cantonText.Visible = true;
            distritoText.Visible = true;
            otrasText.Visible = true;
            txtEdad.Visible = true;
            guardarBtn.Visible = true;
            guardarBtn.Visible = true;
            //modificarBtn.Visible = false;

            //idLabel.Visible = false;
            //firstNameLabel.Visible = false;
            //secondNameLabel.Visible = false;
            //lastNameLabel.Visible = false;
            //lastNameLabel2.Visible = false;
            //diaLabel.Visible = false;
            //mesLabel.Visible = false;
            //AnnoLabel.Visible = false;
            //phoneLabel.Visible = false;
            //religionLabel.Visible = false;
            //estadoCivilLabel.Visible = false;
            //trabajoLabel.Visible = false;
            //sexoLabel.Visible = false;
            //provinciaLabel.Visible = false;
            //cantonLabel.Visible = false;
            //distritoLabel.Visible = false;
            //otrasLabel.Visible = false;
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new BLManejadorExpediente().insertarModificar(createBl());
                new BLManejadorDireccion().guardarModificar(new BLDireccion(0, idText.Text.Trim(), provinciaText.Text.Trim(), cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim()));
            } catch (System.ArgumentOutOfRangeException) {
                //Response.Write("<script>alert('Error al ingresar los datos del expediente. Revise que los datos ingresados tengan el formato correcto')</script>");
                errorlbl.Visible = true;
                errorlbl.Text = "Error al ingresar la fecha de nacimiento. Verifique que los datos ingresados sean correctos";
            } catch (Exception) {
                errorlbl.Visible = true;
                errorlbl.Text = "Error al ingresar los datos de expediente. Verifique que los datos ingresados sean correctos";
            }
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

        protected void diaText_TextChanged(object sender, EventArgs e)
        {

        }

        protected int calcularEdad(DateTime fechaNacimiento)
        {
            return DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }
    }
}