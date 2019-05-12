<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridView控件.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>GridView控件</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="员工编号" DataField="id" />
                    <asp:HyperLinkField HeaderText="员工名称" DataTextField="Name"
                        DataNavigateUrlFormatString="~/details.aspx?id={0}" DataNavigateUrlFields="id" />
                    <asp:BoundField HeaderText="性别" DataField="Sex" />
                    <asp:BoundField HeaderText="年龄" DataField="Age" />
                    <asp:BoundField HeaderText="组别" DataField="GroupName" />
                    <asp:BoundField HeaderText="电话" DataField="Tel" />
                    <asp:BoundField HeaderText="地址" DataField="Address" />
                    <asp:BoundField HeaderText="QQ" DataField="QQ" />
                    <asp:BoundField HeaderText="邮件" DataField="Email" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
