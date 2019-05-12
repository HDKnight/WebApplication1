<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="用户控件的使用.login" %>
<div id="divLogin">
    <div>用户名:<asp:TextBox ID="textUserName" runat="server" /></div>
    <div>密&nbsp码:<asp:TextBox ID="textPwd" runat="server" TextMode="Password" /></div>
    <div>
        <asp:Button ID="btnLogin" runat="server" Text="登录" />
    </div>
</div>
