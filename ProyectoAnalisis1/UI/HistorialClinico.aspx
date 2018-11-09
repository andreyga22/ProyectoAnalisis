<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="UI.HistorialClinico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <br />
        <br />
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Historial Clínico" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" />
        </div>

        <div class="form-row">
            <asp:Label ID="Label1" runat="server" Text="Antecedentes Personales Patológicos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />
        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="htaCheck" runat="server" Text="HTA" />
            </div>
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="dMCheck" runat="server" Text="DM" />
            </div>
        </div>
        <br />
        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="asmaCheck" runat="server" Text="Asma" />
            </div>
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="epilepsiaCheck" runat="server" Text="Epilepsia" />
            </div>
        </div>
        <br />
        <div class="form-row">
            <div class="form-group">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="displidemiaCheck" runat="server" Text="Displidemias" />
            </div>
        </div>

        <br />

        <br />
        <div class="form-group">
            <label for="cardiacaText">Enfermedades cardíacas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="psiquiatricasText">Enfermedades psiquiátricas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="psiquiatricasText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrasPatologicasText">Otras enfermedades personales patológicas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
        </div>

        <br />

        <div class="form-row">
            <asp:Label ID="Label2" runat="server" Text="Antecedentes Personales No Patológicos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="licorCheck" runat="server" Text="Licor" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="drogasCheck" runat="server" Text="Drogas" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="fumaCheck" runat="server" Text="Fuma" />
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="alergiasText">Alergias</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="alergiasText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrasPatologicasText">Otras enfermedades personales no patológicas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrasPatologicasText" runat="server"></asp:TextBox>
        </div>


        <br />






        <div class="form-row">
            <asp:Label ID="Label3" runat="server" Text="Antecedentes Ginecobstétricos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>


        <br />


        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="menarcaCheck" runat="server" Text="Menarca" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="endometriosisCheck" runat="server" Text="Endometriósis" />
            </div>
        </div>

        <br />

        <div class="form-group">
            <label for="embarazos">Embarazos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="idText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="embarazosText" runat="server"></asp:TextBox>
        </div>




        <div class="form-group">
            <label for="abortosText">Abortos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="abortosText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="quistesOvaricosText">Quistes Ováricos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="quistesOvaricosText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrosGinecobstetricoText">Otras enfermedades ginecobstetricos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="cantonText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrosGinecobstetricoText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group offset-md-4 col-sm-4">
            <label for="furText">FUR</label>
            <asp:Calendar ID="furText" runat="server"></asp:Calendar>
        </div>


        <br />




        <div class="form-row">
            <asp:Label ID="Label4" runat="server" Text="Antecedentes Quirúrgicos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />
        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="cordalesCheck" runat="server" Text="Cordales" />
            </div>
            <div class="form-group col-sm-6">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="apendiceCheck" runat="server" Text="Apéndice" />
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="fracturasText">Fracturas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="religionText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="fracturasText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="vesiculaText">Vesícula</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="estadoCivilText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="vesiculaText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="litiasisText">Litiásis</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="litiasisText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="columnaText">Columna</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="columnaText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrosQuirugicosText">Otros Quirugicos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrosQuirugicosText" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="form-row">
            <asp:Label ID="Label5" runat="server" Text="Antecedentes Heredo - Familiares" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />
        <div class="form-group">
            <label for="dMFamText">DM Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="dMFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="HTAFamText">HTA Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="HTAFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="asmaFamText">Asma Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="asmaFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="cancerFamText">Cancer Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="cancerFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="epilepsiaFamText">Epilepsia Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="epilepsiaFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="demenciasFamText">Demencias Familiar</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="demenciasFamText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="psicofamiliaresText">Enfermedades Psicofamiliares</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="psicofamiliaresText" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="otrosFamText">Otras enfermedades Familiares</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrosFamText" runat="server"></asp:TextBox>
        </div>

        <br />
        <div class="form-row">
            <asp:Label ID="Label6" runat="server" Text="Medicamentos" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
        <br />
        <div class="form-group">
            <label for="medicamentosText">Medicamentos actuales</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="distritoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="medicamentosText" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="otrosMedicamentosText">Explicación medicamentos</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="otrasText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrosMedicamentosText" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>

    <br />





    <div class="form-group offset-sm-6">
        <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" />
    </div>

    <br />
    <br />
    <br />

    </div>

</asp:Content>
