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
      <div class="form-group col-6">
            <asp:Label ID="lblExpedientes" runat="server" Text="Expedientes" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>

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
