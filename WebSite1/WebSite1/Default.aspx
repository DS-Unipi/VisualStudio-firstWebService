<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body> 
    <form id="forml" runat="server"> 
        <div> 
            <div> 
                <asp:Label ID="lb1Number1" runat="server" Text="Number1:"></asp:Label>
                 <asp:TextBox ID="tbNumber1" runat="server"></asp:TextBox>
                   <asp:Label ID="lb1Number2" runat="server" Text="Number2:"></asp:Label> 
                    <asp:TextBox ID="tbNumber2" runat="server"></asp:TextBox> 

            </div> 
            <div> 
                <asp:Label ID="lblOperation" runat="server" Text="Math Operation:"></asp:Label> 
                <asp:DropDownList ID="ddlOperation" runat="server"> 
                    <asp:ListItem Text="+" Value="add"></asp:ListItem> 
                    <asp:ListItem Text="-" Value="sub"></asp:ListItem> 
                    <asp:ListItem Text="*" Value="mul"></asp:ListItem> 
                    <asp:ListItem Text="/" Value="div"></asp:ListItem> 
               </asp:DropDownList> 
            </div> 
            <div> 
                <asp:Button ID="btnCa11WS" runat="server" Text=" = " OnClick="btnCallWS_Click" /> 

            </div> 
            <div> 
                <asp:Label ID="lblResultTitle" runat="server" Text="Result:"></asp:Label>
                 <asp:Label ID="lblResult" runat="server" Text=""></asp:Label> 

            </div>

        </div>

    </form>

</body>

</html>
