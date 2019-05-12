using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo001
{
    /// <summary>
    /// sever 的摘要说明
    /// </summary>
    public class sever : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //7.服务端获得客户端以Ajax请求发送过来的数据
            string username = context.Request.QueryString["username"];
            string pwd = context.Request.QueryString["pwd"];

            string msg = string.Empty;
            //8.在服务器端做业务处理
            if(username == "admin" && pwd == "123")
            {
                msg = "ok!";
            }
            else
            {
                msg = "error!";
            }


            context.Response.ContentType = "text/plain";
            context.Response.Write(msg);
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