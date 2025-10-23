using System;
using PFM.DawnXZ.Library.BLL;

namespace PFM.DawnXZ.Library.Transit
{
    /// <summary>
    /// 收支类别
    /// </summary>
    public class IaeCategoryTsit
    {
        /// <summary>
        /// 取得收支类别名称
        /// </summary>
        /// <param name="catId">类别编号</param>
        /// <returns></returns>
        public static string GetName(int catId)
        {
            return PfmIaeCategoryBLL.Select(catId).CatName;
        }
    }
}
