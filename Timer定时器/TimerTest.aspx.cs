using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Timer定时器
{
    public partial class TimerTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //这里可以操作你想做的事情，比如定时查询数据库
            Label1.Text = DateTime.Now.ToLongTimeString() + ":" + DateTime.Now.Millisecond;
            Label2.Text = DateTime.Now.ToLongTimeString() + ":" + DateTime.Now.Millisecond;
        }
    }
}