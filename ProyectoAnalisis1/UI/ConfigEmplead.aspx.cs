using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ConfigEmplead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLManejadorEmpleado manejEmpl = new BLManejadorEmpleado();
                BLEmpleado emplead = new BLEmpleado();
                emplead = (BLEmpleado)Session["empleado"];
                emplead = manejEmpl.obtenerEmpleado(emplead.id);
                id.Text = emplead.id;
                txtContra.Text = emplead.contrasenna;
                rol.Text = emplead.rol;
                txtNombre.Text = emplead.nombreEmpleado;
                if (emplead.estado == true)
                {
                    estado.Text = "Habilitado";
                }
                else
                {
                    estado.Text = "Deshabilitado";
                }
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            BLManejadorEmpleado manej = new BLManejadorEmpleado();
            Boolean est = false;
            if (estado.Text.Equals("Habilitado"))
            {
                est = true;
            }
            manej.crearActualizarEmpleado(new BLEmpleado(id.Text.Trim(), txtContra.Text.Trim(), rol.Text.Trim(), txtNombre.Text, est));
        }
    }
}