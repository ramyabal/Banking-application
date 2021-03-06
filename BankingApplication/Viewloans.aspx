﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewloans.aspx.cs" Inherits="BankingApplication.Viewloans" %>

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
 <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">View Loans<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
        <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
         <asp:DropDownList ID="AdminTasksdroDown" runat="server" style="margin-left: 552px" Height="31px" Width="142px">
            <asp:ListItem>view loan details</asp:ListItem>
            <asp:ListItem>Approve Loans</asp:ListItem>
            <asp:ListItem>ReviewDoc</asp:ListItem>
        </asp:DropDownList>
     <asp:Button ID="Button2" runat="server" Height="25px" OnClick="Button1_Click" Text="Submit" Width="68px" style="margin-left: 46px" />
        <br />
        <br />
        <br />
    <div>
    <asp:GridView ID="ViewLoansGrid" runat="server" AutoGenerateColumns="true" style="margin-left: 22px" Width="1294px" >
</asp:GridView>
       
    </div>
        </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
