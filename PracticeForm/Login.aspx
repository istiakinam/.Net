<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PracticeForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Username</td>
                <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="Need Username"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPassword" ErrorMessage="Need Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CausesValidation ="False"/></td>
            </tr>
        </table>
    </div>    
    </form>
</body>
</html>
