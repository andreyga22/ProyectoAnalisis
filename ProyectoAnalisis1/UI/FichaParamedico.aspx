<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="FichaParamedico.aspx.cs" Inherits="UI.FichaParamedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">

        <br />
        <br />
        <br />

        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Ficha Paramédicos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" />
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="presionText">Presión Arterial</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="presionText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="temperaturaText">Temperatura</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <label for="presionText">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="temperaturaText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
                </label>
                <asp:TextBox type="text" class="form-control" ID="temperaturaText" runat="server"></asp:TextBox>
            </div>

        </div>
        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="estaturaText">Estatura</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="estaturaText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="estaturaText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="pesoText">Peso</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="pesoText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="pesoText" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="glicemiaText">Glicemia</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="idText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="glicemiaText" runat="server"></asp:TextBox>
        </div>


        <div class="form-group">
            <label for="oximetriaText">Oximetría</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="oximetriaText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="GlasgowText">Glasgow</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="GlasgowText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
            <asp:TextBox type="text" class="form-control" ID="GlasgowText" runat="server"></asp:TextBox> <label> /15 </label>
        </div>

        <div class="form-group">
            <label for="Frec_CardText">Frecuencia Cardíaca<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Frec_CardText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
            </label>
            &nbsp;<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%><asp:TextBox type="text" class="form-control" ID="Frec_CardText" runat="server"></asp:TextBox> <label> LPM </label>
        </div>

        <div class="form-group">
            <label for="Frec_RespText">Frecuencia Respiratoria<asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="Frec_RespText" ErrorMessage="Solo se permiten números" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarParam"></asp:RegularExpressionValidator>
            </label>
            &nbsp;<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%><asp:TextBox type="text" class="form-control" ID="Frec_RespText" runat="server"></asp:TextBox> <label> RPM </label>
        </div>

        <div class="form-group">
            <label for="PupilasText">Pupilas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="PupilasText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="PielText">Piel</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="PielText" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <label for="observacionesText">Observaciones de Doctor</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="observacionesText" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="form-group col-sm-4">
                <label for="notasParamText">Nota de paramédicos</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="NotasParamText" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" style="height: 40px" ValidationGroup="guardarParam" />
        </div>

        <br />
        <br />
        <br />

    </div>
</asp:Content>
