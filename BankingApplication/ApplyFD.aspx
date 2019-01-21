<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyFD.aspx.cs" Inherits="BankingApplication.ApplyFD" %>

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
   
    .auto-style5 {
        width: 83px;
    }
    .auto-style6 {
        width: 579px;
    }
    .auto-style7 {
        width: 579px;
        height: 73px;
    }
    .auto-style8 {
        width: 83px;
        height: 73px;
    }
    .auto-style9 {
        height: 73px;
    }
   
</style>
</head>
<body>
    <form id="form1" runat="server">
   <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">Apply Fixed Deposit<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
   <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />    
   <table style="width: 100%; height: 132px;">
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Amount</td>
                <td class="auto-style9">
                <asp:TextBox ID="AmountText" runat="server" Height="21px" Width="127px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Height="25px" style="margin-left: 9px" Text="Apply" Width="64px" OnClick="Button2_Click" />
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
