<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="UI.Administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <br />
        <br />

        <div class="form-group col-sm-6">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Empleados"></asp:Label>
        </div>
        <br />
        <div id="popup" style="max-height: 500px; overflow-y: scroll;">
            <div class="offset-1 col-10">
                <asp:GridView ID="gridEmpl" class="table table-striped table-bordered table-responsive-lg" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridEmpl_SelectedIndexChanged"></asp:GridView>
            </div>
        </div>


        <br />
        <br />
        <br />
        <div class="form-group">
            <asp:Label ID="lblTitulo" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8" Text="Administrador de Empleados"></asp:Label>
        </div>
        <br />
        <br />
        <div class="form-group">
            <label for="txtId">Identificador</label>
            <br />
            <asp:TextBox type="text" class="form-control" ID="txtId" runat="server" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="contraText">Contraseña</label>
            <asp:TextBox type="text" class="form-control" ID="contraText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="nombreText">Nombre</label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="nombreText" ErrorMessage="Solo se permiten letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="admin" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <asp:TextBox type="text" class="form-control" ID="nombreText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>
        <br />

        <div class="form-group justify-content-around col-sm-6">
            <label for="listRol">Rol</label>
            <br />
            <asp:DropDownList ID="listRol" runat="server">
                <asp:ListItem>Doctor</asp:ListItem>
                <asp:ListItem>Secretaria</asp:ListItem>
                <asp:ListItem>Paramedico</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <div class="col-sm-6">
            <label for="chckEstado">Estado</label><br />
            <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="chckEstado" runat="server" Text="Habilitado" />
        </div>

        <br />
        <br />
        <div class="row justify-content-center">
            <asp:Button ID="idGuardar" class="btn btn-info" runat="server" Text="Guardar" OnClick="idGuardar_Click" Style="height: 40px" ValidationGroup="admin" />
            <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>

        <br />
        <br />

    </div>
</asp:Content>
