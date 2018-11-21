<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="InicioDeSesion.aspx.cs" Inherits="UI.InicioDeSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container-fluid">
        <br />
        <br />
        <br />

        <div class="row justify-content-center">
            <asp:Label ID="lblInicioSesion" runat="server" Text="INICIO DE SESIÓN" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <br />
        <div class="row justify-content-center">
            <div class="form-group col-sm-5">
                <label for="txtId">Identificador</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="entrar">Espacio necesario</asp:RequiredFieldValidator>
                <asp:TextBox type="text" class="form-control" ID="txtId" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) {return false;}"></asp:TextBox>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="form-group col-sm-5">
                <label for="txtContra">Contraseña</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContra" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="entrar">Espacio necesario</asp:RequiredFieldValidator>
                <asp:TextBox type="text" class="form-control" ID="txtContra" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <br />
        <br />
        <div class="row justify-content-center">
            <asp:Button ID="btnEntrar" type="button" class="btn btn-info" runat="server" Text="Entrar" OnClick="entrarBtn_Click" ValidationGroup="entrar" />
        </div>

         <div class="row justify-content-center">
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Usuario o contraseña incorrecta"></asp:Label>
             </div>


    </div>
</asp:Content>
