<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="ListaExpedientes.aspx.cs" Inherits="UI.ListaExpedientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item active" aria-current="page">Lista de Expedientes</li>
        </ol>
    </nav>
     <div class="container">
    <br />

         <br />

            <div class="form-group col-6">
            <asp:Label ID="lblFiltrar" runat="server" Text="Filtrar Expediente por Rango de Fecha de Consultas" Font-Size="Large" ForeColor="#16ACB8"></asp:Label>
        </div>
     
         <div class="container">
    <div class="row">
        <div class="col-md-6">
			   Fecha inicio:<br />
        	<div style="text-align: center">
        <asp:Calendar ID="CalendFechaIni" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
             </asp:Calendar>
        		<br />
        <br />
         </div>
        </div>
        <div class="col-md-6">
			Fecha Fin:<div style="text-align: center">
         	   <div style="text-align: center">
        		   <asp:Calendar ID="calendFechaFin" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
					   <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
					   <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
					   <OtherMonthDayStyle ForeColor="#999999" />
					   <SelectedDayStyle BackColor="#333399" ForeColor="White" />
					   <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
					   <TodayDayStyle BackColor="#CCCCCC" />
				   </asp:Calendar>
				   <br />
             </div>
				<br />
             </div>
        </div>
    </div>
            
                  <div class="row justify-content-center">
            <asp:Button type="button" class="btn btn-info" ID="btnFiltrarFecha" runat="server" Text="Filtrar" OnClick="btnFiltrarFecha_Click" />
                                     
        </div>
             <br />
              <div class="row justify-content-center">
              <asp:Button type="button" class="btn btn-light" ID="btnTodosExped" runat="server" Text="Todos Expedientes" OnClick="btnTodosExped_Click" />  

              </div>                 
</div>
          <br />
               <div class="form-group col-6">
            <asp:Label ID="lblExpedientes" runat="server" Text="Expedientes" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
          <asp:Label ID="lblErrorExpedientes" runat="server" ForeColor="Red" Text="No se encontraron expedientes" Visible="False"></asp:Label>
          <br />
    <div id="popup" style="max-height: 700px; overflow-y: scroll;">
            <asp:GridView ID="tablaExpedi" class="table table-striped table-bordered table-responsive-lg" BorderStyle="None" runat="server"  OnSelectedIndexChanged="tablaExpedi_SelectedIndexChanged" AutoGenerateEditButton="False" OnRowEditing="tablaExpedi_RowEditing" ViewStateMode="Disabled">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Abrir"/>
                    <asp:CommandField ShowEditButton="True" EditText="Agregar" />
                </Columns>
            </asp:GridView>
        </div>
</div>
</asp:Content>
