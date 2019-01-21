<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transfer.aspx.cs" Inherits="BankingApplication.Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="utf-8"/>
<title></title>
<style type="text/css">
        /* Basics */
        html, body
        {
    background-color: #87CEEB;
}
       
    body{        
        padding-top: 60px;
        padding-bottom: 40px;
    }
    .container{
        width: 80%;
        margin: 0 auto; /* Center the DIV horizontally */
    }
    .fixed-header, .fixed-footer{
        width: 103%;
        position: fixed;        
        background: #333;
        padding: 10px 0;
        color: #fff;
    }
    .fixed-header{
        top: 0;
    }
    .fixed-footer{
        bottom: 0;
        left: -12px;
        height: 19px;
    }    
    /* Some more styles to beutify this example */
    nav a{
        color: #fff;
        text-decoration: none;
        padding: 7px 25px;
        display: inline-block;
        width: 82px;
    }
    .container p{
        line-height: 200px; /* Create scrollbar to test positioning */
    }
   
    .auto-style1 {
        width: 146px;
    }
    .auto-style2 {
        width: 523px;
    }
   
    .auto-style3 {
        width: 523px;
        height: 53px;
    }
    .auto-style4 {
        width: 146px;
        height: 53px;
    }
    .auto-style5 {
        height: 53px;
    }
    .auto-style6 {
        width: 523px;
        height: 55px;
    }
    .auto-style7 {
        width: 146px;
        height: 55px;
    }
    .auto-style8 {
        height: 55px;
    }
    .auto-style9 {
        width: 523px;
        height: 52px;
    }
    .auto-style10 {
        width: 146px;
        height: 52px;
    }
    .auto-style11 {
        height: 52px;
    }
   
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">Amount Transfer<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
     <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />   
        <table style="width: 100%; height: 219px;">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"> From Account
                    </td>
                <td class="auto-style8">
                    <asp:TextBox ID="FromAccountText" runat="server" Height="24px" Width="129px" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">To Account
                    </td>
                <td class="auto-style5">
                    <asp:TextBox ID="ToAccountText" runat="server" Height="24px" Width="129px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10"> Amount
                    </td>
                <td class="auto-style11">
                    <asp:TextBox ID="AmountText" runat="server" Height="24px" Width="129px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Height="32px" style="margin-left: 16px; margin-bottom: 0px" Text="Submit" Width="73px" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
