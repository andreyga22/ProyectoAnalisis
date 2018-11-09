<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="PáginaPrincipal.aspx.cs" Inherits="UI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <br />
      <br />
         <div class="form-group offset-sm-4">
        <asp:Button type="button" class="btn btn-light" ID="btnNuevoExp" runat="server" Text="Crear Nuevo Expediente" OnClick="btnNuevoExp_Click" />
               <br />
             <br />
         </div>
     <div class="form-row">
         <div class="form-group col-sm-6">
         
               <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="lblBuscarCedula" runat="server" Text="Buscar por Cédula" Font-Bold="True"></asp:Label>
             <asp:TextBox ID="txtbusqCedula" runat="server"></asp:TextBox>

             <asp:Button ID="buscarCedula" runat="server" Text="Buscar" OnClick="buscarCedula_Click" />
              <br />
               <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="lblNoBusqCedula" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
            </div>
        

     <div class="form-group col-sm-6">
         
               <br />
              <asp:Label ID="lblBuscNombre" runat="server" Text="Buscar por Nombre" Font-Bold="True"></asp:Label>
             <asp:TextBox ID="txtbusqNombre" runat="server"></asp:TextBox>

             <asp:Button ID="buscarNombre" runat="server" Text="Buscar" OnClick="buscarNombre_Click" />
               <br />
               <br />
               <asp:Label ID="lblNoBusqNombre" runat="server" ForeColor="Red" Text="Expediente no encontrado"></asp:Label>
            </div>
         </div>
        <div class="container">
         <div class="table-responsive">
            <asp:GridView ID="tblBuscar" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="listaBusq_SelectedIndexChanged"></asp:GridView>
        </div>
            </div>
</asp:Content>
