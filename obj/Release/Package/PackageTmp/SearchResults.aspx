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
    <div class="container">
        <div class="leftdiv">
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
   
        <div class="rightdiv">
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
        <div class="btndiv">
        <asp:Button ID="CoolBtn" Text="I don't wanna read about trump anymore" runat="server" OnClick="CoolBtn_Click" CssClass="enterBtn" />
        
        </div>
    </div>
    </form>
</body>
</html>
