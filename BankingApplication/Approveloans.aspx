<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Approveloans.aspx.cs" Inherits="BankingApplication.Approveloans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

    <script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />


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
        height: 42px;
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
        width: 758px;
    }
    .auto-style4 {
        width: 1645px
    }
    .auto-style5 {
        width: 294px
    }
    </style>
    </head>
    <body>
    <form id="form2" runat="server">
        <div class="fixed-header" style="text-align: center; left: -7px; height: 40px;">Approve Loans</div>
       <asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click"  style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" Text="Home" />
       <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px;height: 25px;  width: 60px; left: 1158px;" Text="Logout" />
         <table style="width: 80%; height: 233px;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    Account Number</td>
                <td class="auto-style1">
                    <asp:TextBox ID="AccountNoText" runat="server" ReadOnly="true" Height="24px" Width="114px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    Loans</td>
                <td class="auto-style1">
                    <asp:TextBox ID="LoansText" runat="server" ReadOnly="true" Height="24px" Width="114px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    Loan Amount</td>
                <td class="auto-style1">
                    <asp:TextBox ID="LoanAmountText" runat="server" ReadOnly="true" Height="24px" Width="114px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>

                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" Height="31px" style="margin-left: 33px" Text="Approve" Width="66px" OnClick="Button1_Click" />
                </td>

                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
             </table>
                    <div>

        <div class="modal fade" id="myModal" role="dialog">

            <div class="modal-dialog">

                <!-- Modal content-->

                <div class="modal-content">

                    <div class="modal-header">

                        <button type="button" class="close" data-dismiss="modal">

                            &times;</button>

                        <h4 class="modal-title">

                            Loan Approvals</h4>

                    </div>

                    <div class="modal-body">
                       

                        <div class="col-lg-12 col-sm-12 col-md-12 col-xs-12">
                            <div> Are you sure you want to approve.</div>

                        </div>

                    </div>

                    <div class="modal-footer">

                        <asp:Button ID="btnApprove" runat="server" Text="approve"  CssClass="btn btn-info" OnClick="approve_click"/>

                        <button type="button" class="btn btn-info" data-dismiss="modal">

                            Close</button>

                    </div>

                </div>

            </div>

            <script type='text/javascript'>

                function openModal() {

                    $('[id*=myModal]').modal('show');

                }

            </script>

        </div>

    </div>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>