<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarContenedor.aspx.cs" Inherits="TrashBoatASP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingresar IdContenedor: "></asp:Label>
    <asp:TextBox ID="txtIdContenedor" runat="server" TextMode="SingleLine"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvIdContenedor" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtIdContenedor"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revIdContenedor" ControlToValidate="txtIdContenedor" ValidationExpression="^[0-9]{15}$" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre Clave: "></asp:Label>
    <asp:TextBox ID="txtNombreClave" runat="server" TextMode="SingleLine"  ></asp:TextBox>
    <asp:RegularExpressionValidator ID="revTxtNombre" ControlToValidate="txtNombreClave" ValidationExpression="^[a-zA-Z]{5,10}$" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="rfvTxtNombreClave" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtNombreClave"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Capacidad Total: "></asp:Label>
    <asp:TextBox ID="txtCapacidadTotal" runat="server" ToolTip="Debe Ingresar 3 digitos seguido de . mas dos digitos"   TextMode="SingleLine"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvCapicidadTotal" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtCapacidadTotal"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revCapacidadTotal"  ControlToValidate="txtCapacidadTotal" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]{3}\.[0-9]{2}$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Capacidad Actual: "></asp:Label>
    <asp:DropDownList ID="ddlCapacidadActual" runat="server">
        <asp:ListItem Value="0.1">10%</asp:ListItem>
        <asp:ListItem Value="0.2">20%</asp:ListItem>
        <asp:ListItem Value="0.3">30%</asp:ListItem>
        <asp:ListItem Value="0.4">40%</asp:ListItem>
        <asp:ListItem Value="0.5">50%</asp:ListItem>
        <asp:ListItem Value="0.6">60%</asp:ListItem>
        <asp:ListItem Value="0.7">70%</asp:ListItem>
        <asp:ListItem Value="0.8">80%</asp:ListItem>
        <asp:ListItem Value="0.9">90%</asp:ListItem>
        <asp:ListItem Value="1">100%</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnIngresarContenedor" runat="server" Text="Agregar" OnClick="btnIngresarContenedor_Click" />
</asp:Content>
