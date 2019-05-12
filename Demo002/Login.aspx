<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Demo002.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>系统登录</title>
    <link herf="css/Login.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.js"></script>

</head>
<body>
    <%--一页只能有一个服务端Form标记--%>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" id="textUserName" name="textUserName" />
            <%--<asp:TextBox ID="textUserName" runat="server" />--%>
        </div>
        <div>
            密&#8195码：<input id="textUserPwd" type="password" name="textUserPwd"/></div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="登录" Width="60px" OnClick="btnSubmit_Click"/>
        </div>

        <%--代码内嵌--%>
        <%--for(int i = 0; i < 10; i++)
            {
                Response.Write(i + "<br>");
            }
           --%>
    <%--<script>
        window.onload = function () {
            alert("hello aspx");
        }

        $(function(){
            $("#btnSubmit").click(function(event){
                var userName = $("#textUserName").val();
                if (userName == "") {
                    alert("用户名不可为空！");
                    event.preventDefault();
                    return false;
                } else {
                    alert(userName);
                }
                
            })
        })

    </script>--%>
    

    </form>
        

</body>
</html>
