<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="文件的上传与下载.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>web控件之文件上传和下载</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUpload1" runat="server" />
            <asp:Button ID="btn1" runat="server" Text="点击上传" OnClick="btn1_Click" />
        </div>
    </form>
</body>
</html>
