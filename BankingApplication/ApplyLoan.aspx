<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyLoan.aspx.cs" Inherits="BankingApplication.ApplyLoan" %>

<!DOCTYPE html><html>
    <style>
        /* Basics */
        html, body
        {
    background-color: #87CEEB;
}
       </style>
<body style="height: 290px">
   <form id="form1" runat="server">
         <table style="width: 100%; height: 176px;">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"> Apply For Loans</td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">Select Loans
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="23px">
                        <asp:ListItem>Home Loans</asp:ListItem>
                        <asp:ListItem>Car Loans</asp:ListItem>
                        <asp:ListItem>Personal Loans</asp:ListItem>
                        <asp:ListItem>Two-Wheeler Loans</asp:ListItem>
                        <asp:ListItem>Education Loans</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">
                    Enter Amount
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="126px"></asp:TextBox>
                </td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" Height="25px" style="margin-left: 28px" Text="Apply" Width="78px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style8"></td>
            </tr>
        </table>
    </form>
</body>
</html>
