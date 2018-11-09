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
            lblNoBusqCedula.Visible = false;
            lblNoBusqNombre.Visible = false;
        }

        protected void btnNuevoExp_Click(object sender, EventArgs e)
        {
            Response.Redirect("expediente.aspx");
        }

        protected void buscarCedula_Click(object sender, EventArgs e)
        {
            BLManejadorExpediente manejador = new BLManejadorExpediente();
            BLExpediente expediente = manejador.consultarExpediente(txtbusqCedula.Text);
            if (String.IsNullOrEmpty(expediente.cedula) || (String.IsNullOrWhiteSpace(expediente.cedula)))
            {
                lblNoBusqCedula.Visible = true;
            }
            else
            {
                List<BLExpediente> lista = new List<BLExpediente>();
                lista.Add(expediente);
                tblBuscar.DataSource = lista;
                tblBuscar.DataBind();
            }
        }

        protected void listaBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = tblBuscar.SelectedRow.Cells[1].Text;
            Session["cedula"] = id;
            Response.Redirect("expediente.aspx");
        }

        protected void buscarNombre_Click(object sender, EventArgs e)
        {
            BLManejadorExpediente manejador = new BLManejadorExpediente();
            List<BLExpediente> listaExpediente = manejador.consultarListaExpedNombre(txtbusqNombre.Text);
            //if (String.IsNullOrEmpty(listaExpediente.First().cedula))
            //{
            //    lblBuscNombre.Visible = true;
            //}
            //else
            //{
                tblBuscar.DataSource = listaExpediente;
                tblBuscar.DataBind();
            //}
        }
    }
}