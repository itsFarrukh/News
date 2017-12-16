﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="News.SearchResults" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="Results" runat="server">
    
    <ItemTemplate>
    <h3><a href='<%# Eval("Url") %>' runat="server"><%# DataBinder.Eval(Container.DataItem, "Title")%></a></h3>
    </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
