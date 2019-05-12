using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class ReflectionUtils
    {
        public static List<ClassInfo> getProperties<T>(T t)
        {
            //string tStr = string.Empty;
            if (t == null)
            {
                return null;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return null;
            }
            List<ClassInfo> list = new List<ClassInfo>();

            foreach (System.Reflection.PropertyInfo item in properties)
            {
                ClassInfo ci = new ClassInfo();
                ci.name = item.Name;
                ci.type = item.PropertyType;
                ci.value = item.GetValue(t, null);

                //string name = item.Name;
                //object value = item.GetValue(t, null);
                //object type = item.PropertyType;
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    //tStr += string.Format("{0}:{1},", name, type, value);
                    list.Add(ci);
                }
                else
                {
                    getProperties(ci.value);
                }
            }
            return list;
        }
    }
}
