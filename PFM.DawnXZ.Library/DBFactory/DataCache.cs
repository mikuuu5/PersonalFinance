// =================================================================== 
// 工厂（PFM.DawnXZ.Library.DBFactory）项目
// 文件名称：DataCache.cs
// 项目名称：个人财务管理系统
// ===================================================================
using System;
using System.Collections;

namespace PFM.DawnXZ.Library.DBFactory
{
    /// <summary>
    /// 数据缓存对象
    /// </summary>
    public class DataCache
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DataCache()
        { }

        /// <summary>
        /// 缓存对象的集合
        /// </summary>
        private static Hashtable Hashtable = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// 获得缓存对象
        /// </summary>
        /// <param name="CacheKey">键</param>
        /// <returns>缓存对象</returns>
        public static object GetCache(string CacheKey)
        {
            return DataCache.Hashtable[CacheKey];
        }

        /// <summary>
        /// 设置缓存对象
        /// </summary>
        /// <param name="CacheKey">键</param>
        /// <param name="objObject">要被缓存的对象</param>
        public static void SetCache(string CacheKey, object objObject)
        {
            if (!DataCache.Hashtable.Contains(CacheKey))
                DataCache.Hashtable.Add(CacheKey, objObject);
        }
    }
}
