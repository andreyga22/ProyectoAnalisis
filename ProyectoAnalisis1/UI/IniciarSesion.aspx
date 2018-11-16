<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="UI.IniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Clinica T_Asiste | Expediente</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
</head>
<body>
    <form id="form1" runat="server">
         <nav class="navbar navbar-expand-lg navbar-light bg-info">
            <a class="navbar-brand" href="PaginaPrincipal.aspx">
                <img src="img/logo.png" height="50" class="d-inline-block align-top" alt="">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
                <%--<a class="navbar-brand" href="#">Hidden brand</a>--%>
            </div>
        </nav>


    <br />
             <br />
             <br />

         <div class="form-group offset-sm-4 border border-info " style="width: 390px">
               <%-- <div class="col-md-4 border border-info">--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblInicioSesion" runat="server" Text="INICIO DE SESIÓN" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>

                 <%--</div>--%>       <%--  <div class="form-group offset-sm-4">--%>
            <br />
             <br />
             <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblId" runat="server" Text="Identificador:"></asp:Label>
&nbsp;
             <asp:TextBox ID="txtId" runat="server" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
             <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="entrar">Espacio necesario</asp:RequiredFieldValidator>
               <br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblContra" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtContra" runat="server" BorderColor="#16ACB8" BorderStyle="Solid" TextMode="Password"></asp:TextBox>
             <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContra" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ValidationGroup="entrar">Espacio necesario</asp:RequiredFieldValidator>
              <br />
              <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="btnEntrar" type="button" class="btn btn-info" runat="server" Text="Entrar" OnClick="entrarBtn_Click" ValidationGroup="entrar" />
              <br />
              <br />
            

            <%--</div>--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Usuario o contraseña incorrecta"></asp:Label>
        </div>



    </form>



</body>
</html>