using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ListaExpedientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                revisarLogin();
                cargarGrid();
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
            }
        }

        private void cargarGrid()
        {
            try {
                BLManejadorExpediente ble = new BLManejadorExpediente();
                List<BLExpediente> lista = ble.consultarListaExpedientes();
                if (lista.Count > 0) {
                    tablaExpedi.DataSource = lista;
                    tablaExpedi.DataBind();
                    invisible();
                    crearTabla2();
                }
            } catch (Exception) {
                lblError2.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError2.Visible = true;
            }
        }
        private void crearTabla2()
        {
            try {
                tablaExpedi.HeaderRow.Cells[2].Text = "Cédula";
                tablaExpedi.HeaderRow.Cells[3].Text = "Primer Nombre";
                tablaExpedi.HeaderRow.Cells[4].Text = "Segundo Nombre";
                tablaExpedi.HeaderRow.Cells[5].Text = "Primer Apellido";
                tablaExpedi.HeaderRow.Cells[6].Text = "Segundo Apellido";
                //tablaDia.HeaderRow.Cells[7].Text = "Fecha Nacimiento";
                tablaExpedi.HeaderRow.Cells[8].Text = "Teléfono";
                //tablaExpedi.HeaderRow.Cells[9].Text = "Religión";
                //tablaDia.HeaderRow.Cells[10].Text = "Estado Civil";
                //tablaDia.HeaderRow.Cells[11].Text = "Trabajo";
                //tablaDia.HeaderRow.Cells[12].Text = "Sexo";
                //tablaDia.HeaderRow.Cells[17].Text = "Alergias";
            } catch (Exception) {
                lblError2.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError2.Visible = true;
            }
        }
        private void invisible()
        {
            for (int i = 7; i <= 17; i++)
            {
                if (i != 8 || i != 9)
                {
                    tablaExpedi.HeaderRow.Cells[i].Visible = false;
                    for (int x = 0; x < tablaExpedi.Rows.Count; x++)
                    {
                        tablaExpedi.Rows[x].Cells[i].Visible = false;
                    }
                }
            }
        }

        private void revisarLogin()
        {
            BLEmpleado emp = (BLEmpleado)Session["empleado"];
            if (emp == null)
            {
                Response.Redirect("InicioDeSesion.aspx");
            }
            else
            {
                if ((!emp.rol.Equals("Secretaria")) && (!emp.rol.Equals("Doctor")) && (!emp.rol.Equals("Paramedico")))
                {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }

        protected void tablaExpedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = tablaExpedi.SelectedRow.Cells[2].Text.Trim();
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }
        

        protected void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
                BLManejadorExpediente manejExpediente = new BLManejadorExpediente();
                List<BLExpediente> lista = manejExpediente.filtrarFecha(CalendFechaIni.SelectedDate, calendFechaFin.SelectedDate);
                if (lista.Count > 0) {
                    tablaExpedi.DataSource = lista;
                    tablaExpedi.DataBind();
                    invisible();
                    crearTabla2();
                } else {
                    tablaExpedi.Visible = false;
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>No se encontraron expedientes con consultas en ese rango de fechas.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //lblErrorExpedientes.Text = "No se encontraron expedientes con consultas en ese rango de fechas";
                //lblErrorExpedientes.Visible = true;
            }
        }

        protected void btnTodosExped_Click(object sender, EventArgs e)
        {
            cargarGrid();
            //lblErrorExpedientes.Visible = false;
        }

        protected void tablaExpedi_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            try {
                BLManejadorExpediente blm = new BLManejadorExpediente();
                int selected = e.RowIndex;
                tablaExpedi.SelectedIndex = selected;
                blm.insertarDia(tablaExpedi.SelectedRow.Cells[2].Text.Trim());
                lblError.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Expediente agregado correctamente a la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //Response.Redirect("ListaExpedientes.aspx");
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>No se pudo agregar el expediente a la lista del día.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
                //lblError.Text = "Error no se pudo agregar el expediente a la lista del día.";
            }
        }
    }
}