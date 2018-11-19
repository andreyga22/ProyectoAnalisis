<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="UI.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div class="container">
        <br />
        <div class="form-group col-sm-6" style="left: 150px; top: -2px">
    <asp:Label ID="lblTitulo" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Administrador de Empleados"></asp:Label>
        </div>

      <div class="row justify-content-center">
                 <%--<div class="form-group col-sm-6" style="left: 95px; top: 3px">--%>
             <div class="form-group col-sm-4">
                <label for="Identificador">Identificador</label>
              <br />
                <asp:TextBox type="text" class="form-control" ID="txtId" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
            </div>
        <%--    <div class="form-group col-sm-6" style="left: 35px; top: -2px">--%>
             <div class="form-group col-sm-4">
                <asp:Label ID="lblContra" runat="server" Text="Contraseña"></asp:Label>
               
                <asp:TextBox type="text" class="form-control" ID="contraText" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
            </div>
        </div>
    <br />
       <div class="row justify-content-center">
         <%--<div class="form-group col-sm-6" style="left: 95px; top: 3px">--%>
              <div class="form-group col-sm-4">
             <label for="nombre">Nombre</label>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="nombreText" ErrorMessage="Solo se permiten letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="admin" ForeColor="Red"></asp:RegularExpressionValidator>
              <br /> <asp:TextBox type="text" class="form-control" ID="nombreText" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
             </div>

        <%--<div class="form-group col-sm-6" style="left: 95px; top: 3px">--%>
    

       </div>  
   
          <div class="row justify-content-center">
    <%--<div class="form-group col-sm-6"  style="left: 95px; top: 3px">--%>
                     <div class="form-group col-sm-4">
             <label for="nombre">Estado</label>
            <br />
            <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="chckEstado" runat="server" Text="Habilitado" />
             </div>
              
              <div class="form-group col-sm-4">
              <label for="rol">Rol</label>
              <br />
             <asp:DropDownList ID="listRol" runat="server">
                 <asp:ListItem>Doctor</asp:ListItem>
                 <asp:ListItem>Secretaria</asp:ListItem>
                 <asp:ListItem>Paramedico</asp:ListItem>
                 <asp:ListItem>Admin</asp:ListItem>
              </asp:DropDownList>
             </div>
             </div>
    <br />
     <div class="form-group offset-sm-4"">
         <asp:Button ID="idGuardar" class="btn btn-info" runat="server" Text="Guardar" OnClick="idGuardar_Click" style="height: 40px" ValidationGroup="admin" />
         <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
     </div>
      <br />  <br />  
        <div class="form-group col-sm-6" style="left: 150px; top: -2px">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Empleados"></asp:Label>
        </div>
    <br />
      <div id="popup" style="max-height: 500px; overflow-y: scroll;">
          <asp:GridView ID="gridEmpl" class="table table-striped table-bordered table-responsive-lg" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridEmpl_SelectedIndexChanged"></asp:GridView>
    <%--<asp:Table ID="" runat="server"></asp:Table>--%>
      <%--  <asp:GridView ID="gridEmpl" runat="server" AutoGenerateSelectButton="True">
        </asp:GridView>--%>
             </div>
      </div>
</asp:Content>
