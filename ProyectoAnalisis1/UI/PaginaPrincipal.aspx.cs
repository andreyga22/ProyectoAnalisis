using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["cedula"] = "";
            Session["idConsulta"] = "";
            lblNoBusqCedula.Visible = false;
            lblNoBusqNombre.Visible = false;
        }

        protected void btnNuevoExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("expediente.aspx");
        }

        protected void buscarCedula_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (!String.IsNullOrEmpty(txtbusqCedula.Text.Trim()) || (!String.IsNullOrWhiteSpace(txtbusqCedula.Text.Trim())))
                {
                    BLManejadorExpediente manejador = new BLManejadorExpediente();
                    BLExpediente expediente = manejador.consultarExpediente(txtbusqCedula.Text);
                    if (String.IsNullOrEmpty(expediente.cedula) || (String.IsNullOrWhiteSpace(expediente.cedula)))
                    {
                        lblNoBusqCedula.Visible = true;
                        tblBuscar.Visible = false;
                    }
                    else
                    {
                        List<BLExpediente> lista = new List<BLExpediente>();
                        lista.Add(expediente);
                        tblBuscar.DataSource = lista;
                        tblBuscar.DataBind();
                        crearTabla();
                        tblBuscar.Visible = true;
                    }
                }
            //} catch (Exception)
            //{
            //    lblError.Visible = true;
            //    lblError.Text = "Error al cargar la información. Verifique su conexión a internet";
            //}
        }

        protected void listaBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = tblBuscar.SelectedRow.Cells[1].Text.Trim();
            Response.Write(id);
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }

        protected void buscarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtbusqNombre.Text.Trim()) || (!String.IsNullOrWhiteSpace(txtbusqNombre.Text.Trim())))
                {
                    BLManejadorExpediente manejador = new BLManejadorExpediente();
                    List<BLExpediente> listaExpediente = manejador.consultarListaExpedNombre(txtbusqNombre.Text);
                    if (listaExpediente.Count > 0)
                    {
                        tblBuscar.Visible = true;
                        tblBuscar.DataSource = listaExpediente;
                        tblBuscar.DataBind();
                        crearTabla();

                    }
                    else
                    {
                        lblNoBusqNombre.Visible = true;
                        tblBuscar.Visible = false;
                    }
                }
            } catch (Exception)
            {
                lblError.Visible = true;
                lblError.Text = "Error al cargar la información. Verifique su conexión a internet";
            }
        }

        private void crearTabla()
        {
            tblBuscar.HeaderRow.Cells[1].Text = "Cédula";
            tblBuscar.HeaderRow.Cells[2].Text = "Primer Nombre";
            tblBuscar.HeaderRow.Cells[3].Text = "Segundo Nombre";
            tblBuscar.HeaderRow.Cells[4].Text = "Primer Apellido";
            tblBuscar.HeaderRow.Cells[5].Text = "Segundo Apellido";
            tblBuscar.HeaderRow.Cells[6].Text = "Fecha Nacimiento";
            tblBuscar.HeaderRow.Cells[7].Text = "Teléfono";
            tblBuscar.HeaderRow.Cells[8].Text = "Religión";
            tblBuscar.HeaderRow.Cells[9].Text = "Estado Civil";
            tblBuscar.HeaderRow.Cells[10].Text = "Trabajo";
            tblBuscar.HeaderRow.Cells[11].Text = "Sexo";

            foreach (GridViewRow row in tblBuscar.Rows)
            {
                LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                lb.Text = "Agregar";
            }

            //listaContblBuscarsultaGV.HeaderRow.Cells[1].Visible = false;
            //for (int i = 0; i < listaConsultaGV.Rows.Count; i++)
            //{
            //    listaConsultaGV.Rows[i].Cells[1].Visible = false;
            //}
        }
    }
}