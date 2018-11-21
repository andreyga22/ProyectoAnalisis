using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI {
    public partial class ListaConsultas : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            revisarLogin();

            //Response.Write(Convert.ToString(Session["cedula"]).Trim());
            cargarGrid();
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

        private void cargarGrid() {
            try {
                BLManejadorConsulta manejador = new BLManejadorConsulta();
                List<BLConsulta> lista = manejador.listaConsultasOrdenado(Convert.ToString(Session["cedula"]));

                if (lista.Count > 0)
                {
                    //listaConsultaGV.Columns[1].Visible = false;
                    listaConsultaGV.DataSource = lista;

                    listaConsultaGV.DataBind();
                    listaConsultaGV.HeaderRow.Cells[1].Text = "Numero";
                    listaConsultaGV.HeaderRow.Cells[2].Text = "Fecha";
                    listaConsultaGV.HeaderRow.Cells[3].Text = "Cédula";
                    listaConsultaGV.HeaderRow.Cells[4].Text = "Precio";

                    foreach (GridViewRow row in listaConsultaGV.Rows)
                    {
                        LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                        lb.Text = "Seleccionar";
                    }

                    listaConsultaGV.HeaderRow.Cells[1].Visible = false;
                    for (int i = 0; i < listaConsultaGV.Rows.Count; i++)
                    {
                        listaConsultaGV.Rows[i].Cells[1].Visible = false;
                    }
                } else
                {
                    errorLbl.Visible = true;
                    errorLbl.Text = "No hay consultas existentes";
                }
            

                //listaConsultaGV.Columns[0].Visible = false;
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al cargar los datos de la lista. Por favor recargue la página o vuelva a la página principal";
            }

        }

        protected void listaConsultaGV_SelectedIndexChanged(object sender, EventArgs e) {
            string id = listaConsultaGV.SelectedRow.Cells[1].Text;
            Session["idConsulta"] = id;
            //Session["nuevaConsulta"] = false;
            Response.Redirect("Consulta.aspx");
        }

        protected void agregarBtn_Click(object sender, EventArgs e) {
            try {
                BLManejadorConsulta manejador = new BLManejadorConsulta();
                BLConsulta consulta = new BLConsulta();
                consulta.fecha = DateTime.Now;
                consulta.cedula = Convert.ToString(Session["cedula"]);
                consulta.precio_Consulta = 0;
                manejador.insertar(consulta);
                //int idConsultaNueva = manejador.consultarUltimo(Convert.ToString(Session["cedula"]));
                int idConsultaNueva = manejador.consultarUltimoConsultaID();
                Session["idConsulta"] = idConsultaNueva;
                Response.Redirect("Consulta.aspx");
            } catch (Exception) {
                errorLbl.Visible = true;
                errorLbl.Text = "Error al guardar los datos de la consulta. Verifique que los datos sean correctos.";
            }
        }




        public void select(int idConsulta) {
            Session["idConsulta"] = idConsulta;
            Response.Redirect("Consulta.aspx");
        }
    }
}