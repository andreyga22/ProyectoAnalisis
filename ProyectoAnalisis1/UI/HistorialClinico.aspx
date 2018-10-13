<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="UI.HistorialClinico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <br />
        <br />
        <br />

        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Historial Clínico" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" />
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="htaCheck" runat="server" Text="HTA" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="dMCheck" runat="server" Text="DM" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="asmaCheck" runat="server" Text="Asma" />
            </div>
        </div>

        <br />

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="epilepsiaCheck" runat="server" Text="Epilepsia" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="displidemiaCheck" runat="server" Text="Displidemias" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="fumaCheck" runat="server" Text="Fuma" />
            </div>
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
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="menarcaCheck" runat="server" Text="Menarca" />
            </div>
        </div>

        <br />

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="endometriosisCheck" runat="server" Text="Endometriósis" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="cordalesCheck" runat="server" Text="Cordales" />
            </div>
            <div class="form-group col-sm-4">
                <asp:CheckBox class="form-check-input" type="checkbox" value="" ID="apendiceCheck" runat="server" Text="Apéndice" />
            </div>
        </div>

        <br />

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="firstNameText">Primer nombre</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="firstNameText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="secondNameText">Segundo nombre</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="secondNameText" runat="server"></asp:TextBox>
            </div>

        </div>
        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="lastNameText">Primer apellido</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="lastNameText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="lastNameText2">Segundo apellido</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="lastNameText2" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="idText">Cedula</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="idText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="idText" runat="server"></asp:TextBox>
        </div>




        <div class="form-group">
            <label for="phoneText">Telefono</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phoneText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="phoneText" runat="server"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <label for="provinciaText">Provincia</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="provinciaText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <label for="cantonText">Canton</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="cantonText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="cantonText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <label for="distritoText">Distrito</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="distritoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="distritoText" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-sm-4">
                <label for="otrasText">Otras Señas</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="otrasText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="otrasText" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group offset-md-4 col-sm-4">
            <label for="fechaNacimiento">Fecha de Nacimiento</label>
            <asp:Calendar ID="fechaNacimiento" runat="server"></asp:Calendar>
        </div>

        <div class="form-group">
            <label for="religionText">Religion</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="religionText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="religionText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="estadoCivilText">Estado Civil</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="estadoCivilText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="estadoCivilText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="trabajoText">Tipo de trabajo</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
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
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" />
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
