using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GridView控件.Models;

namespace GridView控件
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSdudent();
            }
        }

        private void LoadSdudent()
        {
            List<Users_Group> lsUsers = db.Users_Group.ToList();
            this.gridView1.DataSource = lsUsers;
            this.DataBind();
        }
    }
}