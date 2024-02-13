<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="NomeProgetto.Welcome" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome</h2>
            <div>
                <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
                <asp:Label ID="lblLoggedInUsername" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            </div>
        </div>
    </form>
</body>
</html>

