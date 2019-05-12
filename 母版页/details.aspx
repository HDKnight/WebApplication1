<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="GridView控件.details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>积分增减记录</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labId" runat="server" />
            <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="false" Width="100%" GridLines="None">
            <%--<Columns>
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
            </Columns>--%>
            <Columns>

                <asp:BoundField HeaderText="编号" DataField="Id">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <%--<asp:BoundField HeaderText="员工编号" DataField="UserId" />--%>
                <%--<asp:HyperLinkField HeaderText="员工编号" DataTextField="UserId"
                    DataNavigateUrlFormatString="~/details.aspx?id={0}" DataNavigateUrlFields="id" />--%>
                <asp:BoundField HeaderText="员工编号" DataField="UserId">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="员工名称" DataField="Name">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="勋章编号" DataField="MedalId">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="勋章名称" DataField="MedalName">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="积分数量" DataField="IntegralValue">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="积分来源" DataField="IntegralSource">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="记录时间" DataField="WriteTime">
                     <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

            </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
