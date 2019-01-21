<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accountsummary.aspx.cs" Inherits="BankingApplication.Accountsummary" %>

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
   
</style>
</head>
<body style="height: 240px; width: 1289px;">
    <form id="form1" runat="server">
   <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;">Customer Tasks<asp:Button ID="HomeBtn" runat="server" OnClick="HomeBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" /></div>
         <table style="width: 100%; height: 68px;">
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style8"><asp:DropDownList ID="CustomerTasksDropDown" runat="server" Height="22px" Width="153px" style="margin-left: 559px">
                    <asp:ListItem>Account Summary</asp:ListItem>
                    <asp:ListItem>Transfer</asp:ListItem>
                    <asp:ListItem>Apply Loan</asp:ListItem>
                    <asp:ListItem>Apply FD</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click1" Text="Submit" Width="71px" style="margin-left: 21px" />
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
         <asp:GridView ID="CustomerDetailsGrid" runat="server" AutoGenerateColumns="true" style="margin-left: 25px" Width="1294px" >
</asp:GridView>
       
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
