using System;
using PFM.DawnXZ.Library.BLL;
namespace PFM.DawnXZ.Library.Transit
{
    //账务账目
    public class AccountTsit
    {
        //取得账务账目名称
        /// <param name="accId">账目编号</param>
        /// <returns>账目名称，如果找不到则返回空字符串</returns>
        public static string GetName(int accId)
        {
            var account = PfmAccountsBLL.Select(accId);
            return account?.AccName ?? string.Empty;
        }
    }
}
