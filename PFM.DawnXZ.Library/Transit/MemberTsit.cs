using System;
using PFM.DawnXZ.Library.BLL;

namespace PFM.DawnXZ.Library.Transit
{
    /// <summary>
    /// 账务成员
    /// </summary>
    public class MemberTsit
    {
        /// <summary>
        /// 取得账务成员名称
        /// </summary>
        /// <param name="mbrId">成员编号</param>
        /// <returns></returns>
        public static string GetName(int mbrId)
        {
            return PfmMemberBLL.Select(mbrId).MbrName;
        }
    }
}
