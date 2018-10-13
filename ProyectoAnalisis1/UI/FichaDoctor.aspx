<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="FichaDoctor.aspx.cs" Inherits="UI.HistorialClinico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="container">

        <br />
        <br />
        <br />

        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Ficha Doctor" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" />
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="motivoText">Motivo de la consulta</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="motivoText" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="examenText">Examen Fisico</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="examenText" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="planText">Plan</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="idText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="planText" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" />
        </div>


        <br />
        <br />
        <br />

    </div>


</asp:Content>
