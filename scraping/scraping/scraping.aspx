<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scraping.aspx.cs" Inherits="scraping.scraping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Output_Label"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="scrape" />
    
    </div>
    </form>
</body>
</html>
