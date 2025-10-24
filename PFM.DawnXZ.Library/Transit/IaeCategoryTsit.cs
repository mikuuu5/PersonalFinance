using System;
using PFM.DawnXZ.Library.BLL;
namespace PFM.DawnXZ.Library.Transit
{
    //收支类别数据传输类
    public class IaeCategoryTsit
    {
        //获取收支类别名称
        /// <param name="catId">类别编号</param>
        /// <returns>类别名称，未找到时返回空字符串</returns>
        public static string GetName(int catId)
        {
            if (catId <= 0)
                return string.Empty;
            try
            {
                var category = PfmIaeCategoryBLL.Select(catId);
                return category?.CatName ?? string.Empty;
            }
            catch (Exception ex)
            {
                // 这里应该记录日志
                System.Diagnostics.Debug.WriteLine($"获取类别名称失败 (ID: {catId}): {ex.Message}");
                return string.Empty;
            }
        }
        //安全获取收支类别名称（带默认值）
        /// <param name="catId">类别编号</param>
        /// <param name="defaultName">默认名称</param>
        /// <returns>类别名称或默认值</returns>
        public static string GetName(int catId, string defaultName)
        {
            if (catId <= 0)
                return defaultName;
            try
            {
                var category = PfmIaeCategoryBLL.Select(catId);
                return category?.CatName ?? defaultName;
            }
            catch
            {
                return defaultName;
            }
        }
    }
}
