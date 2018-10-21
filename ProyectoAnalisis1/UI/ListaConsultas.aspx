<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="ListaConsultas.aspx.cs" Inherits="UI.ListaConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <br />
        <br />
        <br />
        <div class="row">
            <div class="offset-sm-5">
                <asp:Button ID="agregarBtn" type="button" class="btn btn-danger" runat="server" Text="Agregar" />
            </div>
        </div>
        <br />
        <div class="table-responsive">
            <asp:GridView ID="listaConsultaGV" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="listaConsultaGV_SelectedIndexChanged"></asp:GridView>
        </div>
        <br />
        <br />
        <br />
    </div>

</asp:Content>
