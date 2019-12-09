<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab3.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Calculator</title>
        <style type="text/css">
        .left {
            padding: 50px;
        }
        .right {
            border-width: thin;
            padding: 20px;
            background-color: #FFFF00;
            border-top-style: solid;
        }
        .main {
            border-width: thin;
            border-style: solid;
            margin: auto;
            width: 394px;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div>
    <div class="main">
    <h1 style="text-align: center">Calculator</h1>
<p>Input: <asp:TextBox ID="op1" runat="server" /></p>
<p>
Result: <asp:TextBox ID="op2" runat="server" ReadOnly="True" /></p>
    <div class="right">    
    <p>&nbsp;<asp:Button Text="enter" OnClick="OnEnter" runat="server" style="width:47px;"/>
        &nbsp;
<asp:Button Text=" + " OnClick="OnAdd" runat="server" style="width:47px;"/>
        &nbsp;
        <asp:Button Text=" - " OnClick="OnSub" runat="server" style="width:47px;"/>
        &nbsp;
        <asp:Button Text=" x " OnClick="OnMul" runat="server" style="width:47px;"/>
        &nbsp;
        <asp:Button Text=" / " OnClick="OnDiv" runat="server" style="width:47px;"/>
</p>
<p>
<asp:Label ID="error" runat="server"  BackColor="White" ForeColor="Red" />
</p>
        
        </div>
       </div>
</div>
</form>
</body>
</html>
