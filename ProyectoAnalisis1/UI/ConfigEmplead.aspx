﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="ConfigEmplead.aspx.cs" Inherits="UI.ConfigEmplead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="Principal.aspx">Principal</a></li>
            <li class="breadcrumb-item active" aria-current="page">Configuración</li>
        </ol>
    </nav>--%>

    <div class="container-fluid">
        <br />
        <br />

        <div class="row justify-content-center">
            <asp:Label ID="lblConfigur" runat="server" Text="CONFIGURACIÓN DE LA CUENTA" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <asp:Literal ID="lblError" runat="server" Visible="false"></asp:Literal>
        <br />



        <div class="row justify-content-center">
            <div class="form-group col-sm-3">
                <label for="lblID">Identificador:</label>
                <br />
                <asp:Label ID="id" runat="server" Text="Label"></asp:Label>
            </div>

            <div class="form-group col-sm-3">
                <label for="lblID">Rol:</label>
                   <br />
                <asp:Label ID="rol" runat="server" Text="Label"></asp:Label>
            </div>
        </div>

        <br />

        <div class="row justify-content-center">

            <div class="form-group col-sm-3">
                <label for="txtNombre">Nombre:</label>
                <asp:TextBox ID="txtNombre" type="text" class="form-control" runat="server" BorderColor="#16ACB8" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Obligatorio" ForeColor="Red" ValidationGroup="entrar"></asp:RequiredFieldValidator>
            </div>
             <div class="form-group col-sm-3">
                <label for="lblEstado">Estado:</label>
                    <br />
                <asp:Label ID="estado" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <br />
        <div class="row justify-content-center">
           
            <div class="form-group col-sm-3">
                <label for="lblContra">Contraseña Actual:</label>
                <asp:TextBox ID="txtContra" type="text" class="form-control" runat="server" BorderColor="#16ACB8" onkeypress="if (event.keyCode == 13) { return false;}" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContra" ErrorMessage="Campo obligatorio" ForeColor="Red" ValidationGroup="entrar"></asp:RequiredFieldValidator>
            </div>

             <div class="form-group col-sm-3">
                <label for="lblContra2">Contraseña Nueva:</label>
                <asp:TextBox ID="txtContraNueva" type="text" class="form-control" runat="server" BorderColor="#16ACB8" onkeypress="if (event.keyCode == 13) { return false;}" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContraNueva" ErrorMessage="Campo obligatorio" ForeColor="Red" ValidationGroup="entrar"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row justify-content-center">
            <asp:Button ID="btnConfig" type="button" class="btn btn-info" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="entrar" />
        </div>

    </div>
</asp:Content>
