﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="用户控件的使用.WebForm1" %>

<%@ Register Src="~/login.ascx" TagPrefix="uc1" TagName="login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:login runat="server" ID="login" /><br/>

            <asp:Button ID="btn1" runat="server" Test="测试按钮" OnClick="btn1_Click" />

        </div>
    </form>
</body>
</html>
