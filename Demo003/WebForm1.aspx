<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo003.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<asp:TextBox ID="textUserName" runat="server" 
                OnTextChanged="textUserName_TextChanged" AutoPostBack="true"/>
            <%--文本框改变自动回传属性：AutoPostBack="true"--%>
            <input type="text" name="text" id="text2" runat="server" />
            <br />
            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="测试一" />
            <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="测试二" />
            <br />
            <a href="WebForm1.aspx">请求自己</a><%--超链接，可刷新界面--%>
        </div>
    </form>

    <script src="js/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            $("#textUserName").change(function () {
                alert("value changed!");

                //$("#form1").submit();/*手动上传表单*/
            })
        })
    </script>

</body>
</html>
