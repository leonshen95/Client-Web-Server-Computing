<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Units Conversion</title>
        <style type="text/css">
        .newStyle1 {
            background-color: #808080;
            border-style: solid;
            border-width: 1px;
            margin: auto;
            width: 800px;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="newStyle1">
            <h1 style="text-align: center">Units Conversions</h1>
            <br />
            Input Value: 
            <asp:TextBox ID="inputString" runat="server" Width="121px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear" />
            <br />
            <br />
            Choose your unit:<br />
            
            <asp:DropDownList ID="fromUnit" runat="server"  Width="199px"  DataSourceID="SqlDataSource1" DataTextField="Unit" DataValueField="Conversion">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="toUnit" runat="server" Width="199px" DataSourceID="SqlDataSource1" DataTextField="Unit" DataValueField="Conversion">
            </asp:DropDownList>
&nbsp;<br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [UnitConversion]"></asp:SqlDataSource>
            <br />

            <br />
            <asp:Button ID="convert" runat="server" Text="Convert" Width="80px" OnClick="convert_Click" />
          
&nbsp;&nbsp;<br />
            <br />
            Output Value:&nbsp;
            <asp:Label ID="output" runat="server" Text=""></asp:Label>
            <br />


            <br />
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
