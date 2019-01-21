<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admintasks.aspx.cs" Inherits="BankingApplication.Admintasks" %>

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
        width: 138px;
    }
    .auto-style2 {
        width: 565px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">Admin Tasks<asp:Button ID="LogoutBtn" runat="server" OnClick="Button5_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
                </div>
     <table style="width: 100%; height: 156px;">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"><br />
                    <asp:DropDownList ID="AdminTasksDropDown" runat="server" style="margin-left: 0px" Height="22px" Width="160px">
                        <asp:ListItem>Create account</asp:ListItem>
                        <asp:ListItem>Update/View account</asp:ListItem>
                        <asp:ListItem>View loan status/Aprrove Loans</asp:ListItem>
                        <asp:ListItem>ApproveFD</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">
                    <asp:Button ID="Submitbtn" runat="server" OnClick="Button6_Click1" style="margin-left: 48px; margin-top: 18px;" Text="Submit" Width="65px" Height="25px" />
                </td>
            </tr>
            </table>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>  



