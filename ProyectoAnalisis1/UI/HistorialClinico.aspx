﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="UI.HistorialClinico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item active" aria-current="page">Historial Clínico</li>
        </ol>
    </nav>


    <div class="container">

        <br />
         <asp:Literal ID="lblMensaje" runat="server" Visible="false"></asp:Literal>
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Historial Clínico" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <br />
        <div class="form-row">
            <asp:Label ID="subGeneral" runat="server" Text="General" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="lblGrupoSanguineo" runat="server" Text="Grupo Sanguíneo"></asp:Label>
            <asp:TextBox ID="txtGrupoSanguineo" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="Label1" runat="server" Text="Antecedentes Personales Patológicos" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="container">
            <div class="form-row">
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="htaCheck" runat="server" Text="HTA" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="dMCheck" runat="server" Text="DM" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
            </div>
            <br />
            <br />
            <div class="form-row">
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="asmaCheck" runat="server" Text="Asma" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="epilepsiaCheck" runat="server" Text="Epilepsia" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
            </div>
            <br />
            <br />
            <div class="form-row">
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="displidemiaCheck" runat="server" Text="Displidemias" onkeypress="if (event.keyCode == 13) { return false;}" />
                </div>
            </div>
        </div>
        <br />

        <br />
        <div class="form-group">
            <label for="cardiacaText">Enfermedades cardíacas</label>
            <asp:TextBox type="text" class="form-control" ID="txtenfCardiacas" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="psiquiatricasText">Enfermedades psiquiátricas</label>
            <asp:TextBox type="text" class="form-control" ID="txtpsiquiatricas" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrasPatologicasText">Otras enfermedades personales patológicas</label>
            <asp:TextBox type="text" class="form-control" ID="txtOtraspatolog" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <br />

        <div class="form-row">
            <asp:Label ID="Label2" runat="server" Text="Antecedentes Personales No Patológicos" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="container">
            <div class="form-row">
                <div class="form-group col-sm-4">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="licorCheck" runat="server" Text="Licor" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-4">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="drogasCheck" runat="server" Text="Drogas" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-4">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="fumaCheck" runat="server" Text="Fuma" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="alergiasText">Alergias</label>
            <asp:TextBox type="text" class="form-control" ID="Textalergias" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrasPatologicasText">Otras enfermedades personales no patológicas</label>
            <asp:TextBox type="text" class="form-control" ID="TextotrasNoPatologicas" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="Label3" runat="server" Text="Antecedentes Ginecobstétricos" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="container">

            <div class="form-row">
                <div class="form-group col-sm-4">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="menarcaCheck" runat="server" Text="Menarca" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-4">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="endometriosisCheck" runat="server" Text="Endometriosis" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="embarazos">Embarazos</label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="embarazosText" ErrorMessage="Se permiten solo números" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarHist"></asp:RegularExpressionValidator>
            <asp:TextBox type="text" class="form-control" ID="embarazosText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="abortosText">Abortos</label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="abortosText" ErrorMessage="Se permiten solo números" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarHist"></asp:RegularExpressionValidator>
            <asp:TextBox type="text" class="form-control" ID="abortosText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="quistesOvaricosText">Quistes Ováricos</label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="quistesOvaricosText" ErrorMessage="Se permiten solo números" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardarHist"></asp:RegularExpressionValidator>
            <asp:TextBox type="text" class="form-control" ID="quistesOvaricosText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrosGinecobstetricoText">Otras enfermedades ginecobstétricos</label>
            <asp:TextBox type="text" class="form-control" ID="otrosGinecobstetricoText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="furCalend">FUR</label>
            <asp:TextBox type="text" class="form-control" ID="furCalend" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="Label4" runat="server" Text="Antecedentes Quirúrgicos" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="container">
            <div class="form-row">
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="cordalesCheck" runat="server" Text=" Cordales" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
                <br />
                <br />
                <div class="form-group col-sm-6">
                    <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="apendiceCheck" runat="server" Text="Apéndice" onkeypress="if (event.keyCode == 13) { return false;}"/>
                </div>
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="fracturasText">Fracturas</label>
            <asp:TextBox type="text" class="form-control" ID="fracturasText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="vesiculaText">Vesícula</label>
            <asp:TextBox type="text" class="form-control" ID="vesiculaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="litiasisText">Litiásis</label>
            <asp:TextBox type="text" class="form-control" ID="litiasisText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="columnaText">Columna</label>
            <asp:TextBox type="text" class="form-control" ID="columnaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrosQuirugicosText">Otros Quirúgicos</label>
            <asp:TextBox type="text" class="form-control" ID="otrosQuirugicosText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>
        <br />

        <div class="form-row">
            <asp:Label ID="Label5" runat="server" Text="Antecedentes Heredo - Familiares" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="form-group">
            <label for="dMFamText">DM Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="dMFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="HTAFamText">HTA Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="HTAFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="asmaFamText">Asma Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="asmaFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="cancerFamText">Cáncer Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="cancerFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="epilepsiaFamText">Epilepsia Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="epilepsiaFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="demenciasFamText">Demencias Familiar</label>
            <asp:TextBox type="text" class="form-control" ID="demenciasFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="psicofamiliaresText">Enfermedades Psicofamiliares</label>
            <asp:TextBox type="text" class="form-control" ID="psicofamiliaresText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrosFamText">Otras enfermedades Familiares</label>
            <asp:TextBox type="text" class="form-control" ID="otrosFamText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <br />
        <div class="form-row">
            <asp:Label ID="Label6" runat="server" Text="Medicamentos" Font-Bold="True" Font-Size="Larger" ForeColor="#16ACB8"></asp:Label>
        </div>
        <br />
        <div class="form-group">
            <label for="medicamentosText">Medicamentos actuales</label>
            <asp:TextBox type="text" class="form-control" ID="medicamentosText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrosMedicamentosText">Explicación medicamentos</label>
            <asp:TextBox type="text" class="form-control" ID="otrosMedicamentosText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>
        <br />
        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="guardarHist" />
        </div>
        <br />
        <br />
        <br />





    </div>

</asp:Content>
