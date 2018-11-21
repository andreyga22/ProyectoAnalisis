using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class HistorialClinico : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            revisarLogin();

            try {
                //BLManejadorEmpleado blEmplea = new BLManejadorEmpleado();

                if (!IsPostBack) {
                    BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
                    BLFichaDoctor doc = blm.consultar(Convert.ToInt32(Session["idConsulta"]));
                    if (doc.idDoctor == 0) {
                        lblEmpleado.Visible = false;
                    } else {
                        motivoText.Text = doc.motivoConsulta;
                        examenText.Text = doc.examenFisico;
                        planText.Text = doc.plan;
                        BLManejadorFoto blf = new BLManejadorFoto();
                        BLFoto foto = blf.consultar(Convert.ToInt32(Session["idConsulta"]));
                        image.ImageUrl = foto.url;
                        image.Visible = true;
                        lblEmpleado.Text = "Doctor Encargado: " + new BLManejadorEmpleado().obtenerEmpleado(doc.idEmpleado).nombreEmpleado;
                    }
                }
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al cargar los datos de la ficha doctor. Por favor vuelva a la pagina principal.";
            }
        }

        private void revisarLogin() {
            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if (emp == null) {
                Response.Redirect("InicioDeSesion.aspx");
            } else {
                if ((!emp.rol.Equals("Doctor"))) {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e) {
            try {
                BLManejadorFichaDoctor blm = new BLManejadorFichaDoctor();
            blm.insertar(new BLFichaDoctor(Convert.ToInt32(Session["idConsulta"]), Convert.ToInt32(Session["idConsulta"]), ((BLEmpleado)Session["empleado"]).id, Convert.ToString(motivoText.Text.Trim()), Convert.ToString(examenText.Text.Trim()), Convert.ToString(planText.Text.Trim())));


            if (foto.HasFile) {
                BLManejadorFoto blf = new BLManejadorFoto();
                String nombre = guardarFoto();
                if (!nombre.Equals("")) {
                    blf.insertar(new BLFoto("~/fotos/" + nombre, Convert.ToInt32(Session["idConsulta"])));
                } else {
                    errorLbl.Text = "No se pudo guardar la foto en el servidor";
                }
            }

                Response.Redirect("Consulta.aspx");
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al guardar los datos de la ficha doctor. Verifique que los datos sean correctos.";
            }
        }


        private String guardarFoto() {
            if (IsPostBack) {
                string fileExtension = "";
                Boolean fileOK = false;
                String path = Server.MapPath("~/fotos/");
                if (foto.HasFile) {
                    fileExtension =
                        System.IO.Path.GetExtension(foto.FileName).ToLower();
                    String[] allowedExtensions =
                        {".png", ".jpeg", ".jpg"};
                    for (int i = 0; i < allowedExtensions.Length; i++) {
                        if (fileExtension == allowedExtensions[i]) {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK) {
                    try {
                        Guid newGuid = Guid.NewGuid();
                        string imageName = newGuid.ToString();

                        //foto. = imageName;
                        foto.PostedFile.SaveAs(path
                            + imageName + fileExtension);
                        //Label1.Text = "File uploaded!";
                        return imageName + fileExtension;
                    } catch (Exception) {
                        errorLbl.Text = "No se pudo guardar la foto en el servidor. (Las extensiones permitidas son: jpeg, jpg, png)";
                        errorLbl.Visible = true;
                    }
                } else {
                    errorLbl.Text = "No se acepta esta extensión de archivo. (Las extensiones permitidas son: jpeg, jpg, png)";
                    errorLbl.Visible = true;
                }
            }
            return "";
        }
    }
}