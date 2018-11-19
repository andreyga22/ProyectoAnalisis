<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="UI.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <br />
  <%--      <div class="form-group col-sm-6" style="left: 150px; top: -2px">
    <asp:Label ID="lblTitulo" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Administrador de Empleados"></asp:Label>
        </div>--%>

<%--    <div class="form-row">
            <div class="form-group col-sm-6" style="left: 95px; top: 3px">
                <label for="Identificador">Identificador</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
  <%--            <br />
                <asp:TextBox type="text" class="form-control" ID="txtId" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6" style="left: 35px; top: -2px">
                <asp:Label ID="lblContra" runat="server" Text="Contraseña"></asp:Label>--%>
                <%--<label for="Contrasenna">Contraseña</label>--%>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
               
     <%--           <asp:TextBox type="text" class="form-control" ID="contraText" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>--%>
         <%--   </div>
        </div>--%>
 <%--   <br />
    <div class="form-row">
         <div class="form-group col-sm-6" style="left: 95px; top: 3px">
             <label for="nombre">Nombre</label>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="nombreText" ErrorMessage="Solo se permiten letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="admin" ForeColor="Red"></asp:RegularExpressionValidator>
              <br /> <asp:TextBox type="text" class="form-control" ID="nombreText" runat="server" Width="350px" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
             </div>

        <div class="form-group col-sm-6" style="left: 95px; top: 3px">
             <label for="nombre">Estado</label>
            <br />
            <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="chckEstado" runat="server" Text="Habilitado" />
             </div>--<%--%>

       <%--</div>--%>  
  <%--       </div>
        <div class="form-row">
    <div class="form-group col-sm-6"  style="left: 95px; top: 3px">
              <label for="rol">Rol</label>
              <br />
             <asp:DropDownList ID="listRol" runat="server">
                 <asp:ListItem>Doctor</asp:ListItem>
                 <asp:ListItem>Secretaria</asp:ListItem>
                 <asp:ListItem>Paramédico</asp:ListItem>
                 <asp:ListItem>Admin</asp:ListItem>
              </asp:DropDownList>
             </div>
             </div>--%>
<%--    <br />
     <div class="form-group offset-sm-4"">
         <asp:Button ID="idGuardar" class="btn btn-info" runat="server" Text="Guardar" OnClick="idGuardar_Click" style="height: 40px" ValidationGroup="admin" />
         </div>--%>
      <br />  <br />  
        <div class="form-group col-sm-6" style="left: 150px; top: -2px">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Empleados"></asp:Label>
        </div>
    <br />
      <div id="popup" style="max-height: 500px; overflow-y: scroll;">
          <asp:GridView ID="gridEmpl" class="table table-striped table-bordered table-responsive-lg" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridEmpl_SelectedIndexChanged"></asp:GridView>
    <%--<asp:Table ID="" runat="server"></asp:Table>--%>
        <%--<asp:GridView ID="gridEmpl" runat="server" AutoGenerateSelectButton="True">
        </asp:GridView>--%>
             </div>
</asp:Content>
