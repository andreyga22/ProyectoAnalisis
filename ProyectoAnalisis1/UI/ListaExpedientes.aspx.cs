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
            revisarLogin();
            cargarGrid();
            lblErrorExpedientes.Visible = false;
        }

        private void cargarGrid()
        {
            BLManejadorExpediente ble = new BLManejadorExpediente();
            List<BLExpediente> lista = ble.consultarListaExpedientes();
            if (lista.Count > 0)
            {
                tablaExpedi.DataSource = lista;
                tablaExpedi.DataBind();
                invisible();
                crearTabla2();
            }
        }
        private void crearTabla2()
        {
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

        protected void tablaExpedi_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                BLManejadorExpediente blm = new BLManejadorExpediente();
                int selected = e.NewEditIndex;
                tablaExpedi.SelectedIndex = selected;
                blm.insertarDia(tablaExpedi.SelectedRow.Cells[2].Text.Trim());
                Response.Redirect("ListaExpedientes.aspx");
            }
            catch (Exception)
            {
                //lblError.Text = "Error no se pudo agregar el expediente a la lista del día.";
            }
        }

        protected void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            BLManejadorExpediente manejExpediente = new BLManejadorExpediente();
            List<BLExpediente> lista = manejExpediente.filtrarFecha(CalendFechaIni.SelectedDate, calendFechaFin.SelectedDate);
            if (lista.Count > 0)
            {
                tablaExpedi.DataSource = lista;
                tablaExpedi.DataBind();
                invisible();
                crearTabla2();
            } else
            {
                tablaExpedi.Visible = false;
                lblErrorExpedientes.Text = "No se encontraron expedientes con consultas en ese rango de fechas";
                lblErrorExpedientes.Visible = true;
            }
        }

        protected void btnTodosExped_Click(object sender, EventArgs e)
        {
            cargarGrid();
            lblErrorExpedientes.Visible = false;
        }
    }
}