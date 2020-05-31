<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarContenedor.aspx.cs" Inherits="TrashBoatASP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingresar IdContenedor: "></asp:Label>
    <asp:TextBox ID="txtIdContenedor" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nivel Llenado: "></asp:Label>
    <asp:TextBox ID="txtNivelLlenado" runat="server" TextMode="number" ></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Ultima Descarga: "></asp:Label>
    <asp:TextBox ID="txtUltimaDescarga" runat="server" TextMode="Date"  ></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnIngresarContenedor" runat="server" Text="Submit" OnClick="btnIngresarContenedor_Click" />
</asp:Content>
