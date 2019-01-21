<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Createaccount.aspx.cs" Inherits="BankingApplication.Createaccount" %>

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
        width: 219px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
   
     <div class="fixed-header" style="text-align: center; left: -3px; height: 19px;"> 
         <asp:Button ID="Homebtn" CausesValidation="false"  runat="server" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" OnClick="Homebtn_Click" />
         Create Account</div>
       <div> <asp:Button ID="LogoutBtn" CausesValidation="false" runat="server" OnClick="Button5_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" /></div>
   
        <table style="width: 62%; height: 393px; margin-left: 469px; margin-right: 0px;">
            <tr>
                <td class="auto-style1">Customer Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="CustomerText" runat="server" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="CustomerNameValidator" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Required and must be of length 5 to 12."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="passText" runat="server" TextMode="Password" Height="22px"></asp:TextBox>
                </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter your Password."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Confirm Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="CpassText" runat="server" TextMode="Password" Height="24px"></asp:TextBox>
             </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter a confirmpassword."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td class="auto-style4">
                    <asp:TextBox ID="AgeText" runat="server" Height="24px"></asp:TextBox>
             </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Age must be above 18."></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="AddressText" runat="server" Height="22px"></asp:TextBox>
             </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter your address."></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">Email ID</td>
                <td class="auto-style4">
                    <asp:TextBox ID="EmailText" runat="server" Height="24px"></asp:TextBox>
                </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter a valid Email Address"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">City</td>
                <td class="auto-style4">
                   <asp:TextBox ID="CityText" runat="server" Height="22px"></asp:TextBox>
                               </td>
                <td class="auto-style5"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter your city."></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td>
                    &nbsp;<asp:RadioButtonList ID="GenderRadioButton" runat="server" Height="37px" Width="127px">
                        <asp:ListItem>Male</asp:ListItem> <asp:ListItem>Female</asp:ListItem>
                       
                    </asp:RadioButtonList>
&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Gender Required."></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">Account Balance</td>
                <td class="auto-style4">
                    <asp:TextBox ID="AcBalText" runat="server" style="margin-top: 0px" Height="24px"></asp:TextBox>
            </td>
                <td class="auto-style26"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ForeColor="Red" ControlToValidate="CustomerText" ErrorMessage="Please enter Account balance."></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"> 
                    <asp:Button ID="createbtn" runat="server" OnClick="Button2_Click" Text="Create" Width="72px" Height="25px" style="margin-left: 37px" />
                </td>
                </tr>
            </table>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
