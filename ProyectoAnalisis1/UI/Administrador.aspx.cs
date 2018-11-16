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
        }

        protected void idGuardar_Click(object sender, EventArgs e)
        {
            
            BLManejadorEmpleado manejEmpleado = new BLManejadorEmpleado();
            manejEmpleado.crearActualizarEmpleado(new BLEmpleado(txtId.Text.Trim(), contraText.Text.Trim(), listRol.SelectedValue.ToString(), nombreText.Text.Trim(), chckEstado.Checked));

        }

        //    public void crearEncabezado()
        //    {
        //        TableRow fila = new TableRow();

        //        TableCell correo = new TableCell();
        //        correo.Text = "IDENTIFICADOR";
        //        fila.Cells.Add(correo);
        //        //TableCell contra = new TableCell();
        //        //contra.Text = "CONTRASEÑA";
        //        //fila.Cells.Add(contra);
        //        TableCell rol = new TableCell();
        //        rol.Text = "ROL";
        //        fila.Cells.Add(rol);
        //        TableCell estadoCuent = new TableCell();
        //        estadoCuent.Text = "ESTADO DE CUENTA";
        //        fila.Cells.Add(estadoCuent);
        //        TableCell nombre = new TableCell();
        //        nombre.Text = "NOMBRE";
        //        fila.Cells.Add(nombre);
        //        tblEmpleados.Rows.Add(fila);
        //        TableCell control = new TableCell();
        //        control.Text = " ";
        //        fila.Cells.Add(control);
        //        tblEmpleados.Rows.Add(fila);
        //}

        //public void agregarFilaEmpleado(string id, string contrasenna, string rol, string nombreEmpleado, Boolean estado)
        //{
        //    TableRow fila = new TableRow();

        //    TableCell identificador = new TableCell();
        //    identificador.Text = id.ToString();
        //    fila.Cells.Add(identificador);
        //    //TableCell contra = new TableCell();
        //    //contra.Text = contrasenna.ToString();
        //    //fila.Cells.Add(contra);
        //    TableCell rolEmp = new TableCell();
        //    rolEmp.Text = rol.ToString();
        //    fila.Cells.Add(rolEmp);
        //    TableCell estadoCuenta = new TableCell();
        //    chckEstado.Checked = estado;
        //    if(estado == true)
        //    {
        //        estadoCuenta.Text = "Habilitado";
        //    } else
        //    {
        //        estadoCuenta.Text = "Deshabilitado";
        //    }
        //    fila.Cells.Add(estadoCuenta);
        //    TableCell nombre = new TableCell();
        //    nombre.Text = nombreEmpleado.ToString();
        //    fila.Cells.Add(nombre);


        //    TableCell botonCell = new TableCell();
        //    Button botonModificar = new Button();
        //    //Button botonDeshab = new Button();
        //    botonModificar.ID = id.ToString();
        //    botonModificar.Text = "Modificar";
        //    //botonDeshab.Text = "Eliminar";
        //    //botonDeshab.ID = id.ToString() + 0;
        //    botonModificar.Click += delegate { modif(id); };
        //    //botonDeshab.Click += delegate { elim(correoUsu); };
        //    botonCell.Controls.Add(botonModificar);
        //    Label lab = new Label();
        //    lab.Text = "   ";
        //    botonCell.Controls.Add(lab);
        //    //botonCell.Controls.Add(botonDeshab);
        //    fila.Cells.Add(botonCell);
        //    tblEmpleados.Rows.Add(fila);
        //    tblEmpleados.DataBind();
        //}

        //public void modif(string id)
        //{
        //    BLEmpleado empleado = new BLManejadorEmpleado().obtenerEmpleado(id);
        //    txtId.Text = empleado.id;
        //    Response.Write(empleado.id);
        //    contraText.Text = empleado.contrasenna;
        //    listRol.Text = empleado.rol;
        //    chckEstado.Checked = empleado.estado;
        //    nombreText.Text = empleado.nombreEmpleado;
        //    txtId.Enabled = false;
        //    listRol.Enabled = false;
        //    contraText.Visible = false;
        //}
    }
}