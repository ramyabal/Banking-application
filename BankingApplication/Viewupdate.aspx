<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewupdate.aspx.cs" Inherits="BankingApplication.Viewupdate" %>

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
    .auto-style3 {
        width: 329px;
    }
    .auto-style4 {
        width: 537px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -7px; height: 23px;"><asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" />Account Details</div>
    <div> <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" /></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style3">
                    <asp:DropDownList ID="AdminTasksDropDown" runat="server" style="margin-left: 0px" >
                        <asp:ListItem>View Account Details</asp:ListItem>
                        <asp:ListItem>Update Account Details</asp:ListItem>
                        <%--<asp:ListItem>Home</asp:ListItem>--%>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click1" Text="Submit" Width="71px" style="margin-left: 34px" />
                </td>
                <td class="auto-style5">
                    <br />
              
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="ViewUsersGrid" runat="server" AutoGenerateColumns="true" style="margin-left: 128px" Width="1067px" >
</asp:GridView>
       
    </form>
      <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
