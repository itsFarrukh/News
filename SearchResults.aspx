<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs"
    Inherits="News.SearchResults" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/MySite.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 100%">
        <div style="float: left; width: 60%">
            <h1>
                Articles about Trump
            </h1>
            <br />
            <asp:Repeater ID="Results" runat="server">
                <HeaderTemplate>
                    <ol class="simple-list">
                </HeaderTemplate>
                <ItemTemplate>
                    <li><a id="A1" href='<%# Eval("Url") %>' runat="server">
                        <%# DataBinder.Eval(Container.DataItem, "Title")%></a> </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ol>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <div class="verticalLine">
        </div>
        <div style="float: right; width: 40%;">
            <h1>
                Tweets of Donald Trump</h1>
            <br />
            <asp:Repeater ID="TweetsRepeater" runat="server">
                <HeaderTemplate>
                    <ol class="simple-list">
                </HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <p>
                            <%# Eval("Text") %></p>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ol>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
    </form>
</body>
</html>
