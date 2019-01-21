<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update2.aspx.cs" Inherits="BankingApplication.Update2" %>

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
    .auto-style1 {
        width: 476px;
    }
    .auto-style2 {
        width: 370px;
    }
    .auto-style4 {
        width: 172px;
    }
</style>
</head>
   
<body>
    <form id="form1" runat="server">
   <div class="fixed-header" style="text-align: center; left: -3px; height: 19px;"> 
    <asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" />
         Update Account</div>
       <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
         <table style="width: 100%; height: 343px;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">Account Number</td>
                <td class="auto-style1">
                    <asp:TextBox ID="AccountNoText" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    Customer Name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="CustomerText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    Age</td>
                <td class="auto-style1">
                    <asp:TextBox ID="AgeText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">Address</td>
                <td class="auto-style1">
                    <asp:TextBox ID="AddressText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">Email ID</td>
                <td class="auto-style1">
                    <asp:TextBox ID="EmailText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">City</td>
                <td class="auto-style1">
                    <asp:TextBox ID="CityText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">Gender</td>
                <td class="auto-style1">
                    <asp:TextBox ID="GenderText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">Account Balance</td>
                <td class="auto-style1">
                    <asp:TextBox ID="AccntBalText" runat="server" EnableViewState="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Height="32px" style="margin-left: 2px" Text="Update" Width="72px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
