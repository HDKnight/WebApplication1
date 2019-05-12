using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 单选按钮与复选框
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cb1.Checked = true;
            this.rbMale.Checked = true;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Write(cb1.Text);
        }
    }
}