using System;
using PFM.DawnXZ.Library.BLL;
namespace PFM.DawnXZ.Library.Transit
{
    //账务成员
    public class MemberTsit
    {
        //取得账务成员名称
        /// <param name="mbrId">成员编号</param>
        /// <returns></returns>
        public static string GetName(int mbrId)
        {
            return PfmMemberBLL.Select(mbrId).MbrName;
        }
    }
}
