<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="expediente.aspx.cs" Inherits="UI.expediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <br />
        <br />
        <br />

        <div class="form-row">
            <div class="form-group col-sm-11">
                <asp:Button ID="ultimaBtn" type="button" class="btn btn-info" runat="server" Text="Ultima Consulta" OnClick="ultimaBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button type="button" class="btn btn-light" ID="btnHistorialClinico" runat="server" OnClick="btnHistorialClinico_Click" Text="Historial Clínico" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            <div class="form-group col-sm-1">
                <asp:Button type="button" class="btn btn-light" ID="historialBtn" runat="server" Text="Consultas" OnClick="historialBtn_Click" />
            </div>
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Datos Personales" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>

        <div class="form-group offset-sm-11">
            <asp:Button type="button" class="btn btn-light" ID="modificarBtn" runat="server" Text="Modificar" OnClick="modificarBtn_Click" />
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="firstNameText">Primer Nombre</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="firstNameText" ErrorMessage="Únicamente letras" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="guardar"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="firstNameText" runat="server"></asp:TextBox>

            </div>
            <div class="form-group col-sm-6">
                <label for="secondNameText">Segundo Nombre</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="secondNameText" ErrorMessage="Únicamente letras" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="guardar"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="secondNameText" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Label ID="firstNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-6">
                <asp:Label ID="secondNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <label for="lastNameText">Primer Apellido</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastNameText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="lastNameText" ErrorMessage="Únicamente letras" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="guardar"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="lastNameText" runat="server"></asp:TextBox>
                
            </div>
            <div class="form-group col-sm-6">
                <label for="lastNameText2">Segundo Apellido</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="lastNameText2"></asp:RequiredFieldValidator>--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="lastNameText2" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="secondNameText" ErrorMessage="Únicamente letras" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="guardar"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" class="form-control" ID="lastNameText2" runat="server"></asp:TextBox>
                
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-6">
                <asp:Label ID="lastNameLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-6">
                <asp:Label ID="lastNameLabel2" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <label for="idText">Cédula</label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="idText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            <asp:TextBox type="text" class="form-control" ID="idText" runat="server"></asp:TextBox>
            
        </div>

        <div class="form-group">
                <asp:Label ID="idLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>


        <div class="form-group">
            <label for="phoneText">Teléfono</label>
            <asp:TextBox type="text" class="form-control" ID="phoneText" runat="server"></asp:TextBox>
            
        </div>

        <div class="form-group">
                <asp:Label ID="phoneLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <label for="provinciaText">Provincia</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="provinciaText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="provinciaText" runat="server"></asp:TextBox>
                
            </div>
            <div class="form-group col-sm-4">
                <label for="cantonText">Cantón</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="cantonText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="cantonText" runat="server" OnTextChanged="cantonText_TextChanged"></asp:TextBox>
                
            </div>
            <div class="form-group col-sm-4">
                <label for="distritoText">Distrito</label>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="distritoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
                <asp:TextBox type="text" class="form-control" ID="distritoText" runat="server"></asp:TextBox>
                
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:Label ID="provinciaLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="cantonLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="distritoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>

        <div class="form-group ">
            <label for="otrasText">Otras Señas</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="otrasText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="otrasText" runat="server" TextMode="MultiLine"></asp:TextBox>
            
        </div>

        <div class="form-group">
                <asp:Label ID="otrasLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <label for="diaText">Día</label><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="diaText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                &nbsp;<asp:TextBox type="text" class="form-control" ID="diaText" runat="server"> </asp:TextBox>
                
            </div>

            <div class="form-group col-sm-4">
                <label for="mesText">Mes</label><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="mesText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                &nbsp;<asp:TextBox type="text" class="form-control" ID="mesText" runat="server"> </asp:TextBox>
                
            </div>
            <div class="form-group col-sm-4">
                <label for="annoText">Año</label><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="AnnoText" ErrorMessage="Campo obligatorio" ValidationGroup="guardar"></asp:RequiredFieldValidator>
                &nbsp;<asp:TextBox type="text" class="form-control" ID="AnnoText" runat="server"> </asp:TextBox>
                
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-4">
                <asp:Label ID="diaLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="mesLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
            <div class="form-group col-sm-4">
                <asp:Label ID="AnnoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <label for="religionText">Religión</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="religionText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="religionText" runat="server"></asp:TextBox>
            
        </div>

        <div class="form-group">
              <asp:Label ID="religionLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-group">
            <label for="estadoCivilText">Estado Civil</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="estadoCivilText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="estadoCivilText" runat="server"></asp:TextBox>
            
        </div>

        <div class="form-group">
              <asp:Label ID="estadoCivilLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-group">
            <label for="trabajoText">Tipo de trabajo</label>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="trabajoText" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>--%>
            <asp:TextBox type="text" class="form-control" ID="trabajoText" runat="server"></asp:TextBox>
            
        </div>

        <div class="form-group">
              <asp:Label ID="trabajoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-group col-sm-4">
            <label for="sexoText">Sexo</label>
            <asp:DropDownList ID="sexoText" class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown" runat="server">
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
            </asp:DropDownList>
            
        </div>

        <div class="form-group">
              <asp:Label ID="sexoLabel" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
        </div>

        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" ValidationGroup="guardar" />
        </div>

        <br />


        <br />
        <br />
        <br />

    </div>
</asp:Content>
