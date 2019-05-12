﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo002
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.labCurrentName.Text = (string)this.Session["currentName"];
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx", true);
        }
    }
}