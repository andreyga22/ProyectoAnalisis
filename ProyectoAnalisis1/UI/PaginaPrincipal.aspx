<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="UI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <br />
        <br />

        <div class="form-group offset-sm-4">
            <asp:Button type="button" class="btn btn-light" ID="btnNuevoExp" runat="server" Text="Crear Nuevo Expediente" OnClick="btnNuevoExp_Click" />
        </div>

        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="txtbusqCedula">Buscar por Cédula</label>
                <asp:TextBox ID="txtbusqCedula" runat="server" ValidationGroup="cedula"></asp:TextBox>
                <asp:Button ID="buscarCedula" runat="server" Text="Buscar" OnClick="buscarCedula_Click" />
                <asp:Label ID="lblNoBusqCedula" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqCedula" ForeColor="Red" ValidationGroup="cedula">El espacio no debe estar vacio</asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-sm-6">
                <label for="txtbusqNombre">Buscar por Nombre</label>
                <asp:TextBox ID="txtbusqNombre" runat="server" ValidationGroup="nombre"></asp:TextBox>
                <asp:Button ID="buscarNombre" runat="server" Text="Buscar" OnClick="buscarNombre_Click" />
                <asp:Label ID="lblNoBusqNombre" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqNombre" ForeColor="Red" ValidationGroup="nombre">El espacio no debe estar vacio</asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="table-responsive">
            <asp:GridView ID="tblBuscar" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="listaBusq_SelectedIndexChanged"></asp:GridView>
        </div>
    </div>

</asp:Content>
