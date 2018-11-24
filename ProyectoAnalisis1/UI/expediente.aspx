<%@ Page Title="Expediente" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="expediente.aspx.cs" Inherits="UI.expediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item active" aria-current="page">Expediente</li>
        </ol>
    </nav>


    <div class="container">

        <br />
        <br />
        <br />
        <div class="form-row">
            <div class="form-group col-sm-11">
                <asp:Button ID="ultimaBtn" type="button" class="btn btn-info" runat="server" Text="Ultima Consulta" OnClick="ultimaBtn_Click" />
                <asp:Button type="button" class="btn btn-light" ID="btnHistorialClinico" runat="server" OnClick="btnHistorialClinico_Click" Text="Historial Clínico" />
 
            </div>
            <div class="form-group col-sm-1">
                <asp:Button type="button" class="btn btn-light" ID="historialBtn" runat="server" Text="Consultas" OnClick="historialBtn_Click" />
            </div>
        </div>
        <br />

        <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red" Visible="False"></asp:Label>
        <br />

        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Datos Personales" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
            <br />
            <br />
            <br />
        </div>

        <%--<div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" OnClick="modificarBtn_Click" />
        </div>--%>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="firstNameText">Primer Nombre</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Únicamente letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="guardar" ForeColor="#FF3131"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="firstNameText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}" ></asp:TextBox>

            </div>
            <div class="form-group col-sm-6">
                <label for="secondNameText">Segundo Nombre</label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Únicamente letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="guardar" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="secondNameText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
        </div>
        <%--<div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Label ID="firstNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-6">
                <asp:Label ID="secondNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>--%>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="lastNameText">Primer Apellido</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Únicamente letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="guardar" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="lastNameText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>
            <div class="form-group col-sm-6">
                <label for="lastNameText2">Segundo Apellido</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="lastNameText2" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="secondNameText" ErrorMessage="Únicamente letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+" ValidationGroup="guardar" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="lastNameText2" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>
        </div>

        <%--<div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Label ID="lastNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-6">
                <asp:Label ID="lastNameLabel2" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>--%>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="idText">Cédula</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="idText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox type="text" class="form-control" ID="idText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
            </div>
            <div class="form-group col-sm-6">
                <label for="edadTxt">Edad</label>
                <br />
                <asp:TextBox type="text" class="form-control" ID="txtEdad" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" Enabled="False"></asp:TextBox>
            </div>
        </div>

        <%--<div class="form-group">
            <asp:Label ID="idLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>


        <div class="form-group">
            <label for="phoneText">Teléfono</label>
            <asp:TextBox type="text" class="form-control" ID="phoneText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="tel2">Teléfono 2</label>
            <asp:TextBox type="text" class="form-control" ID="tel2" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="descripcionTel2">Descripción teléfono 2</label>
            <asp:TextBox type="text" class="form-control" ID="descripcionTel2" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="tel2">Teléfono 3</label>
            <asp:TextBox type="text" class="form-control" ID="tel3" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="descripcionTel3">Descripción teléfono 3</label>
            <asp:TextBox type="text" class="form-control" ID="descripcionTel3" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Dirección"></asp:Label>
        </div>

        <%--<div class="form-group">
            <asp:Label ID="phoneLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>
        <div>
            <div class="form-row">
                <div class="form-group col-sm-4">
                    <label for="provinciaText">Provincia</label>
                    <asp:TextBox type="text" class="form-control" ID="provinciaText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>
                <div class="form-group col-sm-4">
                    <label for="cantonText">Cantón</label>
                    <asp:TextBox type="text" class="form-control" ID="cantonText" runat="server" OnTextChanged="cantonText_TextChanged" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>
                <div class="form-group col-sm-4">
                    <label for="distritoText">Distrito</label>
                    <asp:TextBox type="text" class="form-control" ID="distritoText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>
            </div>

            <%--<div class="form-row">
            <div class="form-group col-sm-4">
                <asp:Label ID="provinciaLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="cantonLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="distritoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>--%>

            <div class="form-group ">
                <label for="otrasText">Otras Señas</label>
                <asp:TextBox type="text" class="form-control" ID="otrasText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>

            </div>

            <%--<div class="form-group">
            <asp:Label ID="otrasLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>
            <div>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Fecha de Nacimiento"></asp:Label>
            </div>
            <div class="form-row">
                <div class="form-group col-sm-4">
                    <label for="diaText">Día</label><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="diaText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="diaText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardar">Únicamente números</asp:RegularExpressionValidator>
                    &nbsp;<asp:TextBox type="text" class="form-control" ID="diaText" runat="server" MaxLength="2" BorderColor="#16ACB8" BorderStyle="Solid" OnTextChanged="diaText_TextChanged" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>

                <div class="form-group col-sm-4">
                    <label for="mesText">Mes</label><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="mesText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<label for="mesText"><asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="mesText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardar">Únicamente números</asp:RegularExpressionValidator>
                    </label>
                    <asp:TextBox type="text" class="form-control" ID="mesText" runat="server" MaxLength="2" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>
                <div class="form-group col-sm-4">
                    <label for="annoText">Año</label><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="AnnoText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="AnnoText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\d*\.?\d*" ValidationGroup="guardar">Únicamente números</asp:RegularExpressionValidator>
                    <asp:TextBox type="text" class="form-control" ID="AnnoText" runat="server" MaxLength="4" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

                </div>
            </div>

            <%--<div class="form-row">
            <div class="form-group col-sm-4">
                <asp:Label ID="diaLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="mesLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="AnnoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>--%>

            <div class="form-group">
                <label for="religionText">Religión</label>
                <asp:TextBox type="text" class="form-control" ID="religionText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>

            <%--<div class="form-group">
            <asp:Label ID="religionLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>

            <div class="form-group">
                <label for="estadoCivilText">Estado Civil</label>
                <asp:TextBox type="text" class="form-control" ID="estadoCivilText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>

            <%--<div class="form-group">
            <asp:Label ID="estadoCivilLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>

            <div class="form-group">
                <label for="trabajoText">Tipo de trabajo</label>
                <asp:TextBox type="text" class="form-control" ID="trabajoText" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" onkeypress="if (event.keyCode == 13) { return false;}"></asp:TextBox>

            </div>

            <%--<div class="form-group">
            <asp:Label ID="trabajoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>

            <div class="form-group col-sm-4">
                <label for="sexoText">Sexo</label>
                <asp:DropDownList ID="sexoText" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" runat="server">
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>F</asp:ListItem>
                </asp:DropDownList>

            </div>

            <%--<div class="form-group">
            <asp:Label ID="sexoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>--%>

            <div class="form-group offset-sm-6">
                <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="guardar" />
            </div>
        </div>
        <br />


        <br />
        <br />
        <br />
</asp:Content>
