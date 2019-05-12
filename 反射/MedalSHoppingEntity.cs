using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// MedalShoppingEntity 的摘要说明
    /// </summary>
    public class MedalShoppingEntity
    {
        public MedalShoppingEntity()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int GoodsID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string GoodsType { get; set; }
        /// <summary>
        /// 商品每月最大兑换量
        /// </summary>
        public int MouthDHL { get; set; }
        /// <summary>
        /// 兑换一件商品所需的勋章数量
        /// </summary>
        public int DHXZValue { get; set; }
        /// <summary>
        /// 库存量
        /// </summary>
        public int KCValue { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string GoodsDetail { get; set; }
        /// <summary>
        /// 商品参与抽奖时所处的等级
        /// </summary>
        public int Level { get; set; }

    }
}
