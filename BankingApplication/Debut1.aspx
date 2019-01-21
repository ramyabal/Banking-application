<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Debut1.aspx.cs" Inherits="BankingApplication.Debut1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 305px;
        }
        #form1 {
            height: 194px;
        }
        .auto-style8 {
            width: 320px;
        }
    </style>
</head>
<body style="height: 168px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width: 100%; height: 68px;">
            </table>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >
    <Columns>
        <asp:BoundField DataField="Production Company" HeaderText="Production Company" ItemStyle-Width="150" />
        <asp:BoundField DataField="PAC ID" HeaderText="PAC ID" ItemStyle-Width="150" />
        <asp:BoundField DataField="Program ID" HeaderText="Program ID" ItemStyle-Width="150" />
        <asp:BoundField DataField="PAC Titile" HeaderText="PAC Titile" ItemStyle-Width="150" />
        <asp:BoundField DataField="Network" HeaderText="Network" ItemStyle-Width="150" />
        <asp:BoundField DataField="PAC Type" HeaderText="PAC Type" ItemStyle-Width="150" />
        <asp:BoundField DataField="Tax Credit" HeaderText="Tax Credit" ItemStyle-Width="150" />  
        <asp:BoundField DataField="TA Required" HeaderText="TA Required" ItemStyle-Width="150" />
        <asp:BoundField DataField="TA Status" HeaderText="TA Status" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>