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

            //TableRow fila = new TableRow();

            //TableCell fecha = new TableCell();
            //fecha.Text = "FECHA";
            //fila.Cells.Add(fecha);
            //TableCell precio = new TableCell();
            //precio.Text = "PRECIO";
            //fila.Cells.Add(precio);

            //TablaConsultas.Rows.Add(fila);

            //TableCell control = new TableCell();
            //control.Text = " ";
            //fila.Cells.Add(control);
            //TablaConsultas.Rows.Add(fila);

            //BLManejadorConsulta manejador = new BLManejadorConsulta();
            //List<BLConsulta> listaConsultaBL = manejador.listaConsultas(Convert.ToString(Session["cedula"]));
            //foreach (BLConsulta blConsult in listaConsultaBL)
            //{
            //    agregarFila(blConsult.idConsulta, Convert.ToString(blConsult.fecha), blConsult.precio_Consulta);
            //}
        }


        //private void agregarFila(int idConsulta, String fecha, int precio)
        //{
        //    TableRow fila = new TableRow();

        //    TableCell fec = new TableCell();
        //    fec.Text = fecha.ToString();
        //    fila.Cells.Add(fec);

        //    TableCell prec = new TableCell();
        //    prec.Text = precio.ToString();
        //    fila.Cells.Add(prec);

        //    TableCell botonCell = new TableCell();
        //    Button botonSeleccionar = new Button();
        //    botonSeleccionar.ID = idConsulta.ToString();
        //    botonSeleccionar.Text = "Seleccionar";

        //    botonSeleccionar.Click += delegate { selecc(idConsulta); };

        //    botonCell.Controls.Add(botonSeleccionar);
        //    Label lab = new Label();
        //    lab.Text = "   ";
        //    botonCell.Controls.Add(lab);
        //    fila.Cells.Add(botonCell);
        //    TablaConsultas.Rows.Add(fila);
        //}

        // private void agregarFilaNueva(int idConsulta)
        //{
        //    TableRow fila = new TableRow();

        //    TableCell fec = new TableCell();
        //    fec.Text = "00/00/00";
        //    fila.Cells.Add(fec);

        //    TableCell prec = new TableCell();
        //    prec.Text = "0";
        //    fila.Cells.Add(prec);

        //    TableCell botonCell = new TableCell();
        //    Button botonSeleccionar = new Button();
        //    botonSeleccionar.ID = idConsulta.ToString();
        //    botonSeleccionar.Text = "Seleccionar";

        //    botonSeleccionar.Click += delegate { selecc(idConsulta); };

        //    botonCell.Controls.Add(botonSeleccionar);
        //    Label lab = new Label();
        //    lab.Text = "   ";
        //    botonCell.Controls.Add(lab);
        //    fila.Cells.Add(botonCell);
        //    TablaConsultas.Rows.Add(fila);
        //}

        public void selecc (int idConsulta)
        {
            Session["idConsulta"] = idConsulta;
            Response.Redirect("Consulta.aspx");
        }

        private void cargarGrid()
        {
            BLManejadorConsulta manejador = new BLManejadorConsulta();
            List<BLConsulta> lista = manejador.listaConsultas(Convert.ToString(Session["cedula"]));
            listaConsultaGV.DataSource = lista;
            listaConsultaGV.DataBind();
        }

        protected void listaConsultaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listaConsultaGV.SelectedRow.Cells[1].Text;
            Session["idConsulta"] = id;
            Response.Redirect("Consulta.aspx");
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //BLManejadorConsulta manejConsulta = new BLManejadorConsulta();
            //List<BLConsulta> listaConsultaBL = manejConsulta.listaConsultas(Convert.ToString(Session["cedula"]));
            //int i = 1;
            //foreach (BLConsulta blConsult in listaConsultaBL)
            //{
            //    agregarFila(blConsult.idConsulta, Convert.ToString(blConsult.fecha), blConsult.precio_Consulta);
            //    i++;
            //}
            //agregarFilaNueva(i + 1);
        }
    }
}