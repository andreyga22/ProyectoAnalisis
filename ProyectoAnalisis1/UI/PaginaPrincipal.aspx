﻿<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="UI.WebForm1" %>

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
        <asp:Literal ID="lblError" runat="server" Visible="false"></asp:Literal>
        <br />

        <div class="form-group col-6">
            <asp:Label ID="lblTablaDia" runat="server" Text="Consultas del día" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <br />
        <asp:Literal ID="mensajeDia" runat="server" Visible="false"></asp:Literal>
        <div id="popup" style="max-height: 500px; overflow-y: scroll;" overflow-x: scroll;">
            <asp:GridView ID="tablaDia" class="table table-striped table-bordered" BorderStyle="None" runat="server" OnRowDeleting="tablaDia_RowDeleting" OnSelectedIndexChanged="tablaDia_SelectedIndexChanged" ViewStateMode="Disabled">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Abrir" />
                    <asp:CommandField ShowDeleteButton="True" DeleteText="Eliminar" />
                    <asp:CommandField SelectText=""/>
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div class="row justify-content-center">
            <asp:Button type="button" class="btn btn-info" ID="btnNuevoExp" runat="server" Text="Crear Nuevo Expediente" OnClick="btnNuevoExp_Click" />

        </div>
        <br />
        <div class="row justify-content-center">
            <asp:Button type="button" class="btn btn-light" ID="btnListaExpedientes" runat="server" OnClick="btnExpedientes_Click" Text="Ver todos los expedientes" />
        </div>
        <br />
        <br />
        <br />


        <div class="form-group col-sm-6">
            <asp:Label ID="lblBuscar" runat="server" Text="Buscar expedientes" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <br />
        <div class="form-row justify-content-center">
            <div class="form-group col-sm-5">
                <label for="txtbusqCedula">Buscar por Cédula</label>
                <asp:TextBox ID="txtbusqCedula" runat="server" ValidationGroup="cedula" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
                <asp:Button type="button" class="btn btn-light" ID="buscarCedula" runat="server" Text="Buscar" OnClick="buscarCedula_Click" />
                <asp:Label ID="lblNoBusqCedula" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqCedula" ForeColor="Red" ValidationGroup="cedula">El espacio no debe estar vacío</asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-sm-5">
                <label for="txtbusqNombre">Buscar por Nombre</label>
                <asp:TextBox ID="txtbusqNombre" runat="server" ValidationGroup="nombre" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
                <asp:Button type="button" class="btn btn-light" ID="buscarNombre" runat="server" Text="Buscar" OnClick="buscarNombre_Click" />
                <asp:Label ID="lblNoBusqNombre" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtbusqNombre" ForeColor="Red" ValidationGroup="nombre">El espacio no debe estar vacío</asp:RequiredFieldValidator>
            </div>
        </div>

        <asp:Literal ID="mensajeBuscar" runat="server" Visible="false"></asp:Literal>

        <div id="popup" style="max-height: 500px; overflow-y: scroll;" overflow-x: scroll;">
            <asp:GridView ID="tblBuscar" class="table table-striped table-bordered" runat="server" AutoGenerateSelectButton="False" OnSelectedIndexChanged="listaBusq_SelectedIndexChanged" AutoGenerateEditButton="False" OnRowDeleting="tblBuscar_RowDeleting">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Abrir" />
                    <asp:CommandField ShowDeleteButton="True" DeleteText="Agregar" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <br />
        <br />

    </div>

</asp:Content>
