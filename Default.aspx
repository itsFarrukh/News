﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="News.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>
</head>
<body>
    <form id="Welcome" runat="server">
    <div style="width: 100%" runat="server">
        <asp:TextBox runat="server" ID="SearchText">Search</asp:TextBox>
        <asp:Button  runat="server" Text="Search" OnClick="Search_Click" />
        <asp:Label ID="Errorlabel" runat="server" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
