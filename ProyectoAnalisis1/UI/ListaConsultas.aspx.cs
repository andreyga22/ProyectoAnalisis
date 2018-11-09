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
            //Response.Write(Convert.ToString(Session["cedula"]).Trim());
            cargarGrid();
        }


        public void selecc (int idConsulta)
        {
            Session["idConsulta"] = idConsulta;
            Response.Redirect("Consulta.aspx");
        }

        private void cargarGrid()
        {
            BLManejadorConsulta manejador = new BLManejadorConsulta();
            List<BLConsulta> lista = manejador.listaConsultasOrdenado(Convert.ToString(Session["cedula"]));
            listaConsultaGV.DataSource = lista;
            listaConsultaGV.DataBind();
        }

        protected void listaConsultaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listaConsultaGV.SelectedRow.Cells[1].Text;
            Session["idConsulta"] = id;
            //Session["nuevaConsulta"] = false;
            Response.Redirect("Consulta.aspx");
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //Session["nuevaConsulta"] = true;
            BLManejadorConsulta manejador = new BLManejadorConsulta();
            BLConsulta consulta = new BLConsulta();
            consulta.fecha = DateTime.Now;
            consulta.cedula = Convert.ToString(Session["cedula"]);
            //Response.Write(Convert.ToString(Session["cedula"]) + "hola");
            consulta.precio_Consulta = 0;
            manejador.insertar(consulta);
            int idConsultaNueva = manejador.consultarUltimo(Convert.ToString(Session["cedula"]));
            Session["idConsulta"] = idConsultaNueva;
            Response.Redirect("Consulta.aspx");
        }
    }
}