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
            revisarLogin();
            Response.Write(((BLEmpleado)Session["empleado"]).id);
            Session["cedula"] = "";
            Session["idConsulta"] = "";
            lblNoBusqCedula.Visible = false;
            lblNoBusqNombre.Visible = false;
            //if (!IsPostBack) {
            //    cargarDia();
            //}
            if (!IsPostBack) {
                cargarDia();
            }
        
            cargarDia();
        }

        private void cargarDia() {
            BLManejadorExpediente ble = new BLManejadorExpediente();
            List<BLExpediente> lista = ble.consultarListaDia();
            if (lista.Count > 0) {
                tablaDia.DataSource = lista;
                tablaDia.DataBind();
                invisible();
                crearTabla2();
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
            //try
            //{
            if (!String.IsNullOrEmpty(txtbusqCedula.Text.Trim()) || (!String.IsNullOrWhiteSpace(txtbusqCedula.Text.Trim()))) {
                BLManejadorExpediente manejador = new BLManejadorExpediente();
                BLExpediente expediente = manejador.consultarExpediente(txtbusqCedula.Text);
                if (String.IsNullOrEmpty(expediente.cedula) || (String.IsNullOrWhiteSpace(expediente.cedula))) {
                    lblNoBusqCedula.Visible = true;
                    tblBuscar.Visible = false;
                } else {
                    List<BLExpediente> lista = new List<BLExpediente>();
                    lista.Add(expediente);
                    tblBuscar.DataSource = lista;
                    tblBuscar.DataBind();
                    crearTabla();
                    invisible2();
                    tblBuscar.Visible = true;
                }
            }
            //} catch (Exception)
            //{
            //    lblError.Visible = true;
            //    lblError.Text = "Error al cargar la información. Verifique su conexión a internet";
            //}
        }

        protected void listaBusq_SelectedIndexChanged(object sender, EventArgs e) {
            string id = tblBuscar.SelectedRow.Cells[2].Text.Trim();
            //Response.Write(id);
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
                lblError.Visible = true;
                lblError.Text = "Error al cargar la información. Verifique su conexión a internet";
            }
        }

        private void crearTabla() {
            tblBuscar.HeaderRow.Cells[2].Text = "Cédula";
            tblBuscar.HeaderRow.Cells[3].Text = "Primer Nombre";
            tblBuscar.HeaderRow.Cells[4].Text = "Segundo Nombre";
            tblBuscar.HeaderRow.Cells[5].Text = "Primer Apellido";
            tblBuscar.HeaderRow.Cells[6].Text = "Segundo Apellido";
            //tblBuscar.HeaderRow.Cells[7].Text = "Fecha Nacimiento";
            tblBuscar.HeaderRow.Cells[8].Text = "Teléfono";
            //tblBuscar.HeaderRow.Cells[9].Text = "Religión";
            //tblBuscar.HeaderRow.Cells[10].Text = "Estado Civil";
            //tblBuscar.HeaderRow.Cells[11].Text = "Trabajo";
            //tblBuscar.HeaderRow.Cells[12].Text = "Sexo";
            //tblBuscar.HeaderRow.Cells[17].Text = "Alergias";

            //foreach (GridViewRow row in tblBuscar.Rows) {
            //    LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
            //    lb.Text = "Agregar";
            //}

            //listaContblBuscarsultaGV.HeaderRow.Cells[1].Visible = false;
            //for (int i = 0; i < listaConsultaGV.Rows.Count; i++)
            //{
            //    listaConsultaGV.Rows[i].Cells[1].Visible = false;
            //}
        }

        private void crearTabla2() {
            tablaDia.HeaderRow.Cells[2].Text = "Cédula";
            tablaDia.HeaderRow.Cells[3].Text = "Primer Nombre";
            tablaDia.HeaderRow.Cells[4].Text = "Segundo Nombre";
            tablaDia.HeaderRow.Cells[5].Text = "Primer Apellido";
            tablaDia.HeaderRow.Cells[6].Text = "Segundo Apellido";
            //tablaDia.HeaderRow.Cells[7].Text = "Fecha Nacimiento";
            tablaDia.HeaderRow.Cells[8].Text = "Teléfono";
            //tablaDia.HeaderRow.Cells[9].Text = "Religión";
            //tablaDia.HeaderRow.Cells[10].Text = "Estado Civil";
            //tablaDia.HeaderRow.Cells[11].Text = "Trabajo";
            //tablaDia.HeaderRow.Cells[12].Text = "Sexo";
            tablaDia.HeaderRow.Cells[17].Text = "Alergias";

            //foreach (GridViewRow row in tablaDia.Rows) {
            //    LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
            //    lb.Text = "Eliminar";
            //}

            //listaContblBuscarsultaGV.HeaderRow.Cells[1].Visible = false;
            //for (int i = 0; i < listaConsultaGV.Rows.Count; i++)
            //{
            //    listaConsultaGV.Rows[i].Cells[1].Visible = false;
            //}
        }

        private void invisible() {
            for (int i = 7; i < 17; i++) {
                if (i != 8) {
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

        protected void tblBuscar_RowEditing(object sender, GridViewEditEventArgs e) {
            try {
                BLManejadorExpediente blm = new BLManejadorExpediente();
                int selected = e.NewEditIndex;
                tblBuscar.SelectedIndex = selected;
                blm.insertarDia(new BLExpediente(tblBuscar.SelectedRow.Cells[2].Text.Trim()));
                Response.Redirect("PaginaPrincipal.aspx");
            } catch (Exception) {
                lblError.Text = "Error no se pudo agregar el expediente a la lista del día.";
            }
        }

        protected void tablaDia_SelectedIndexChanged(object sender, EventArgs e) {
            string id = tablaDia.SelectedRow.Cells[2].Text.Trim();
            //Response.Write(id);
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }

        protected void tablaDia_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            try {
                BLManejadorExpediente ble = new BLManejadorExpediente();
                int selected = e.RowIndex;
                tablaDia.SelectedIndex = selected;
                ble.borrarDia(tablaDia.SelectedRow.Cells[2].Text.Trim());
                Response.Redirect("PaginaPrincipal.aspx");
            } catch (Exception) {
                lblError.Text = "Error al borrar el expediente de la lista de consultas del día.";
            }
        }
    }
}