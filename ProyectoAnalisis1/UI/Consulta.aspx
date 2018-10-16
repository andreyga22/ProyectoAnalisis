<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="UI.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <br />
        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Label ID="titulo" runat="server" Text="Consulta" Font-Bold="True" Font-Size="Larger"></asp:Label>
            </div>
            <div class="form-group col-sm-6">
                <asp:Label ID="fecha" runat="server" Text="15-10-2018" Font-Bold="True" Font-Size="Larger"></asp:Label>
            </div>
        </div>

        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Literal ID="fichaDoctor" runat="server"></asp:Literal>
            </div>
            <div class="form-group col-sm-6">
                <asp:Literal ID="fichaParam" runat="server"></asp:Literal>
            </div>
        </div>

        <div class="form-group">
                <label for="precioText">Precio de consulta</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="precioText" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-sm-6">
                <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" />
            </div>

        

        <br />
        <br />

        <br />

    </div>
</asp:Content>
