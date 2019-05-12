<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Demo002.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>员工积分查询</title>
    <style>
        h1
        {
	        background-color:blue;
        }   
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1> </h1><br />
            <asp:Label ID="labCurrentName" runat="server" /><br />
            <asp:Button ID="btnBack" runat="server" Text="返回登录" OnClick="btnBack_Click" />

        </div>
    </form>
</body>
</html>
