using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 母版页.Models;

namespace 母版页
{
    public partial class index2 : System.Web.UI.Page
    {

        public string medalId = null;
        string sortType = null;
        //string strText = null;
        //DataClasses2DataContext db = new DataClasses2DataContext();
        //SortDateDataContext db = new SortDateDataContext();
        //string StrCon = "Data Source=(local);Database=MedalSystem;Uid=wa;Pwd=123;";
        string StrCon = "Data Source=DONG_ZI_LI;Initial Catalog=MedalSystem;Integrated Security=True";
        V_GZKRZLinqDataContext gzkrzDB;
        V_GZKRYLinqDataContext gzkryDB;
        V_GZKRRLinqDataContext gzkrrDB;
        V_KFZXZLinqDataContext kfzxzDB;
        V_KFZXYLinqDataContext kfzxyDB;
        V_KFZXRLinqDataContext kfzxrDB;
        V_RJYLZLinqDataContext rjylzDB;
        V_RJYLYLinqDataContext rjylyDB;
        V_RJYLRLinqDataContext rjylrDB;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string userId = this.Session["currentId"].ToString();
                }
                catch
                {
                    Server.Transfer("index.html", true);
                }
            }

            medalId = Request.QueryString["MedalId"];
            sortType = Request.QueryString["SortType"];
            
            LoadDate();
        }

        private void LoadDate()
        {
            //工作狂人总排行
            if (medalId.Equals("1") && sortType.Equals("1"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "工作狂人总排行";
                gzkrzDB = new V_GZKRZLinqDataContext(StrCon);
                var result = (from info in gzkrzDB.V_GZKRZ
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();

            }
            //工作狂人月排行
            else if (medalId.Equals("1") && sortType.Equals("2"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "工作狂人月排行";
                gzkryDB = new V_GZKRYLinqDataContext(StrCon);
                var result = (from info in gzkryDB.V_GZKRY
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();

            }
            //工作狂人日排行
            else if (medalId.Equals("1") && sortType.Equals("3"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "工作狂人日排行";
                gzkrrDB = new V_GZKRRLinqDataContext(StrCon);
                var result = (from info in gzkrrDB.V_GZKRR
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();

            }
            //客服之星总排行
            else if (medalId.Equals("7") && sortType.Equals("1"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "客服之星总排行";
                kfzxzDB = new V_KFZXZLinqDataContext(StrCon);
                var result = (from info in kfzxzDB.V_KFZXZ
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }
            //客服之星月排行
            else if (medalId.Equals("7") && sortType.Equals("2"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "客服之星月排行";
                kfzxyDB = new V_KFZXYLinqDataContext(StrCon);
                var result = (from info in kfzxyDB.V_KFZXY
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }
            //客服之星日排行
            else if (medalId.Equals("7") && sortType.Equals("3"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "客服之星日排行";
                kfzxrDB = new V_KFZXRLinqDataContext(StrCon);
                var result = (from info in kfzxrDB.V_KFZXR
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }
            //日积月累总排行
            else if (medalId.Equals("8") && sortType.Equals("1"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "日积月累总排行";
                rjylzDB = new V_RJYLZLinqDataContext(StrCon);
                var result = (from info in rjylzDB.V_RJYLZ
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }
            //日积月累月排行
            else if (medalId.Equals("8") && sortType.Equals("2"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "日积月累月排行";
                rjylyDB = new V_RJYLYLinqDataContext(StrCon);
                var result = (from info in rjylyDB.V_RJYLY
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }
            //日积月累日排行
            else if (medalId.Equals("8") && sortType.Equals("3"))
            {
                lable1.Text = medalId + "-" + sortType;
                Label2.Text = "日积月累日排行";
                rjylrDB = new V_RJYLRLinqDataContext(StrCon);
                var result = (from info in rjylrDB.V_RJYLR
                              select new
                              {
                                  info.排名,
                                  info.员工编号,
                                  info.姓名,
                                  info.积分数,
                                  info.时间

                              }).Distinct().ToList();
                this.gridView1.DataSource = result;
                this.gridView1.DataBind();
            }

            else
            {
                lable1.Text = "Error!";
            }
            

        }
        
        //protected string test()
        //{
        //    //if (gridView1.FindControl("sendNumber") is TextBox sendNumber)
        //    //{
        //    //    lable1.Text = sendNumber.Text;
        //    //    return "赠送成功！";
        //    //}
        //    Label4.Text = "text1.Text" + " ";
        //    try
        //    {
        //        string text1= "的VB结";
        //        text1 = ((TextBox)gridView1.Rows[1].FindControl("sendNumber")).Text.Trim();
                
        //        return "赠送成功！ "+ text1 + "fvdfh";
        //    }
        //    catch
        //    {
        //        return "执行失败！";
        //    }
        //}
    }
}