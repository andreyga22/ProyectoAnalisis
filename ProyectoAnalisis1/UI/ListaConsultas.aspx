<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="ListaConsultas.aspx.cs" Inherits="UI.ListaConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item active" aria-current="page">Consultas</li>
        </ol>
    </nav>

    <div class="container">
        <br />
        <br />
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        <div class="row">

            <div class="offset-sm-5">
                <asp:Button ID="agregarBtn" type="button" class="btn btn-danger" runat="server" Text="Agregar" OnClick="agregarBtn_Click" />
            </div>
        </div>
        <br />
        <div class="table-responsive">
            <asp:GridView ID="listaConsultaGV" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="listaConsultaGV_SelectedIndexChanged"></asp:GridView>
        </div>
        <br />
        <asp:Table ID="TablaConsultas" runat="server">
        </asp:Table>
        <br />
        <br />
        <br />
    </div>

</asp:Content>
