<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="FichaDoctor.aspx.cs" Inherits="UI.HistorialClinico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="PaginaPrincipal.aspx">Principal</a></li>
            <li class="breadcrumb-item"><a href="expediente.aspx">Expediente</a></li>
            <li class="breadcrumb-item"><a href="ListaConsultas.aspx">Lista Consultas</a></li>
            <li class="breadcrumb-item"><a href="Consulta.aspx">Consulta</a></li>
            <li class="breadcrumb-item active" aria-current="page">Ficha Doctor</li>
        </ol>
    </nav>

    <div class="container">

        <br />
        <br />
        <%--<asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red" Visible="False"></asp:Label>--%>
        <asp:Literal ID="lblError" runat="server" Visible="false"></asp:Literal>
        <br />
        <div class="form-row">
            <asp:Label ID="titulo" runat="server" Text="Ficha Doctor" Font-Bold="True" Font-Size="XX-Large" ForeColor="#16ACB8"></asp:Label>
        </div>

        <div class="form-row">
            <asp:Label ID="lblEmpleado" runat="server" Text="Label" Font-Bold="True"></asp:Label>
        </div>
        <br />
        <br />
        <br />

        <div class="form-group">
            <label for="motivoText">Motivo de la consulta</label>
            <asp:TextBox type="text" class="form-control" ID="motivoText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="examenText">Examen Físico</label>
            <asp:TextBox type="text" class="form-control" ID="examenText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="planText">Plan</label>
            <asp:TextBox type="text" class="form-control" ID="planText" runat="server" TextMode="MultiLine" BorderColor="#16ACB8" BorderStyle="Solid"></asp:TextBox>
        </div>

        <br />

        <div class="form-group col-sm-6">
            <label for="linkImg">Foto 1</label>
            <asp:LinkButton ID="linkImg" data-toggle="modal" data-target="#exampleModal" runat="server">
                <asp:Image ID="image" runat="server" Visible="False" Height="25%" Width="25%" />
            </asp:LinkButton>
            <asp:FileUpload ID="foto" runat="server" AllowMultiple="False" />
        </div>

        <br />
        <br />
        <div class="form-group col-sm-6">
            <label for="linkImg2">Foto 2</label>
            <asp:LinkButton ID="linkImg2" data-toggle="modal" data-target="#exampleModal2" runat="server">
                <asp:Image ID="image3" runat="server" Visible="False" Height="25%" Width="25%" />
            </asp:LinkButton>
            <asp:FileUpload ID="foto2" runat="server" AllowMultiple="False" />
        </div>


        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg" role="img">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row row justify-content-center">
                            <asp:Image ID="image2" Height="90%" Width="90%" runat="server" ImageAlign="Middle" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel2" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg" role="img">
                <div class="modal-content">
                    <div class="modal-header">
                        <%--<h5 class="modal-title" id="exampleModalLabel">Modal title</h5>--%>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row row justify-content-center">
                            <%--<div class="col-sm-12">--%>
                            <asp:Image ID="image4" Height="90%" Width="90%" runat="server" ImageAlign="Middle" />
                            <%--</div>--%>
                        </div>
                    </div>
                    <%--<div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                            <%--<button type="button" class="btn btn-primary">Save changes</button>--%>
                </div>
            </div>
        </div>




        <%--<asp:Image ID="image" runat="server" Visible="False" Height="200" Width="200" />--%>


        <div class="form-group offset-sm-6">
            <asp:Button ID="guardarBtn" type="button" class="btn btn-danger" runat="server" Text="Guardar" OnClick="guardarBtn_Click" />
        </div>


        <br />
        <br />
        <br />

    </div>


</asp:Content>
