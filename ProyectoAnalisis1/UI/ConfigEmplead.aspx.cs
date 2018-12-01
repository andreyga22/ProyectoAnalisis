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
            try {
                if (!IsPostBack) {
                    BLManejadorEmpleado manejEmpl = new BLManejadorEmpleado();
                    BLEmpleado emplead = new BLEmpleado();
                    emplead = (BLEmpleado)Session["empleado"];
                    emplead = manejEmpl.obtenerEmpleado(emplead.id);
                    id.Text = emplead.id;
                    //txtContra.Text = emplead.contrasenna;
                    rol.Text = emplead.rol;
                    txtNombre.Text = emplead.nombreEmpleado;
                    if (emplead.estado == true) {
                        estado.Text = "Habilitado";
                    } else {
                        estado.Text = "Deshabilitado";
                    }
                }
            } catch (Exception) {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error al cargar la información. </strong>Verifique su conexión a internet.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BLEmpleado emplead = (BLEmpleado)Session["empleado"];
                if (txtContra.Text.Trim().Equals(emplead.contrasenna.Trim()))
                {
                    BLManejadorEmpleado manej = new BLManejadorEmpleado();
                    Boolean est = false;
                    if (estado.Text.Equals("Habilitado"))
                    {
                        est = true;
                    }
                    manej.crearActualizarEmpleado(new BLEmpleado(id.Text.Trim(), txtContraNueva.Text.Trim(), rol.Text.Trim(), txtNombre.Text, est));
                    lblError.Text = "<div class=\"alert alert-success alert - dismissible fade show\" role=\"alert\"> <strong>¡Éxito! </strong>Información almacenada correctamente.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    lblError.Visible = true;
                } else
                {
                    lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>La contraseña actual no coincide.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                    lblError.Visible = true;
                }
            }
            catch (Exception)
            {
                lblError.Text = "<div class=\"alert alert-danger alert - dismissible fade show\" role=\"alert\"> <strong>Error </strong>No se guardó la información del empleado.<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">&times;</span> </button> </div>";
                lblError.Visible = true;
            }
        }
    }
}