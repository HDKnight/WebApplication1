using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML格式字符串解析
{
    class Program
    {
        const string xmlStr = "<DETECT_ITEM RuleID='007' Caption='整车装备'>" +
                             "<RULE name='1' caption='1' LogicalOperator='and'>" +
                                 "<ITEM ID = '1' LogicalOperator='与' KeyWord='cllx' Operator='IN' ComparingValue='B11,B12,B13,B14,B15,B16,B17' DataType='String' />" +
                                 "<ITEM ID = '2' LogicalOperator='与' KeyWord='zzl' Operator='&lt;=' ComparingValue='10000' DataType='Int' />" +
                             "</RULE>" +
                           "</DETECT_ITEM>";
        static void Main(string[] args)
        {
            Console.WriteLine(ReWriteXML(xmlStr));
            Console.ReadKey();
        }

        private static string ReWriteXML(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            var rowNoteList = doc.SelectNodes("/DETECT_ITEM/RULE");
            if (rowNoteList != null)
            {
                foreach (XmlNode rowNode in rowNoteList)
                {
                    var fieldNodeList = rowNode.ChildNodes;

                    foreach (XmlNode courseNode in fieldNodeList)
                    {
                        if (courseNode.Attributes != null)
                        {
                            //Console.Write(courseNode.Attributes["ID"].Value);
                            //Console.Write("\t");
                            //Console.Write(courseNode.Attributes["LogicalOperator"].Value);
                            //Console.Write("\t");
                            //Console.Write(courseNode.Attributes["KeyWord"].Value);
                            //Console.Write("\t");
                            //Console.Write(courseNode.Attributes["Operator"].Value);
                            //Console.Write("\t");
                            //Console.Write(courseNode.Attributes["ComparingValue"].Value);
                            //Console.Write("\t");
                            //Console.Write(courseNode.Attributes["DataType"].Value);
                            //Console.Write("\r\n");
                            string str = "\n<!-- " + GetKeyWord(courseNode.Attributes["KeyWord"].Value) + GetOperator(courseNode.Attributes["Operator"].Value) + courseNode.Attributes["ComparingValue"].Value + " -->\n";
                            string str1 = "<ITEM ID = " + "'" + courseNode.Attributes["ID"].Value + "'";
                            int index = xml.IndexOf(str1);
                            xml = xml.Insert(index, str);
                            
                        }
                    }
                }
            }
            xml = System.Text.RegularExpressions.Regex.Replace(xml, "<DETECT_ITEM", "");//切割字符串，去掉"<DETECT_ITEM"子字符串
            return xml;
        }

        private static string GetKeyWord(string code)
        {
            string keyword = "";
            switch (code)
            {
                case "jylb": keyword = "检验类别"; break;
                case "cllx": keyword = "车辆类型"; break;
                case "zzl": keyword = "总质量"; break;
                case "ccdjrq": keyword = "生产日期"; break;
                case "ccrq": keyword = "初次登记日期"; break;
                case "cwkc": keyword = "整车长度"; break;
                case "cwkk": keyword = "整车宽度"; break;
                case "cwkg": keyword = "整车高度"; break;
                case "IsHaveJSS": keyword = "三轮车是否带驾驶室"; break;
                case "SYXZStr": keyword = "使用性质"; break;
                case "ZKRS": keyword = "载客人数"; break;
                case "UseFulife": keyword = "使用年限"; break;
                case "Reareng": keyword = "发动机是否后置（0-否，1-是）"; break;
                case "IsHaveHX": keyword = "是否带货箱（0-否，1-是）"; break;
                case "IsHaveLB": keyword = "是否带栏板（0-否，1-是）"; break;
                case "YWLXID": keyword = "业务类型（0-申请，1-在用）"; break;
                case "BrakeFS": keyword = "制动方式（0-液压，1-气压）"; break;
                case "Fuel": keyword = "燃油类型（0-汽，1-柴）"; break;
                default: keyword = "ERROR"; break;
            }
            return keyword;
        }
        private static string GetOperator(String code)
        {
            string ope = "";
            switch (code)
            {
                case ">": ope = "大于于"; break;
                case ">=": ope = "大于等于"; break;
                case "=": ope = "等于"; break;
                case "<": ope = "小于"; break;
                case "<=": ope = "小于等于"; break;
                case "!=": ope = "不等于"; break;
                case "IN": ope = "有"; break;
                case "NOT IN": ope = "没有"; break;
                default: ope = "ERROR"; break;
            }
            return ope;
        }
    }
}
