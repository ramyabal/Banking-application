<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customerlogin.aspx.cs" Inherits="BankingApplication.Customerlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

      <style>
        /* Basics */
        html, body
        {
    background-color: #87CEEB;
}
     body{        
        padding-top: 60px;
        padding-bottom: 40px;
              width: 1260px;
              height: 1px;
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
      
        {
            padding: 0;
            margin: 0;
            width: 100%;
            height: 100%;
            font-family: "Helvetica Neue" , Helvetica, sans-serif;
            background: #FFFFFF;
        }
        .logincontent
        {
            position: fixed;
            width: 355px;
            height: 258px;
            top: 44%;
            left: 50%;
            margin-top: -150px;
            margin-left: -175px;
            background: #07A8C3;
            padding-top: 10px;
        }
        .loginheading
        {
            border-bottom: solid 1px #ECF2F5;
            padding-left: 18px;
            padding-bottom: 10px;
            color: #ffffff;
            font-size: 20px;
            font-weight: bold;
            font-family: sans-serif;
        }
        label
        {
            color: #ffffff;
            display: inline-block;
            margin-left: 18px;
            padding-top: 10px;
            font-size: 15px;
        }
        input[type=text], input[type=password]
        {
            font-size: 14px;
            padding-left: 10px;
            margin: 10px;
            margin-top: 12px;
            margin-left: 18px;
            width: 300px;
            height: 35px;
            border: 1px solid #ccc;
            border-radius: 2px;
            box-shadow: inset 0 1.5px 3px rgba(190, 190, 190, .4), 0 0 0 5px #f5f5f5;
            font-size: 14px;
        }
       
        .loginbtn
        {
            float: right;
            margin-right: 20px;
            margin-top: 20px;
            padding: 6px 20px;
            font-size: 14px;
            font-weight: bold;
            color: #fff;
            background-color: #07A8C3;
            background-image: -webkit-gradient(linear, left top, left bottom, from(#07A8C3), to(#6EE4E8));
            background-image: -moz-linear-gradient(top left 90deg, #07A8C3 0%, #6EE4E8 100%);
            background-image: linear-gradient(top left 90deg, #07A8C3 0%, #6EE4E8 100%);
            border-radius: 30px;
            border: 1px solid #07A8C3;
            cursor: pointer;
        }
        .loginbtn:hover
        {
            background-image: -webkit-gradient(linear, left top, left bottom, from(#b6e2ff), to(#6ec2e8));
            background-image: -moz-linear-gradient(top left 90deg, #b6e2ff 0%, #6ec2e8 100%);
            background-image: linear-gradient(top left 90deg, #b6e2ff 0%, #6ec2e8 100%);
        }
          .loginremember {
              height: 52px;
              width: 72px;
              margin-left: 22px;
          }
          #form1 {
              height: 356px;
              width: 1293px;
          }
          
          
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <div class="fixed-header" style="text-align: center; left: -3px; height: 19px;">
            <asp:Button ID="HomeBtn" runat="server" OnClick="Button5_Click" style="position: absolute; right: 83px; top: 4px; height: 25px; width: 60px; left: 1158px;" Text="Home" />
        Customer Login</div>
    <div class="logincontent">
        <label for="txtUserName">
            Username:</label>
       <asp:TextBox ID="UserText" runat="server" ></asp:TextBox>
        <label for="txtPassword">
            Password:</label>
         <asp:TextBox ID="PassText" TextMode="Password" runat="server" ></asp:TextBox>
        <div class="loginremember">
            <br />
        <asp:Button ID="Button1" runat="server" Text="login" Height="31px" OnClick="Button1_Click" Width="73px" style="margin-left: 0px" />
        </div>
        
    </div>
    </form>
    <div class="fixed-footer">
        <div class="container">Copyright © 2016 Banking App</div>        
    </div>
</body>
</html>




