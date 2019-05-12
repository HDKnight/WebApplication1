using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 母版页.Models;

namespace 母版页
{
    public partial class index1 : System.Web.UI.Page
    {
        //DataClasses1DataContext db = new DataClasses1DataContext();
        DataClasses1DataContext db1 = new DataClasses1DataContext();
        string userId = null;
        //string medalId = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userId = this.Session["currentId"].ToString();
                this.Session["currentId"] = userId;
            }
            catch
            {
                //Response.Write("未经许可的登录！！！");
                Server.Transfer("index.html", true);
            }
            if (!IsPostBack)
            {
                LoadDate();
            }
        }

        private void LoadDate()
        {
            //List<Users_Group> lsUsers = db.Users_Group.ToList();
            //this.gridView1.DataSource = lsUsers;
            //this.DataBind();
            string query = "select * from Medal_BonusPointMain where UserId='" + userId + "' order by MedalId asc";
            List<Medal_BonusPointMain> lsUsers = db1.Medal_BonusPointMain.ToList();
            this.gridView1.DataSource = db1.ExecuteQuery<Medal_BonusPointMain>(query);
            this.gridView1.DataBind();
            //this.gridView1.DataSource = lsUsers;
            //this.DataBind();
        }

        
    }
}