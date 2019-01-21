<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="download.aspx.cs" Inherits="BankingApplication.download" %>

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
        width: 152px;
        height: 39px;
    }
    .auto-style2 {
        width: 64px;
        height: 39px;
    }
    .auto-style7 {
        width: 425px;
        height: 39px;
    }
    .auto-style8 {
        width: 100px;
        height: 39px;
    }
    .auto-style9 {
        width: 92px;
        height: 39px;
    }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="fixed-header" style="text-align: center; left: -20px; height: 23px;">Approve Loans<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
        <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />
       <div class="grid-container">
    &nbsp;
    <table>
        <tr>
            <td class="auto-style7" style="text-align: right;">
                <asp:Label ID="lblFrmDate" runat="server" Text="From Date" >From Date</asp:Label>
            </td>
            <td class="auto-style2" >
               <asp:TextBox ID="TxtIndate" type="date" runat="server" Height="22px" Width="132px" style="margin-left: 32px" ></asp:TextBox>
                    
            </td>
             <td class="auto-style9">
                <asp:Label ID="lblToDate"  runat="server" Text="To Date">To Date</asp:Label>
            </td>
            <td class="auto-style1">
               <asp:TextBox ID="txtOutDate" type="date" runat="server" Height="22px" Width="132px" style="margin-left: 5px" ></asp:TextBox>
              
            </td>
            <td class="auto-style8">
                &nbsp;<asp:Button ID="btnSubmit" runat="server" Width="67px" Text="Search" style="margin-left: 21px" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table><br /><br/>
  <asp:GridView ID="FileDwnGrid" runat="server" AutoGenerateColumns="false" Width="1066px" style="margin-left: 115px" >

    <Columns>
        <asp:BoundField DataField="AccountNo" HeaderText="Account number" ItemStyle-Width="150" />
        <asp:BoundField DataField="loans" HeaderText="loans" ItemStyle-Width="150" />
        <asp:BoundField DataField="LoanAmount" HeaderText="loan_amount" ItemStyle-Width="150" />
   <asp:TemplateField>
        <ItemTemplate>
            <asp:LinkButton ID="lnkDownload"  Text="Download" CommandArgument= '<%#Eval("UploadDocuments")%>' runat="server" onclick = "lnkDownload_Click" ></asp:LinkButton>
             <asp:LinkButton ID="btnOpen" Text="View" CommandArgument= '<%#Eval("UploadDocuments")%>' Font-Bold="true" runat="server" OnClick ="btnOpen_Click"></asp:LinkButton>
        </ItemTemplate>
    </asp:TemplateField>
         <asp:BoundField DataField="TypeOfEmployement" HeaderText="Type of Employment" ItemStyle-Width="150" />
         <asp:BoundField DataField="IncomePerMonth" HeaderText="Income Per Month" ItemStyle-Width="150" />
        <asp:TemplateField>
        <ItemTemplate>
            <asp:LinkButton ID="payslips"  Text="Download" CommandArgument= '<%#Eval("Payslips")%>' runat="server" onclick = "lnkDownload_Click" ></asp:LinkButton>
             <asp:LinkButton ID="btnOpen1" Text="View" CommandArgument= '<%#Eval("Payslips")%>' Font-Bold="true" runat="server" OnClick ="btnOpen_Click"></asp:LinkButton>
        </ItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField>
        <ItemTemplate>
            <asp:LinkButton ID="image"  Text="Download" CommandArgument= '<%#Eval("Image")%>' runat="server" onclick = "lnkDownload_Click" ></asp:LinkButton>
             <asp:LinkButton ID="btnOpen2" Text="View" CommandArgument= '<%#Eval("Image")%>' Font-Bold="true" runat="server" OnClick ="btnOpen_Click"></asp:LinkButton>
        </ItemTemplate>
    </asp:TemplateField>
         <asp:BoundField DataField="City" HeaderText="City" ItemStyle-Width="150" />
        <asp:BoundField DataField="LoanApplyDate" HeaderText="Loan Apply Date" ItemStyle-Width="150" />
        <asp:BoundField DataField="ApprovedLoans" HeaderText="Approved Loans" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
       
    </div>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 565px" Height="30px" Width="141px">
           
            <asp:ListItem>view loan details</asp:ListItem>
            <asp:ListItem>Approve Loans</asp:ListItem>
             <asp:ListItem>ReviewDoc</asp:ListItem>
        </asp:DropDownList>
      
    <asp:Button ID="Button1" runat="server" Height="22px" OnClick="Button1_Click" Text="Submit" Width="74px" style="margin-left: 28px" />
      
        </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
