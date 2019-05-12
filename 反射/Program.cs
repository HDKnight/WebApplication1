using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            MedalShoppingEntity ms = new MedalShoppingEntity();
            //ms.GoodsID = 12345;
            //ms.GoodsName = "洗衣液";

            //Console.WriteLine(ReflectionUtils.getProperties(ms));
            foreach (ClassInfo ci in ReflectionUtils.getProperties(ms))
            {
                Console.WriteLine(ci.name + "," + ci.type + "," + ci.value);
            }

            Console.ReadLine();
        }
    }
}
