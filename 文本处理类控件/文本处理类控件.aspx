<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="文本处理类控件.aspx.cs" Inherits="web控件.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>web控件之文本处理类控件</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <%--Label：用于在页面中呈现信息，无法接收用户的信息录入
            TextBox：用于在页面中呈现信息，可被用户修改控件中的内容
            Literal：呈现效果同Label控件，但不会在客户端生成任何控件，仅仅作为一个文本占位符
            HiddenField：用于在页面中保存一些用户无法看到的信息，此信息随页面回传过程中不会消失--%>
            <asp:Label ID="lab" runat="server" Text="用户名：" />
            <asp:TextBox ID="textUserName" runat="server" Text="admin"/><br />
            <asp:Literal ID="lit" runat="server" Text="占位符" />
            <asp:HiddenField ID="hf" runat="server" Value="12345" />
        </div>
    </form>
    <script src="js/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            alert($("#lab").html());
            alert($("#textUserName").val());
        })
    </script>
</body>
</html>
