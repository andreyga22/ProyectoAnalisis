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
                <asp:RequiredFieldValidator ID="priceFieldRequiredValidator" runat="server" ControlToValidate="precioText" ErrorMessage="**Informacion incompleta**" ForeColor="Red" ValidationGroup="guardarPrecioVal"></asp:RequiredFieldValidator>
                <asp:TextBox type="text" class="form-control" ID="precioText" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-sm-6">
                <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="guardarPrecioVal" />
            </div>

        

        <br />
        <br />

        <br />

    </div>
</asp:Content>
