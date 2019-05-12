<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="控制权转移控件.aspx.cs" Inherits="web控件.控制权转移控件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>web控件之控制权转移控件</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <%--Button、Linkbutton、Imagebutton控件
            1、呈现外观不同；2、都用于客户端的点击使用页面提交操作
            3、可使用PostBackUrl属性进行跨页面提交
            4、可使用CommandName和CommandArgument属性保存信息
            HyperLink控件
            1、超链接控件；2、可直接转向指定页面，但不是跨页提交
            3、可使用target属性--%>

            Id:<asp:TextBox ID="textID" runat="server" />
            <asp:Button ID="btn1" runat="server" Text="普通按钮" PostBackUrl="~/server.aspx"/><br />
            <asp:LinkButton ID="lbtn1" runat="server" Text="超链接按钮" PostBackUrl="~/server.aspx"/><br />
            <asp:ImageButton ID="ibtn1" runat="server" ImageUrl="~/image/Web控件继承体系.png" PostBackUrl="~/server.aspx"/>
                
            <asp:HyperLink ID="hlink1" runat="server" Text="百度" NavigateUrl="~/server.aspx" />        

        </div>
    </form>
</body>
</html>
