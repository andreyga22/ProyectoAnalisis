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
                        List<BLFoto> fotos = blf.consultar(Convert.ToInt32(Session["idConsulta"]));
                        image.ImageUrl = fotos[0].url;
                        image2.ImageUrl = fotos[0].url;
                        image3.ImageUrl = fotos[1].url;
                        image4.ImageUrl = fotos[1].url;
                        image.Visible = true;
                        image3.Visible = true;
                        lblEmpleado.Text = "Doctor Encargado: " + new BLManejadorEmpleado().obtenerEmpleado(doc.idEmpleado).nombreEmpleado;
                    }
                }
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar los datos de la ficha doctor. </strong>Por favor vuelva a la página principal.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //errorLbl.Visible = true;
                //errorLbl.Text = "Error al cargar los datos de la ficha doctor. Por favor vuelva a la pagina principal.";
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
                        blf.borrarFoto(new BLFoto(image.ImageUrl, Convert.ToInt32(Session["idConsulta"])));
                    blf.insertar(new BLFoto("~/fotos/" + nombre, Convert.ToInt32(Session["idConsulta"])));
                } else {
                        lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error. </strong>No se pudo guardar la información en el servidor.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        lblError.Visible = true;
                        //errorLbl.Text = "No se pudo guardar la foto en el servidor";
                    }
            }

                if (foto2.HasFile) {
                    BLManejadorFoto blf = new BLManejadorFoto();
                    String nombre = guardarFoto2();
                    if (!nombre.Equals("")) {
                        blf.borrarFoto(new BLFoto(image3.ImageUrl, Convert.ToInt32(Session["idConsulta"])));
                        blf.insertar(new BLFoto("~/fotos/" + nombre, Convert.ToInt32(Session["idConsulta"])));
                    } else {
                        errorLbl.Text = "No se pudo guardar la foto en el servidor";
                    }
                }

                Response.Redirect("Consulta.aspx");
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al guardar los datos de la ficha doctor. </strong>Verifique que los datos sean correctos.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //errorLbl.Visible = true;
                //errorLbl.Text = "Error al guardar los datos de la ficha doctor. Verifique que los datos sean correctos.";
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
                        //errorLbl.Text = "No se pudo guardar la foto en el servidor. (Las extensiones permitidas son: jpeg, jpg, png)";
                        //errorLbl.Visible = true;
                        lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error. </strong>No se pudo guardar la foto en el servidor (Las extensiones permitidas son: jpeg, jpg, png).<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                        lblError.Visible = true;
                    }
                } else {
                    //errorLbl.Text = "No se acepta esta extensión de archivo. (Las extensiones permitidas son: jpeg, jpg, png)";
                    //errorLbl.Visible = true;
                    lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error. </strong>No se acepta esta extensión de archivo. (Las extensiones permitidas son: jpeg, jpg, png)<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    lblError.Visible = true;
                }
            }
            return "";
        }


        private String guardarFoto2() {
            if (IsPostBack) {
                string fileExtension = "";
                Boolean fileOK = false;
                String path = Server.MapPath("~/fotos/");
                if (foto2.HasFile) {
                    fileExtension =
                        System.IO.Path.GetExtension(foto2.FileName).ToLower();
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
                        foto2.PostedFile.SaveAs(path
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