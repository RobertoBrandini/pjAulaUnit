﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtSalarioAtual" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtAumento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblResposta" runat="server" Text="-"></asp:Label>
        <br />
        <asp:Label ID="lblResultado2" runat="server" Text="-"></asp:Label>
        <br />

        <asp:Button ID="btnCalcularSalario" runat="server" OnClick="btnCalcularSalario_Click" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
