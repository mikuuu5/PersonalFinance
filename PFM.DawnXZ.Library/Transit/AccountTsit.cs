using System;
using PFM.DawnXZ.Library.BLL;

namespace PFM.DawnXZ.Library.Transit
{
    /// <summary>
    /// 账务账目
    /// </summary>
    public class AccountTsit
    {
        /// <summary>
        /// 取得账务账目名称
        /// </summary>
        /// <param name="accId">账目编号</param>
        /// <returns></returns>
        public static string GetName(int accId)
        {
            return PfmAccountsBLL.Select(accId).AccName;
        }
    }
}
