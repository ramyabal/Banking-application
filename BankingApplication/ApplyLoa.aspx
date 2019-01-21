<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyLoa.aspx.cs" Inherits="BankingApplication.ApplyLoa" %>

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
   
    .auto-style3 {
        width: 518px;
    }
    .auto-style4 {
        width: 188px;
    }
   
</style>
</head>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
     <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>

    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="https://cdn.jsdelivr.net/jquery.validation/1.16.0/jquery.validate.min.js"></script>
   
   

     <script type ="text/javascript" >
         $(document).ready(function(){
        $('#cityname').autocomplete({
            source:'City.ashx'
        });
    });
       
        $(function () {
            $('#updoc').change(function () {
                var val = $(this).val().toLowerCase(),
                    regex = new RegExp("(.*?)\.(pdf)$");

                if (!(regex.test(val))) {
                    $(this).val('');
                    alert('Please select correct file format');
                }
            });
        });
        $(function () {
            $('#pslips').change(function () {
                var val = $(this).val().toLowerCase(),
                    regex = new RegExp("(.*?)\.(pdf)$");

                if (!(regex.test(val))) {
                    $(this).val('');
                    alert('Please select correct file format');
                }
            });
        });
        $(function () {
            $('#image').change(function () {
                var val = $(this).val().toLowerCase(),
                    regex = new RegExp("(.*?)\.(png)$");

                if (!(regex.test(val))) {
                    $(this).val('');
                    alert('Please select correct file format');
                }
            });
        });

        $("#btn_apply").click( function() { 
            $("#form1").validate({  
                rules: {
                    //This section we need to place our custom rule for the control.
                    <%=loansdropdown.UniqueID %>:{ 
                   required:true 
                    },
                    <%=lamount.UniqueID %>:{ 
                        
                        required:true 
                    },
                    <%=updoc.UniqueID %>:{ 
                        
                        required:true 
                    },
                    <%=Tfemployment.UniqueID %>:{ 
                        
                        required:true 
                    },
                    <%=Ipmonth.UniqueID %>:{ 
                        
                        required:true
                    },
                    <%=pslips.UniqueID %>:{ 
                        required: true
                    },
                    <%=image.UniqueID %>:{ 
                        required: true,
                    }
                },
            
                messages: {
                    //This section we need to place our custom validation message for each control.  
                    <%=loansdropdown.UniqueID %>:{  
                        required: "Please select a loan."  
                        
                    }, 
                    <%=lamount.UniqueID %>:{  
                    required: "Please enter Loan Amount."  ,
                }, 
                    <%=updoc.UniqueID %>:{  
                        required: "Please select a file to Uploaded."  
                        
                },
                    <%=Tfemployment.UniqueID %>:{  
                    required: "Please select a employee."  
                        
                }, 
                    <%=Ipmonth.UniqueID %>:{  
                    required: "Please enter Income" ,
                        
                }, 

                    <%=pslips.UniqueID %>:{  
                        required: "Please select a file to Uploaded."  
                        
                }, 
                    <%=image.UniqueID %>:{  
                        required: "Please select a file to Uploaded."  
                }
                }

            
            });
        });
      </script>
   

 <body>
 <form id="form1" runat="server" enctype="multipart/form-data">
      <div class="fixed-header" style="text-align: center; left: -3px; height: 19px;"> Apply Loans<asp:Button ID="Homebtn" runat="server" OnClick="Homebtn_Click" Text="Home" style="position: absolute; left: 83px; top: 4px; height: 25px; width: 60px; right: 1158px;" /></div>
     <asp:Button ID="LogoutBtn" runat="server" OnClick="LogoutBtn_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Logout" />  
     <table style="width: 100%; height: 318px;">
             <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    Loan Type</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="loansdropdown" runat="server" Height="22px" Width="87px">
                        <asp:ListItem>Home Loans</asp:ListItem>
                        <asp:ListItem>Car Loans</asp:ListItem>
                        <asp:ListItem>Personal Loans</asp:ListItem>
                        <asp:ListItem>Two-Wheeler Loans</asp:ListItem>
                        <asp:ListItem>Education Loans</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    Loan Amount
                    </td>
                <td class="auto-style5">
                    <asp:TextBox ID="lamount" runat="server" Height="16px" Width="83px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                       Upload Documents</td>
                <td class="auto-style5">
                       <asp:FileUpload id="updoc" runat="server" Width="177px" />
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    Type Of Employment</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="Tfemployment" runat="server" Height="24px" Width="87px">
                        <asp:ListItem>Salaried</asp:ListItem>
                        <asp:ListItem>Self Employed</asp:ListItem>
                        <asp:ListItem>Self Employed professional</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    Income per month</td>
                <td class="auto-style8">
                    <asp:TextBox ID="Ipmonth" runat="server" Height="16px" Width="83px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                       Upload payslips</td>
                <td class="auto-style8">
                       <asp:FileUpload   id="pslips" runat="server" Width="217px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Upload Image</td>
                <td class="auto-style8">
                       <asp:FileUpload id="image" runat="server" Width="217px" />
                </td>
            </tr>
           <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">city</td>
                <td class="auto-style8">
                    <asp:TextBox ID="cityname" runat="server" Height="16px" Width="83px"></asp:TextBox>
                </td>
            </tr>

               <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Loan ApplyDate</td>
                <td class="auto-style8">
                    <asp:TextBox ID="ApplyDateText" runat="server" Height="16px" Width="83px"></asp:TextBox>
                   </td>
            </tr>

            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btn_apply" runat="server" Height="31px" style="margin-left: 28px" Text="Apply" Width="70px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style8"></td>
            </tr>

        </table>
 </form>
      <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>
