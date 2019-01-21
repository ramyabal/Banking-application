<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update1.aspx.cs" Inherits="BankingApplication.update1" %>
<!DOCTYPE html>
<html lang="en">
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
        width: 1206px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;"><asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
    <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
     <table style="width: 109%; height: 170px;">
            <tr style="text-align: center; ">
                <td class="auto-style1" style="text-align: center;">
                   Enter Account Number  <asp:TextBox ID="AccountNoText" runat="server"  Height="26px" Width="136px"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Height="29px" OnClick="Button1_Click" style="text-align: center; margin-left: 33px;" Text="Submit" />
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









