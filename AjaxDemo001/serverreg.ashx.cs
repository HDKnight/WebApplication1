using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo001
{
    /// <summary>
    /// serverreg 的摘要说明
    /// </summary>
    public class serverreg : IHttpHandler
    {
        //SchoolDBDataContext db = new SchoolDBDataContext();
        public void ProcessRequest(HttpContext context)
        {
            string username = context.Request.QueryString["username"];
            string msg = string.Empty;
            //stuTbl stuObject = DBNull.stu
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}