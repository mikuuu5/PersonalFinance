// =================================================================== 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFM.DawnXZ.Library.Transit
{
    /// <summary>
    /// 状态转换
    /// </summary>
    public class StatusTsit
    {
        /// <summary>
        /// 将对应状态值转换为中文显示
        /// </summary>
        /// <param name="status">状态值</param>
        /// <returns></returns>
        public static string StatusConvert(byte status)
        {
            string strTmp = "未知";
            switch (status)
            {
                case 0:
                    strTmp = "禁用";
                    break;
                case 1:
                    strTmp = "正常";
                    break;
                default:
                    break;
            }
            return strTmp;
        }
    }
}
