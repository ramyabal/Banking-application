<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="BankingApplication.Homepage" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
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
   
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -3px; height: 19px;">Welcome To Banking Application</div>
    <table style="text-align: center;">
    <tr >
    <td class="auto-style1" > 
    <br />
    <div style="text-align:center; width: 1355px;">
    <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 13px" Height="26px" Width="163px">
    <asp:ListItem>Customer</asp:ListItem>
    <asp:ListItem>Admin</asp:ListItem>
    </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
    <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button1_Click" style="margin-left: 0px" Text="Submit" Width="70px" /> 
        </div>
    </td>
    
    </tr> 
    </table>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>                            

