using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 文件的上传与下载
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (!this.fileUpload1.HasFile)
            {
                this.ClientScript.RegisterStartupScript(
                this.GetType(),
                Guid.NewGuid().ToString(),
                "alert('请选择上传文件！')",
                true);
                return;
            }
            
            string fileName = this.fileUpload1.FileName;
            string path = "~/uploadFolder/" + fileName;

            path = this.Server.MapPath(path);

            HttpPostedFile file = this.fileUpload1.PostedFile;
            long fileLength = file.InputStream.Length;
            if(fileLength > 10 * 1024)
            {
                this.ClientScript.RegisterStartupScript(
                this.GetType(),
                Guid.NewGuid().ToString(),
                "alert('文件大小超出20KB，请选择较小的文件上传！')",
                true);
                return;
            }

            this.fileUpload1.SaveAs(path);
            this.ClientScript.RegisterStartupScript(
                this.GetType(),
                Guid.NewGuid().ToString(),
                "alert('" + fileName + "上传成功！')",
                true);

        }
    } 
}