<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlBooks"  runat="server"></asp:DropDownList>
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
        </div>
        <div>
            <br />
            <table>
                <tr>
                    <th>Author:</th>
                    <td><asp:TextBox ID="tbAuthor" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Title:</th>
                    <td><asp:TextBox ID="tbTitle" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Genre:</th>
                    <td><asp:TextBox  ID="tbGenre" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Price:</th>
                    <td><asp:TextBox ID="tbPrice" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Publish Date:</th>
                    <td><asp:TextBox  ID="tbPDate" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Description:</th>
                    <td><asp:TextBox  ID="tbDescr" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
            </table>
        </div>
    </form>


</body>
</html>
