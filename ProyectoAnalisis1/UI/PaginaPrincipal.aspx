<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="UI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item active" aria-current="page">Principal</li>
        </ol>
    </nav>
    <div class="container">
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        <br />

        <div class="form-group offset-sm-4">
            <asp:Button type="button" class="btn btn-info" ID="btnNuevoExp" runat="server" Text="Crear Nuevo Expediente" OnClick="btnNuevoExp_Click" />
            <%--<a href="PaginaPrincipal.aspx">PaginaPrincipal.aspx</a>--%>
        </div>

        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="txtbusqCedula">Buscar por Cédula</label>
                <asp:TextBox ID="txtbusqCedula" runat="server" ValidationGroup="cedula" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
                <asp:Button type="button" class="btn btn-light" ID="buscarCedula" runat="server" Text="Buscar" OnClick="buscarCedula_Click" />
                <asp:Label ID="lblNoBusqCedula" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqCedula" ForeColor="Red" ValidationGroup="cedula">El espacio no debe estar vacio</asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-sm-6">
                <label for="txtbusqNombre">Buscar por Nombre</label>
                <asp:TextBox ID="txtbusqNombre" runat="server" ValidationGroup="nombre" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
                <asp:Button type="button" class="btn btn-light" ID="buscarNombre" runat="server" Text="Buscar" OnClick="buscarNombre_Click" />
                <asp:Label ID="lblNoBusqNombre" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqNombre" ForeColor="Red" ValidationGroup="nombre">El espacio no debe estar vacio</asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="table-responsive">
            <asp:GridView ID="tblBuscar" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="listaBusq_SelectedIndexChanged" AutoGenerateEditButton="True" OnEditIndexChanged="listaBusq_EditIndexChanged"></asp:GridView>
        </div>
    </div>

</asp:Content>
