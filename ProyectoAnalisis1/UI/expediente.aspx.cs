using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI {
    public partial class expediente : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                revisarLogin();
                BLEmpleado emp = (BLEmpleado)(Session["empleado"]);
                if ((emp.rol.Equals("Secretaria"))) {
                    btnHistorialClinico.Visible = false;
                }

                if (!IsPostBack) {
                    if (!String.IsNullOrEmpty(Convert.ToString(Session["cedula"])) || (!String.IsNullOrWhiteSpace(Convert.ToString(Session["cedula"])))) {
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
                        tel2.Text = exp.tel2;
                        tel3.Text = exp.tel3;
                        descripcionTel2.Text = exp.descripcion_tel2;
                        descripcionTel3.Text = exp.descripcion_tel3;
                        txtEdad.Text = Convert.ToString(calcularEdad(exp.fecha_nacimiento));

                        BLManejadorDireccion dir = new BLManejadorDireccion();
                        BLDireccion bl = dir.consultar(Convert.ToString(Session["cedula"]));
                        provinciaText.Text = bl.provincia;
                        cantonText.Text = bl.canton;
                        distritoText.Text = bl.distrito;
                        otrasText.Text = bl.otrasSenas;

                    }
                }
            } catch (Exception) {
                mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>¡Error al cargar los datos del expediente!</strong> Verifique su conexion a internet y regrese a la página principal<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeError.Visible = true;
            }


            if (String.IsNullOrEmpty(idText.Text.Trim()) || (String.IsNullOrWhiteSpace(idText.Text.Trim()))) {
                ultimaBtn.Visible = false;
                ultimaBtn.Enabled = false;
                historialBtn.Visible = false;
                historialBtn.Enabled = false;
                btnHistorialClinico.Visible = false;
                btnHistorialClinico.Enabled = false;
            }
            desactivarCampos();
        }

        private void revisarLogin() {
            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if (emp == null) {
                Response.Redirect("InicioDeSesion.aspx");
            } else {
                if ((!emp.rol.Equals("Secretaria")) && (!emp.rol.Equals("Doctor")) && (!emp.rol.Equals("Paramedico"))) {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }

        private void desactivarCampos() {
            if (!String.IsNullOrEmpty(Convert.ToString(Session["cedula"])) || (!String.IsNullOrWhiteSpace(Convert.ToString(Session["cedula"])))) {
                if (!String.IsNullOrEmpty(idText.Text) || (!String.IsNullOrWhiteSpace(idText.Text))) {
                    BLEmpleado emp = (BLEmpleado)(Session["empleado"]);
                    idText.Enabled = false;
                    if ((!emp.rol.Equals("Secretaria"))) {
                        btnHistorialClinico.Visible = true;
                    }
                    BLManejadorConsulta man = new BLManejadorConsulta();
                    List<BLConsulta> bl = man.listaConsultas(idText.Text.Trim());
                    if (bl.Count > 0) {
                        ultimaBtn.Visible = true;
                        btnHistorialClinico.Enabled = true;
                        ultimaBtn.Enabled = true;
                        historialBtn.Visible = true;
                        historialBtn.Enabled = true;
                    } else {
                        btnHistorialClinico.Enabled = true;
                        historialBtn.Visible = true;
                        historialBtn.Enabled = true;
                        ultimaBtn.Enabled = false;
                        ultimaBtn.Visible = false;
                    }
                }
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(Convert.ToString(Session["cedula"])) || (String.IsNullOrWhiteSpace(Convert.ToString(Session["cedula"])))) {
                try {
                    BLExpediente exp = createBl();
                    if (DateTime.Compare(exp.fecha_nacimiento, DateTime.Now) == -1) {
                        new BLManejadorExpediente().insertarExpediente(exp);
                        mensajeError.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Los datos han sido guardados correctamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        mensajeError.Visible = true;
                        Session["cedula"] = idText.Text.Trim();
                        desactivarCampos();
                    } else {
                        mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>¡Error!</strong> La fecha de nacimiento esta incorrecta.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        mensajeError.Visible = true;
                    }
                } catch (Exception) {
                    mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>¡Error!</strong>El expediente ya existe en el sistema o los datos son incorrectos.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    mensajeError.Visible = true;
                    idText.Text = "";
                }
            } else {
                try {
                    BLExpediente exp = createBl();
                    if (DateTime.Compare(exp.fecha_nacimiento, DateTime.Now) == -1) {
                        new BLManejadorExpediente().insertarModificar(exp);
                        new BLManejadorDireccion().guardarModificar(new BLDireccion(0, idText.Text.Trim(), provinciaText.Text.Trim(), cantonText.Text.Trim(), distritoText.Text.Trim(), otrasText.Text.Trim()));
                        mensajeError.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Los datos han sido guardados correctamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        mensajeError.Visible = true;
                    } else {
                        mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>¡Error!</strong> La fecha de nacimiento esta incorrecta.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        mensajeError.Visible = true;
                    }
                } catch (System.ArgumentOutOfRangeException) {

                    mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al ingresar la fecha de nacimiento </strong>Verifique que los datos ingresados sean correctos.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    mensajeError.Visible = true;

                } catch (Exception) {
                    mensajeError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>Verifique que los datos ingresados sean correctos.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    mensajeError.Visible = true;

                }
            }

        }

        protected void cantonText_TextChanged(object sender, EventArgs e) {

        }

        protected void historialBtn_Click(object sender, EventArgs e) {
            Session["cedula"] = idText.Text.Trim();
            Response.Redirect("ListaConsultas.aspx");
        }

        protected void modificarBtn_Click(object sender, EventArgs e) {
        }

        private BLExpediente createBl() {
            return new BLExpediente(idText.Text.Trim(),
                firstNameText.Text.Trim(), secondNameText.Text.Trim(), lastNameText.Text.Trim(),
                lastNameText2.Text.Trim(), new DateTime(Convert.ToInt32(AnnoText.Text.Trim()), Convert.ToInt32(mesText.Text.Trim()), Convert.ToInt32(diaText.Text.Trim())), phoneText.Text.Trim(),
                religionText.Text.Trim(), estadoCivilText.Text.Trim(), trabajoText.Text.Trim(),
                sexoText.SelectedValue, tel2.Text.Trim(), tel3.Text.Trim(), descripcionTel3.Text.Trim(), descripcionTel2.Text.Trim());
        }

        protected void ultimaBtn_Click(object sender, EventArgs e) {
            Session["cedula"] = idText.Text.Trim();
            BLManejadorConsulta man = new BLManejadorConsulta();
            Session["idConsulta"] = man.consultarUltimo(Convert.ToString(idText.Text.Trim()));
            Response.Redirect("Consulta.aspx");
        }

        protected void mesTextt_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void btnHistorialClinico_Click(object sender, EventArgs e) {
            Session["cedula"] = idText.Text.Trim();
            Response.Redirect("HistorialClinico.aspx");
        }



        protected void diaText_TextChanged(object sender, EventArgs e) {

        }

        protected int calcularEdad(DateTime fechaNacimiento) {
            return DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }
    }
}