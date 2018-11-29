using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                revisarLogin();
                Session["cedula"] = "";
                Session["idConsulta"] = "";
                lblNoBusqCedula.Visible = false;
                lblNoBusqNombre.Visible = false;
                if (!IsPostBack) {
                    cargarDia();
                }

                cargarDia();
            } catch (Exception) {
                mensajeDia.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeDia.Visible = true;
            }
        }

        private void cargarDia() {
            try {
                BLManejadorExpediente ble = new BLManejadorExpediente();
                List<BLExpediente> lista = ble.consultarListaDia();
                if (lista.Count > 0)
                {
                tablaDia.DataSource = lista;
                    tablaDia.DataBind();
                invisible();
                crearTabla2();
                }
                else
                {
                    mensajeDia.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\">No existen consultas pendientes.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    mensajeDia.Visible = true;
                }

            } catch (Exception) {
                mensajeDia.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeDia.Visible = true;
            }
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

        protected void btnNuevoExp_Click(object sender, EventArgs e) {
            Response.Redirect("expediente.aspx");
        }

        protected void buscarCedula_Click(object sender, EventArgs e) {
            try
            {
                if (!String.IsNullOrEmpty(txtbusqCedula.Text.Trim()) || (!String.IsNullOrWhiteSpace(txtbusqCedula.Text.Trim()))) {
                BLManejadorExpediente manejador = new BLManejadorExpediente();
                List<BLExpediente> expediente = manejador.consultarListaCedula(txtbusqCedula.Text.Trim());
                if (expediente.Count > 0) {
                    tblBuscar.Visible = true;
                    tblBuscar.DataSource = expediente;
                    tblBuscar.DataBind();
                    crearTabla();
                    invisible2();
                } else {
                    lblNoBusqCedula.Visible = true;
                    tblBuscar.Visible = false;
                }
            }
            }
            catch (Exception)
            {
                mensajeBuscar.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeBuscar.Visible = true;
                //lblError.Visible = true;
                //lblError.Text = "Error al cargar la información. Verifique su conexión a internet";
            }
        }

        protected void listaBusq_SelectedIndexChanged(object sender, EventArgs e) {
            string id = tblBuscar.SelectedRow.Cells[2].Text.Trim();
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }

        protected void buscarNombre_Click(object sender, EventArgs e) {
            try {
                if (!String.IsNullOrEmpty(txtbusqNombre.Text.Trim()) || (!String.IsNullOrWhiteSpace(txtbusqNombre.Text.Trim()))) {
                    BLManejadorExpediente manejador = new BLManejadorExpediente();
                    List<BLExpediente> listaExpediente = manejador.consultarListaExpedNombre(txtbusqNombre.Text);
                    if (listaExpediente.Count > 0) {
                        tblBuscar.Visible = true;
                        tblBuscar.DataSource = listaExpediente;
                        tblBuscar.DataBind();
                        crearTabla();
                        invisible2();
                    } else {
                        lblNoBusqNombre.Visible = true;
                        tblBuscar.Visible = false;
                    }
                }
            } catch (Exception) {
                mensajeBuscar.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeBuscar.Visible = true;
            }
        }

        private void crearTabla() {
            tblBuscar.HeaderRow.Cells[2].Text = "Cédula";
            tblBuscar.HeaderRow.Cells[3].Text = "Primer Nombre";
            tblBuscar.HeaderRow.Cells[4].Text = "Segundo Nombre";
            tblBuscar.HeaderRow.Cells[5].Text = "Primer Apellido";
            tblBuscar.HeaderRow.Cells[6].Text = "Segundo Apellido";
            tblBuscar.HeaderRow.Cells[8].Text = "Teléfono";
        }

        private void crearTabla2() {
            for (int i = 0; i < tablaDia.Rows.Count; i++) {
                tablaDia.Rows[i].Cells[2].Text = Convert.ToString(i + 1);
            }
            tablaDia.HeaderRow.Cells[2].Text = "Número";
            tablaDia.HeaderRow.Cells[3].Text = "Cédula";
            tablaDia.HeaderRow.Cells[4].Text = "Primer Nombre";
            tablaDia.HeaderRow.Cells[5].Text = "Segundo Nombre";
            tablaDia.HeaderRow.Cells[6].Text = "Primer Apellido";
            tablaDia.HeaderRow.Cells[7].Text = "Segundo Apellido";
            tablaDia.HeaderRow.Cells[9].Text = "Teléfono";
            tablaDia.HeaderRow.Cells[18].Text = "Alergias";
        }

        private void invisible() {
            for (int i = 8; i < 18; i++) {
                if (i != 9) {
                    tablaDia.HeaderRow.Cells[i].Visible = false;
                    for (int x = 0; x < tablaDia.Rows.Count; x++) {
                        tablaDia.Rows[x].Cells[i].Visible = false;
                    }
                }
            }
        }

        public void invisible2() {
            for (int i = 7; i < 18; i++) {
                if (i != 8) {
                    tblBuscar.HeaderRow.Cells[i].Visible = false;
                    for (int x = 0; x < tblBuscar.Rows.Count; x++) {
                        tblBuscar.Rows[x].Cells[i].Visible = false;
                    }
                }

            }
        }

        protected void tablaDia_SelectedIndexChanged(object sender, EventArgs e) {
            string id = tablaDia.SelectedRow.Cells[3].Text.Trim();
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }

        protected void tablaDia_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            try {
                BLManejadorExpediente ble = new BLManejadorExpediente();
                int selected = e.RowIndex;
                tablaDia.SelectedIndex = selected;
                ble.borrarDia(tablaDia.SelectedRow.Cells[3].Text.Trim());
                mensajeDia.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>El expediente se eliminó de la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeDia.Visible = true;
                cargarDia();
            } catch (Exception) {
                mensajeDia.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>No se pudo eliminar el expediente de la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeDia.Visible = true;
            }
        }

        protected void btnExpedientes_Click(object sender, EventArgs e) {
            Response.Redirect("ListaExpedientes.aspx");
        }

        protected void tblBuscar_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            try {
                BLManejadorExpediente blm = new BLManejadorExpediente();
                int selected = e.RowIndex;
                tblBuscar.SelectedIndex = selected;
                blm.insertarDia(tblBuscar.SelectedRow.Cells[2].Text.Trim());
                mensajeBuscar.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>El expediente se agregó a la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeBuscar.Visible = true;
                cargarDia();
            } catch (Exception) {
                mensajeBuscar.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>No se pudo agregar el expediente a la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                mensajeBuscar.Visible = true;
            }
        }
    }
}