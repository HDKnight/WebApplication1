<%@ Page Title="" Language="C#" MasterPageFile="~/MedalModel.Master" AutoEventWireup="true" CodeBehind="index3.aspx.cs" Inherits="母版页.index3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script>
        $(function () {
            alert("hello");
        })
    </script>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <%-- <div>
        <asp:Button ID="paihang" runat="server" Text="查看排行" BackColor="#0066ff" BorderColor="#0066ff" Font-Size="14" />
        <asp:Button ID="Button1" runat="server" Text="商城" BackColor="#0066ff" BorderColor="#0066ff" Font-Size="14" />
        <asp:Button ID="Button2" runat="server" Text="兑换" BackColor="#0066ff" BorderColor="#0066ff" Font-Size="14" />
        <asp:Button ID="Button3" runat="server" Text="查看排行" BackColor="#0066ff" BorderColor="#0066ff" Font-Size="14" />
    </div>--%>
    <div class="nav_menu3">
        <ul>
            <li class='nav-has-sub'><a href='#'>查看排行</a>
                <ul>
                    <li class='nav-has-sub'><a href='#'>工作狂人</a>
                        <ul>
                            <li><a href='index2.aspx?MedalId=1&SortType=1'>总积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=1&SortType=2'>月积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=1&SortType=3'>日积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=1&SortType=4'>勋章排行</a></li>
                        </ul>
                    </li>
                    <li class='nav-has-sub'><a href='#'>客服之星</a>
                        <ul>
                            <li><a href='index2.aspx?MedalId=7&SortType=1'>总积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=7&SortType=2'>月积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=7&SortType=3'>日积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=7&SortType=4'>勋章排行</a></li>
                        </ul>
                    </li>
                    <li class='nav-has-sub'><a href='#'>日积月累</a>
                        <ul>
                            <li><a href='index2.aspx?MedalId=8&SortType=1'>总积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=8&SortType=2'>月积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=8&SortType=3'>日积分排行</a></li>
                            <li><a href='index2.aspx?MedalId=8&SortType=4'>勋章排行</a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li><a href='index1.aspx'>商城</a></li>
            
        </ul>
    </div>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTable1">
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

                <asp:HyperLinkField HeaderText="员工编号" DataTextField="UserId"
                    DataNavigateUrlFormatString="~/details.aspx?UserId={0}" DataNavigateUrlFields="UserId">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:HyperLinkField>
                <asp:HyperLinkField HeaderText="员工名称" DataTextField="Name">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:HyperLinkField>
                <asp:HyperLinkField HeaderText="勋章编号" DataTextField="MedalId">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:HyperLinkField>

                <asp:HyperLinkField HeaderText="勋章数量" DataTextField="MedalValue"
                    DataNavigateUrlFormatString="~/details.aspx?MedalId={0}&UserId={1}" DataNavigateUrlFields="MedalId,UserId">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:HyperLinkField>
                <asp:BoundField HeaderText="积分数量" DataField="IntegralValue">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="勋章累计数量" DataField="MedalValueMax">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="积分累计数量" DataField="IntegralValueMax">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="等级" DataField="Level">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

            </Columns>
            <%--<Columns>
                <asp:BoundField HeaderText="签到日期" DataField="pfdate" HeaderStyle-HorizontalAlign="Left" HeaderStyle-ForeColor="#99cc00">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField HeaderText="人员姓名" DataField="ryname" HeaderStyle-ForeColor="#99cc00">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="出勤状态" DataField="cqzt" HeaderStyle-ForeColor="#99cc00">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="出勤时间" DataField="cqhour" HeaderStyle-ForeColor="#99cc00">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField HeaderText="加班时间" DataField="jbhour" HeaderStyle-ForeColor="#99cc00">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
            </Columns>--%>
        </asp:GridView>
    </div>
</asp:Content>

