//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace 反射
//{
//    public class SQLHelper
//    {
//        public static string connStr = "Data Source=DONG_ZI_LI;Initial Catalog=RjbTest;User=sa;Password=Admin1234";

//        #region 获取SqlConnection对象
//        private static SqlConnection GetConn()
//        {
//            //构建连接字符串 
//            SqlConnection conn = new SqlConnection(connStr);
//            return conn;
//        }
//        #endregion

//        /// <summary>
//        /// DataReader读取数据（使用完SqlDataReader一定要关闭，否则会造成连接池溢出）
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <param name="para"></param>
//        /// <returns></returns>
//        public static List<object> DataReader(object obj, string sql, SqlParameter[] param)
//        {
//            SqlConnection conn = GetConn();
//            SqlDataReader sdr = null;
//            //构建Command对象
//            SqlCommand comm = new SqlCommand(sql, conn);
//            try
//            {
//                //将参数添加到command对象中
//                comm.Parameters.AddRange(param);
//                conn.Open();
//                //执行语句
//                sdr = comm.ExecuteReader();
//                //return sdr;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                comm.Parameters.Clear();
//                comm.Dispose();
//            }
//            List<obj.GetType()> list = new List<obj.GetType()>();
//            int num = ReflectionUtils.getProperties(obj).Count;
//            using (sdr)
//            {
                
//                while (sdr.Read())
//                {
//                    ClassInfo ci = new ClassInfo();

//                    for (int i = 0; i < num; i++)
//                    {
//                        ci.value = sdr[i];

//                    }
//                }
//            }

//        }


//        /// <summary>
//        /// 执行增删改操作
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <returns></returns>
//        public static int Execute(string sql)
//        {
//            SqlConnection conn = GetConn();
//            //构建Command对象
//            SqlCommand comm = new SqlCommand(sql, conn);
//            try
//            {
//                conn.Open();
//                //执行sql语句，并返回受影响的行数
//                return comm.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                comm.Parameters.Clear();
//                comm.Dispose();
//                conn.Close();
//            }
//        }

//    }
//}
