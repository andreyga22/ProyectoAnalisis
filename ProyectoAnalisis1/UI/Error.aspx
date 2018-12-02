<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="UI.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group"></div>
    <asp:Label ID="Label1" runat="server" Text="El tiempo de sesión ha expirado" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
        </div>
</asp:Content>
