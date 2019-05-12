using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 用户控件的使用
{
    public partial class login : System.Web.UI.UserControl
    {
        public string Username
        {
            set { this.textUserName.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}