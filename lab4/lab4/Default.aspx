<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab4.Default" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <titlNumeric Palendromes</title>
    <style type="text/css">
        .newStyle1 {
            float: left;
            margin-left: 30px;
        }
    </style>
<title>
Palendromes
</title></head>
<body>
    <form id="form1" runat="server">

        <div style="background-color: #C0C0C0; border-style: solid; border-width: 1px; margin: auto; width: 433px; padding: 10px; height: 400px;">
            <h1 style="text-align: center">Find Numeric Palindromes</h1>
            <div>
                Enter a starting integer (0-1,000,000,000):&nbsp;
                <asp:TextBox ID="Start" runat="server" Width="81px"></asp:TextBox>
                &nbsp;&nbsp; 
                <br />
                Enter count (1-100):&nbsp;
                <asp:TextBox ID="Num" runat="server" Width="47px"></asp:TextBox>
           
                <br />
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Generate" runat="server" Text="Generate" OnClick="Generate_Click" />
              
                <br />
                <asp:ListBox ID="Result" runat="server" Width="100px" Rows="10"></asp:ListBox>
                
                <br />
     
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Comment" runat="server" Text=""></asp:Label>
             
            </div>
            <br />

        </div>
    </form>
</body>
</html>

