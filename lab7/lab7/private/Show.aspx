<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="lab7.private.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style type="text/css">
        .background-color {
            background-color: #808080;
            border-style: solid;
            border-width: thin;
            margin: auto;
            padding: 30px;
            width: 525px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div class="background-color">

            <asp:TextBox ID="TextBox1" Rows="2" Columns="20" style="height:211px;width:493px;" runat="server" TextMode="MultiLine"></asp:TextBox>

            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True" DeleteCommand="DELETE FROM comment" InsertCommand="INSERT INTO [comment] ([comments]) VALUES (@comments)" SelectCommand="SELECT [Id], [comments] FROM [comment]" UpdateCommand="UPDATE [comment] SET [comments] = @comments WHERE [Id] = @Id" ProviderName="System.Data.SqlClient">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="comments" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="comments" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Prev Comment" OnClick="Prev_Click" />
             &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Next Comment" OnClick="Next_Click" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Delete All Comments" OnClick="Delete_Click" />

            <asp:HiddenField ID="HiddenField1" runat="server" OnValueChanged="HiddenField1_ValueChanged" Visible="False" Value="0" />

        </div>
    </form>
</body>
</html>
