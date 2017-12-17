<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssFeeds.aspx.cs" Inherits="News.RssFeeds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rss Feeds</title>
    <link href="Styles/MySite.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>
            Rss Feeds from CNN</h1>
            <br />
        <asp:Repeater ID="RssRepeater" runat="server">
            <HeaderTemplate>
                <ol class="simple-list">
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <h2>
                        <a id="feedlink" href='<%# Eval("Link") %>' runat="server">
                            <%# DataBinder.Eval(Container.DataItem, "Title")%></a>
                    </h2>
                    <h4>
                        <%# Eval("Description") %></h4>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ol>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
