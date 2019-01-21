<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveFD.aspx.cs" Inherits="BankingApplication.ApproveFD" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="utf-8"/>
<title>Home Page</title>
<style type="text/css">
        /* Basics */
        html, body
        {
    background-color: #87CEEB;
}
       
    body{        
        padding-top: 60px;
        padding-bottom: 40px;
        width: 1301px;
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
        left: -1px;
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
        width: 163px;
    }
    .auto-style2 {
        width: 537px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">Approve FD<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
    <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
         <table style="width: 100%; height: 161px;">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"> Account_No 
                    </td>
                <td> 
                    <asp:TextBox ID="AccountNoText" runat="server" ReadOnly="true" Height="24px" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">Deposite_Amount
                    </td>
                <td class="auto-style5">
                    <asp:TextBox ID="DepositeAmountText" runat="server" ReadOnly="true" Height="24px" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" style="margin-left: 29px" Text="Aproove" OnClick="Button1_Click" Height="31px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
     <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
