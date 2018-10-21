using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI
{
    public partial class ListaConsultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        

        private void cargarGrid() {
            BLManejadorConsulta manejador = new BLManejadorConsulta();
            List<BLConsulta> lista = manejador.listaConsultas(Convert.ToString(Session["cedula"]));
            listaConsultaGV.DataSource = lista;
            listaConsultaGV.DataBind();
        }

        protected void listaConsultaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id= listaConsultaGV.SelectedRow.Cells[1].Text;
            Session["idConsulta"] = id;
            Response.Redirect("Consulta.aspx");
        }
    }
}