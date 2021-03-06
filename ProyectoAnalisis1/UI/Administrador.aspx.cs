﻿using System;
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
            try {
                revisarLogin();
                cargarGrid();
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
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
                lblMensaje.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar los datos de la lista. </strong>Por favor recargue la página o vuelva a la página principal.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
                //errorLbl.Visible = true;
                //errorLbl.Text = "Error al cargar los datos de la lista. Por favor recargue la página o vuelva a la página principal";
            }

        }

        protected void idGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLManejadorEmpleado manejEmpleado = new BLManejadorEmpleado();
                manejEmpleado.crearNuevoEmpleado(new BLEmpleado(txtId.Text.Trim(), contraText.Text.Trim(), listRol.SelectedValue, nombreText.Text.Trim(), chckEstado.Checked));
                lblMensaje.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Empleado creado exitosamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
                cargarGrid();
                //Response.Redirect("Administrador.aspx");
            }
            catch (Exception)
            {
                lblMensaje.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error. </strong>El usuario ya existe. <button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
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
            } catch (Exception)
            {
                lblMensaje.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error. </strong>No se pudo seleccionar el empleado.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblMensaje.Visible = true;
            }
        }

    }
}