<%@ Page Title="" Language="C#" MasterPageFile="~/MedalModel.Master" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="母版页.index2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script>
        $(function () {
            alert("hello");
        })
    </script>--%>
    <%--<script>  

        function showmodal() {
            var ret = window.showModalDialog("child.html", null, "dialogWidth:350px;dialogHeight:350px;help:no;status:no");
            if (ret) {
                alert('子窗口返回真!');
            } else {
                alert('子窗口返回假!');
            }
        }
    </script>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
            <li><a href='index1.aspx'>首页</a></li>
            <li><a href='index3.aspx'>商城</a></li>
            
        </ul>
        <br />
        <asp:Label runat="server" ID="Label2" Text="" ForeColor="#ff0066" BackColor="White" />
        <asp:Label runat="server" ID="lable1" Text="label" />
        <asp:Label runat="server" ID="Label3">MedalId:"<%=medalId %>"</asp:Label>
        <asp:Label runat="server" ID="Label4" Text="label" />
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function setClf(con) {
            var table = document.getElementById("gridView1");
            var tr = table.getElementsByTagName("tr");
            //获取鼠标点击的元素  
            var e = event.srcElement;
            //获取元素所在的行的行号（表头行号从0开始）。注意：parentElement只适用于IE浏览器，而parentNode则符合DOM标准。  
            //var rowIndex=e.parentElement.parentElement.rowIndex ;  
            var i = e.parentNode.parentNode.rowIndex; //获取GridView控件  分别获取选定行指定列的值
            var a, b,c;

            a = parseFloat(tr[i].getElementsByTagName("td")[0].getElementsByTagName("TextBox")[0].value);
            b = parseFloat(tr[i].getElementsByTagName("td")[1].getElementsByTagName("TextBox")[0].value);

            //上面为获取gridview中textbox的，如果为lable则如下写法
            //  b = parseFloat(tr[i].getElementsByTagName("td")[1].getElementsByTagName("span")[0].innerText);
           
            sum1 = a+b; //计算方法改变 
            c = parseFloat(tr[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);
            if (sum1 != c) {
                con.style.color = "Red";

            }
            else con.style.color = "black";

        } 
    </script>

    <script>
        function setvalue() {
            setClf();
            alert(a);
        }
    </script>
    <div id="divTable1">
        <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="false" Width="100%" GridLines="None" >
            <RowStyle HorizontalAlign="Center" />
            <Columns>
                <%--var a = "<%=test() %>";--%>
                <asp:BoundField HeaderText="排名" DataField="排名" />
                <asp:BoundField HeaderText="员工编号" DataField="员工编号" />

                <asp:HyperLinkField HeaderText="姓名" DataTextField="姓名"
                    DataNavigateUrlFormatString="~/details.aspx?UserId={0}" DataNavigateUrlFields="员工编号"></asp:HyperLinkField>
                <asp:BoundField HeaderText="积分数" DataField="积分数" />
                <asp:BoundField HeaderText="时间" DataField="时间" />

                <asp:TemplateField>
                    <ItemTemplate >
                        <asp:TextBox ID="sendNumber" runat="server" Width="30px" />
                        <asp:LinkButton ID="btnSend" runat="server" Text="赠送" OnCLientClick="if(confirm('确定要赠送吗？')==true){javascript:setvalue();return true;} else{return false;}" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
