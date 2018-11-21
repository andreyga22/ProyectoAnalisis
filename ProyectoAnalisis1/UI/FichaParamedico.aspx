<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="FichaParamedico.aspx.cs" Inherits="UI.FichaParamedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item"><a href="ListaConsultas.aspx">Lista Consultas</a></li>
            <li class="breadcrumb-item"><a href="Consulta.aspx">Consulta</a></li>
            <li class="breadcrumb-item active" aria-current="page">Ficha Paramédico</li>
        </ol>
    </nav>


    <div class="container">

        <br />
        <br />
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Ficha de Paramédico" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <asp:Label ID="lblEmpleado" runat="server" Text=""></asp:Label>


        <div class="form-group offset-sm-11">
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="presionText">Presión Arterial</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="presionText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="temperaturaText">Temperatura</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <label for="presionText">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="temperaturaText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                </label>
                <asp:TextBox type="text" class="form-control" ID="temperaturaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>

        </div>
        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="estaturaText">Estatura</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="estaturaText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="estaturaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="pesoText">Peso</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="pesoText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="pesoText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="imcText">IMC</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <%--<asp:TextBox type="text" class="form-control" ID="imcText"  runat="server" BorderColor="#16ACB8" BorderStyle="Solid" Enabled="False"></asp:TextBox>--%>
                <asp:TextBox type="text" class="form-control" ID="imcText"  runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}" Enabled="false"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="glicemiaText">Glicemia</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="idText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="glicemiaText" runat="server"  BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>

            <div class="form-group col-sm-6">
                <label for="oximetriaText">Oximetría</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="oximetriaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="GlasgowText">Glasgow/15</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="GlasgowText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="GlasgowText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>

            <div class="form-group col-sm-6">
                <label for="Frec_CardText">
                    Frecuencia Cardíaca<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Frec_CardText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                </label>
                &nbsp;<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%><asp:TextBox type="text" class="form-control" ID="Frec_CardText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="Frec_RespText">
                    Frecuencia Respiratoria<asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="Frec_RespText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam" ForeColor="Red"></asp:RegularExpressionValidator>
                </label>
                &nbsp;<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%><asp:TextBox type="text" class="form-control" ID="Frec_RespText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>

            <div class="form-group col-sm-6">
                <label for="PupilasText">Pupilas</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="PupilasText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="PielText">Piel</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="PielText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="observacionesText">Observaciones de Doctor</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <br />
                <asp:TextBox type="text" class="form-control" ID="observacionesText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
            </div>

            <div class="form-group col-sm-6">
                <label for="notasParamText">Nota de paramédicos</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="NotasParamText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
            </div>
        </div>

        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" Style="height: 40px" ValidationGroup="guardarParam" />
        </div>

        <br />
        <br />
        <br />

    </div>
</asp:Content>
