using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 母版页.Models;

namespace GridView控件
{
    public partial class details : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    string userId = Request.QueryString["id"];
        //    this.labId.Text = userId;
        //}
        DataClasses2DataContext db2 = new DataClasses2DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSdudent();
            }
            string userId = Request.QueryString["UserId"];
            string medalId = Request.QueryString["MedalId"];
            if (medalId != null)
            {
                this.labId.Text = "员工编号：" + userId + " 勋章编号：" + medalId;
            }
            else
            {
                this.labId.Text = "员工编号：" + userId;
            }

        }

        private void LoadSdudent()
        {
            //List<Users_Group> lsUsers = db.Users_Group.ToList();
            //this.gridView1.DataSource = lsUsers;
            //this.DataBind();
            string userId = Request.QueryString["UserId"];
            string medalId = Request.QueryString["MedalId"];
            string query = null;
            if (medalId != null)
            {
                query = "select * from V_MedalSon where UserId='" + userId + "' and MedalId='" + medalId + "' order by WriteTime desc" ;
            }
            else
            {
                query = "select * from V_MedalSon where UserId='" + userId + "' order by WriteTime desc";
            }

            this.gridView1.DataSource = db2.ExecuteQuery<V_MedalSon>(query);

            this.gridView1.DataBind();
            //List<V_MedalSon> lsUsers = db4.V_MedalSon.ToList();
            //this.gridView1.DataSource = lsUsers;
            //this.DataBind();
        }
    }
}