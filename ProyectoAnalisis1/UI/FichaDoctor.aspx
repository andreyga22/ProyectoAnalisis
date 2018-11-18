<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="FichaDoctor.aspx.cs" Inherits="UI.HistorialClinico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item"><a href="ListaConsultas.aspx">Lista Consultas</a></li>
            <li class="breadcrumb-item"><a href="Consulta.aspx">Consulta</a></li>
            <li class="breadcrumb-item active" aria-current="page">Ficha Doctor</li>
        </ol>
    </nav>

    <div class="container">

        <br />
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Ficha Doctor" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>

        <div class="form-row">
            <asp:Label ID="lblEmpleado" runat="server" Text="Label" Font-Bold="True"></asp:Label>
        </div>
        <br />
        <br />
        <br />

        <div class="form-group">
            <label for="motivoText">Motivo de la consulta</label>
            <asp:TextBox type="text" class="form-control" ID="motivoText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="examenText">Examen Físico</label>
            <asp:TextBox type="text" class="form-control" ID="examenText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="planText">Plan</label>
            <asp:TextBox type="text" class="form-control" ID="planText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>



        <div class="form-group">
            <asp:Image ID="image" runat="server" Visible="False" Height="200" Width="200" />
            <label for="foto">Foto</label>
            <asp:FileUpload ID="foto" runat="server" />
        </div>

        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" />
        </div>


        <br />
        <br />
        <br />

    </div>


</asp:Content>
