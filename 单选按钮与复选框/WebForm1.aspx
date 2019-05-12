<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="单选按钮与复选框.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>web控件之单选按钮与复选框</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="cb1" runat="server" Text="打球" />
            <asp:CheckBox ID="cb2" runat="server" Text="跑步" />
            <asp:CheckBox ID="cb3" runat="server" Text="游泳" /><br /><br />
            <asp:RadioButton ID="rbMale" GroupName="sex" runat="server" Text="男" />
            <asp:RadioButton ID="rbFemale" GroupName="sex" runat="server" Text="女" /><br />

            <asp:Button ID="btn1" runat="server" Text="获得选中的项名" OnClick="btn1_Click" />

        </div>
    </form>
</body>
</html>
