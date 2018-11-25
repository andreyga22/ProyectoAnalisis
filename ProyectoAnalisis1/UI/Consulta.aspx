<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="UI.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item"><a href="ListaConsultas.aspx">Lista Consultas</a></li>
            <li class="breadcrumb-item active" aria-current="page">Consulta</li>
        </ol>
    </nav>

    <div class="container">

        <br />
        <br />
        <br />
        <%--<asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red" Visible="False"></asp:Label>--%>
        <asp:Literal ID="lblError" runat="server" Visible="false"></asp:Literal>
        <%--<div class="form-row">--%>
        <div class="form-group col-sm-6">
            <asp:Label ID="titulo" runat="server" Text="Consulta" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </div>
        <%--</div>--%>
        <div class="form-group col-sm-6">
            <asp:Label ID="fecha" runat="server" Text="15-10-2018" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">

                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="img/doctor.jpg" alt="Doctor">
                    <div class="card-body">
                        <h5 class="card-title">Ficha Doctor</h5>
                        <p class="card-text">Ficha con el formulario del doctor(a).</p>
                        <asp:Button ID="entrarDoctor" class="btn btn-primary" runat="server" Text="Entrar" OnClick="entrarDoctor_Click" />
                    </div>
                </div>
            </div>
            <div class="form-group col-sm-6">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="img/paramedicos.jpg" alt="Paramedicos">
                    <div class="card-body">
                        <h5 class="card-title">Ficha Paramédicos</h5>
                        <p class="card-text">Ficha con el formulario del paramédico(a).</p>
                        <asp:Button ID="entrarParamedico" class="btn btn-primary" runat="server" Text="Entrar" OnClick="entrarParamedico_Click" />
                    </div>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label for="precioText">Precio de consulta</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="precioText" ErrorMessage="**Solo números permitidos en este campo**" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarPrecioVal"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="priceFieldRequiredValidator" runat="server" ControlToValidate="precioText" ErrorMessage="**Información incompleta**" ForeColor="Red" ValidationGroup="guardarPrecioVal"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox type="text" class="form-control" ID="precioText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group col-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="guardarPrecioVal" />
        </div>



        <br />
        <br />

        <br />

    </div>
</asp:Content>
