<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDowndList控件.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>List控件之DropDownList控件</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            班级：<asp:DropDownList ID="drpGroup" runat="server" Width="150"
                OnSelectedIndexChanged="drpGroup_SelectedIndexChanged"
                ><%--AutoPostBack="true"--%>
                <asp:ListItem Value="-99">--请选择班级--</asp:ListItem>
            </asp:DropDownList>
            <br />
            用户：<asp:ListBox ID="usersListBox" runat="server" width="150"/><br /><br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/下载 (1).jpg"/>
        </div>
    </form>
    <script src="js/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            $("#drpGroup").change(function () {
                /*如果没有选择选择具体的班级，就不要提交表单*/
                if ($(this).val() != -99) {
                    $("#form1").submit();
                } else {
                    $("#usersListBox")[0].options.length = 0;//清空用户列表
                }
                
            })
        })
    </script>
</body>
</html>
