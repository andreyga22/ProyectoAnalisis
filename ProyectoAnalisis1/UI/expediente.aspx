<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="expediente.aspx.cs" Inherits="UI.expediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <br />
        <br />
        <br />

        <div class="form-row">
            <asp:Button ID="hoyBtn" type="button" class="btn btn-info" runat="server" Text="Hoy" />
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Datos Personales" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" />
        </div>

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
        <div class="form-group offset-md-4 col-sm-4">
            <label for="fechaNacimiento">Distrito</label>
            <asp:Calendar ID="fechaNacimiento" runat="server"></asp:Calendar>
        </div>
        <div class="form-group">
            <label for="religionText">Religion</label>
            <asp:TextBox type="text" class="form-control" ID="religionText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="estadoCivilText">Estado Civil</label>
            <asp:TextBox type="text" class="form-control" ID="estadoCivilText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="trabajoText">Tipo de trabajo</label>
            <asp:TextBox type="text" class="form-control" ID="trabajoText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group col-sm-4">
            <label for="sexoText">Sexo</label>
            <asp:DropDownList ID="sexoText" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" runat="server">
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" />
        </div>

        <br />

        <div class="form-row">
            <div class="form-group col-sm-10">
                <asp:Button type="button" class="btn btn-light" ID="historialBtn" runat="server" Text="Historial de consultas" />
            </div>
            <div class="form-group col-sm-2">
                <asp:Button type="button" class="btn btn-info" ID="agregarBtn" runat="server" Text="Agregar consulta" />
            </div>
        </div>

        <br />
        <br />
        <br />

    </div>
</asp:Content>
