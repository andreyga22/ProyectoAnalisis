﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI {
    public partial class InicioDeSesion : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Page.Master.FindControl("linkCerrarSesion").Visible = false;
            Page.Master.FindControl("linkConfigEmplea").Visible = false;
            Page.Master.FindControl("linkAyuda").Visible = false;
            cerrarSesion();
            lblError.Visible = false;
        }

        private void cerrarSesion() {
            Session["empleado"] = null;
            Session["cedula"] = "";
            Session["idConsulta"] = "";
            Session["idDoctor"] = null;
        }

        protected void entrarBtn_Click(object sender, EventArgs e) {
            
            try {
                String idUsuario = txtId.Text.Trim();
                String contra = txtContra.Text.Trim();
                BLEmpleado empleado = new BLManejadorEmpleado().buscarEmpleado(idUsuario, contra);

                if (empleado.id != null && !empleado.id.Equals("")) {
                    //Session["iEmpleado"] = empleado.id;
                    //Session["rolEmpleado"] = empleado.rol;
                    if (empleado.estado == true) {
                        Session["empleado"] = empleado;
                        if (empleado.rol.Equals("Admin")) {
                            Response.Redirect("Administrador.aspx");
                        } else {
                            Response.Redirect("PaginaPrincipal.aspx");
                        }
                    } else
                    {
                        lblError.Text = "El usuario se encuentra deshabilitado";
                        lblError.Visible = true;
                    }
                } else {
                    lblError.Visible = true;
                }
            } catch (Exception) {
                lblError.Text = "Error. Recargue la página";
                lblError.Visible = true;
            }
        }
    }
}