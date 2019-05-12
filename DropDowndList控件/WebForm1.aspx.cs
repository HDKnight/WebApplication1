using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DropDowndList控件.Models;
namespace DropDowndList控件
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SchoolDBDataContext db = new SchoolDBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGroup();
            }
        }
        #region 加载组别
        private void LoadGroup()
        {
            List<@Group> groupList = db.Group.ToList();

            /* 1、使用数据源绑定的方式实现*/
            //this.drpGroup.DataSource = groupList;
            //this.drpGroup.DataTextField = "GroupName";
            //this.drpGroup.DataValueField = "GroupId";
            //this.drpGroup.DataBind();

            /*使用代码循环加载项目*/
            foreach (var c in groupList)
            {
                this.drpGroup.Items.Add(new ListItem { Text = c.GroupName, Value = c.GroupId.ToString() });

            }
        }
        #endregion

        protected void drpGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Write(this.drpGroup.SelectedIndex);
            LoadUsers();
        }
        #region 加载用户
        private void LoadUsers()
        {
            int? groupId = Convert.ToInt32(this.drpGroup.SelectedValue);
            List<Users> usersList = db.Users.Where(c => c.Group == groupId).ToList();

            this.usersListBox.DataSource = usersList;
            this.usersListBox.DataTextField = "Name";
            this.usersListBox.DataValueField = "id";
            this.usersListBox.DataBind();

        }
        #endregion
    }
}