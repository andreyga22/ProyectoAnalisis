using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //crearEncabezado();
            //List<BLEmpleado> listEmpleado = new BLManejadorEmpleado().listaEmpleado();
            //foreach (BLEmpleado blEmp in listEmpleado)
            //{
            //    agregarFilaEmpleado(blEmp.id, blEmp.contrasenna, blEmp.rol, blEmp.nombreEmpleado, blEmp.estado);
            //}
            lblError.Visible = false;
            revisarLogin();
            cargarGrid();
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
                if (!emp.rol.Equals("Admin"))
                {
                    Response.Redirect("InicioDeSesion.aspx");
                }
            }
        }

        private void cargarGrid()
        {
            try
            {
                List<BLEmpleado> listEmpleado = new BLManejadorEmpleado().listaEmpleado();

                //listaConsultaGV.Columns[1].Visible = false;
                gridEmpl.DataSource = listEmpleado;

                gridEmpl.DataBind();
                gridEmpl.HeaderRow.Cells[1].Text = "Identificador";
                gridEmpl.HeaderRow.Cells[2].Text = "Contraseña";
                gridEmpl.HeaderRow.Cells[3].Text = "Nombre";
                gridEmpl.HeaderRow.Cells[4].Text = "Rol";
                gridEmpl.HeaderRow.Cells[5].Text = "Estado";

                foreach (GridViewRow row in gridEmpl.Rows)
                {
                    LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                    lb.Text = "Cambiar Estado";
                }

                gridEmpl.HeaderRow.Cells[2].Visible = false;
                for (int i = 0; i < gridEmpl.Rows.Count; i++)
                {
                    gridEmpl.Rows[i].Cells[2].Visible = false;
                }
            }
            catch (Exception)
            {
                //errorLbl.Visible = true;
                //errorLbl.Text = "Error al cargar los datos de la lista. Por favor recargue la página o vuelva a la página principal";
            }

        }

        protected void idGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLManejadorEmpleado manejEmpleado = new BLManejadorEmpleado();
                manejEmpleado.crearActualizarEmpleado(new BLEmpleado(txtId.Text.Trim(), contraText.Text.Trim(), listRol.SelectedValue, nombreText.Text.Trim(), chckEstado.Checked));

                Response.Redirect("Administrador.aspx");
            }
            catch (Exception)
            {
                lblError.Text = "No se pudo guardar el nuevo empleado";
                lblError.Visible = true;
            }
       
        }

        protected void gridEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = gridEmpl.SelectedRow.Cells[1].Text;
                BLManejadorEmpleado manejEmpleado = new BLManejadorEmpleado();
                BLEmpleado empleado = manejEmpleado.obtenerEmpleado(id);
                manejEmpleado.crearActualizarEmpleado(new BLEmpleado(empleado.id, empleado.contrasenna, empleado.rol, empleado.nombreEmpleado, !empleado.estado));
                Response.Redirect("Administrador.aspx");
                //BLEmpleado empleado = new BLEmpleado();
                //txtId.Text = empleado.id;
                ////Response.Write(empleado.id);
                //contraText.Text = empleado.contrasenna;
                //listRol.SelectedValue = empleado.rol;
                //chckEstado.Checked = empleado.estado;
                //nombreText.Text = empleado.nombreEmpleado;
                //txtId.Enabled = false;
                //listRol.Enabled = false;
                //nombreText.Enabled = false;
                //contraText.Visible = false;
                //lblContra.Visible = false;
            } catch (Exception)
            {

            }
        }

    }
}