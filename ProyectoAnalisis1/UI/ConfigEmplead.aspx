<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="ConfigEmplead.aspx.cs" Inherits="UI.ConfigEmplead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="Principal.aspx">Principal</a></li>
            <li class="breadcrumb-item active" aria-current="page">Configuración</li>
        </ol>
    </nav>

    <div class="container-fluid">
        <br />
        <br />

        <div class="row justify-content-center">
            <asp:Label ID="lblConfigur" runat="server" Text="CONFIGURACIÓN DE LA CUENTA" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <br />


    </div>

    <div class="row justify-content-center">
        <div class="form-group col-sm-3">
            <label for="lblID">Identificador:</label>
            <asp:Label ID="id" runat="server" Text="Label"></asp:Label>
        </div>
         
        <div class="form-group col-sm-3">
            <label for="lblID">Rol:</label>
            <asp:Label ID="rol" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

   <br />
        
             <div class="row justify-content-center">
        
            <div class="form-group col-sm-3">
            <label for="lblContra">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" BorderColor="#16ACB8"></asp:TextBox>
        </div>
        <div class="form-group col-sm-3">
            <label for="lblContra">Contraseña:</label>
            <asp:TextBox ID="txtContra" runat="server" BorderColor="#16ACB8"></asp:TextBox>
        </div>
    </div>
       <br />
    <div class="row justify-content-center">
        <div class="form-group col-sm-3">
            <label for="lblEstado">Estado:</label>
            <asp:Label ID="estado" runat="server" Text="Label"></asp:Label>
        </div>
           <div class="form-group col-sm-3">
               </div>
            </div>
                 <div class="row justify-content-center">
            <asp:Button ID="btnConfig" type="button" class="btn btn-info" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="entrar" />
        </div>
</asp:Content>
