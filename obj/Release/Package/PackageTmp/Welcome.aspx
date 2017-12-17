<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="News.Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <link  href="Styles/MySite.css" type="text/css"  rel="Stylesheet"/>
</head>
<body class="WelcomePageBody">
    <form id="form1" runat="server">
   <div id="container"  runat="server"  class="center-div">
       
        <asp:Button ID="WhatsNewBtn"  runat="server" Text="Find Out!" OnClick="Search_Click"  CssClass="enterBtn"/>
        
    </div>
    </form>
</body>
</html>
