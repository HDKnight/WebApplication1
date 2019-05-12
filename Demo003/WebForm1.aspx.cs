using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo003
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IsPostBack:判断页面是首次请求，还是回传请求。如果是首次请求，返回false；回传请求，返回true。
            if (!this.IsPostBack)
            {
                this.textUserName.Text = "admin";
            }
            else
            {
                this.textUserName.Text = "";
            }

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            this.text2.Value = DateTime.Now.ToString();
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            this.textUserName.Text = DateTime.Now.ToString();
        }

        protected void textUserName_TextChanged(object sender, EventArgs e)
        {
            Response.Write("文本框的值发生改变");
        }
    }
}