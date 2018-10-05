<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="expediente.aspx.cs" Inherits="UI.expediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <br />
        <br />
        <br />

        <%--  <form>--%>
        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="firstNameText">Primer nombre</label>
                <asp:TextBox type="text" class="form-control" ID="firstNameText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="secondNameText">Segundo nombre</label>
                <asp:TextBox type="text" class="form-control" ID="secondNameText" runat="server"></asp:TextBox>
            </div>

        </div>
        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="lastNameText">Primer apellido</label>
                <asp:TextBox type="text" class="form-control" ID="lastNameText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="lastNameText2">Segundo apellido</label>
                <asp:TextBox type="text" class="form-control" ID="lastNameText2" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="idText">Cedula</label>
            <asp:TextBox type="text" class="form-control" ID="idText" runat="server"></asp:TextBox>
        </div>




        <div class="form-group">
            <label for="phoneText">Telefono</label>
            <asp:TextBox type="text" class="form-control" ID="phoneText" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <label for="provinciaText">Provincia</label>
                <asp:TextBox type="text" class="form-control" ID="provinciaText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <label for="cantonText">Canton</label>
                <asp:TextBox type="text" class="form-control" ID="cantonText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <label for="distritoText">Distrito</label>
                <asp:TextBox type="text" class="form-control" ID="distritoText" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="ageText">Edad</label>
            <asp:DropDownList ID="ageText" class="form-control" runat="server"></asp:DropDownList>
            <%--<select id="ageText" class="form-control">
                <option selected>23</option>
                <option>...</option>
            </select>--%>
        </div>

        <button type="submit" class="btn btn-primary">Submit</button>
        <%--</form>--%>
    </div>
</asp:Content>
