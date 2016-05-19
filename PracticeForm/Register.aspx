<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PracticeForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            height: 50px;
        }
        .auto-style2
        {
            height: 44px;
        }
        .auto-style3
        {
            height: 46px;
        }
        .auto-style4
        {
            height: 68px;
        }
        .auto-style5
        {
            height: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td class="auto-style1">Name</td>
            <td class="auto-style1"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Need Name"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Only alphabets are allowed" ValidationExpression="[a-z,A-Z]*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style2"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style2">
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="Must be more than 6" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Confirm Password</td>
            <td class="auto-style3"><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style3">
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Password mismatch"></asp:CompareValidator>
            </td>
        </tr>
          <tr>
            <td class="auto-style4">Gender</td>
            <td class="auto-style4">
                <asp:RadioButtonList ID="rbtLstGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rbtLstGender" ErrorMessage="Must input Gender"></asp:RequiredFieldValidator>
              </td>
        </tr>
        <tr>
            <td>Date of Birth</td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server" TextMode="Date" Height="22px"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDOB" ErrorMessage="Date invalid" Operator="LessThan" Type="Date"></asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" style="margin-bottom: 22px"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Must input proper email ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Contact</td>
            <td class="auto-style5"><asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td>
            <td class="auto-style5">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtContact" ErrorMessage="Must input proper contact" ValidationExpression="[0-9]{11}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
