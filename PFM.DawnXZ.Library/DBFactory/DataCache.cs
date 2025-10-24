using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
namespace PFM.DawnXZ.Library.DBFactory
{
    //数据缓存对象
    public class DataCache
    {
        private static readonly ConcurrentDictionary<string, CacheItem> _cache =new ConcurrentDictionary<string, CacheItem>();
        private static readonly Timer _cleanupTimer;
        private static readonly object _lockObject = new object();
        // 默认缓存过期时间（分钟）
        public static TimeSpan DefaultExpiration { get; set; } = TimeSpan.FromMinutes(30);
        // 清理间隔（分钟）
        public static TimeSpan CleanupInterval { get; set; } = TimeSpan.FromMinutes(5);
        static DataCache()
        {
            // 定期清理过期缓存
            _cleanupTimer = new Timer(CleanExpiredCache, null,CleanupInterval, CleanupInterval);
        }
        //获得缓存对象
        /// <param name="cacheKey">键</param>
        /// <returns>缓存对象</returns>
        public static object GetCache(string cacheKey)
        {
            if (string.IsNullOrEmpty(cacheKey))
                return null;
            if (_cache.TryGetValue(cacheKey, out var cacheItem))
            {
                if (cacheItem.IsExpired)
                {
                    RemoveCache(cacheKey);
                    return null;
                }
                cacheItem.LastAccessTime = DateTime.Now;
                return cacheItem.Value;
            }
            return null;
        }
        //获得强类型缓存对象
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="cacheKey">键</param>
        /// <returns>缓存对象</returns>
        public static T GetCache<T>(string cacheKey) where T : class
        {
            return GetCache(cacheKey) as T;
        }
        //设置缓存对象
        /// <param name="cacheKey">键</param>
        /// <param name="objObject">要被缓存的对象</param>
        /// <param name="expiration">过期时间</param>
        public static void SetCache(string cacheKey, object objObject, TimeSpan? expiration = null)
        {
            if (string.IsNullOrEmpty(cacheKey) || objObject == null)
                return;
            var cacheItem = new CacheItem
            {
                Value = objObject,
                CreatedTime = DateTime.Now,
                LastAccessTime = DateTime.Now,
                Expiration = expiration ?? DefaultExpiration
            };
            _cache.AddOrUpdate(cacheKey, cacheItem, (key, existing) => cacheItem);
        }
        //移除缓存
        /// <param name="cacheKey">键</param>
        public static bool RemoveCache(string cacheKey)
        {
            return _cache.TryRemove(cacheKey, out _);
        }
        //检查缓存是否存在
        /// <param name="cacheKey">键</param>
        /// <returns>是否存在</returns>
        public static bool Contains(string cacheKey)
        {
            return _cache.ContainsKey(cacheKey) && !_cache[cacheKey].IsExpired;
        }
        //清空所有缓存
        public static void Clear()
        {
            _cache.Clear();
        }
        //获取缓存统计信息
        public static CacheStatistics GetStatistics()
        {
            var statistics = new CacheStatistics();
            foreach (var item in _cache.Values)
            {
                statistics.TotalCount++;
                if (item.IsExpired)
                {
                    statistics.ExpiredCount++;
                }
            }
            return statistics;
        }
        //清理过期缓存
        private static void CleanExpiredCache(object state)
        {
            var expiredKeys = new List<string>();
            foreach (var pair in _cache)
            {
                if (pair.Value.IsExpired)
                {
                    expiredKeys.Add(pair.Key);
                }
            }
            foreach (var key in expiredKeys)
            {
                _cache.TryRemove(key, out _);
            }
        }
        //释放资源
        public static void Dispose()
        {
            _cleanupTimer?.Dispose();
            Clear();
        }
        //缓存项
        private class CacheItem
        {
            public object Value { get; set; }
            public DateTime CreatedTime { get; set; }
            public DateTime LastAccessTime { get; set; }
            public TimeSpan Expiration { get; set; }
            public bool IsExpired => DateTime.Now - LastAccessTime > Expiration;
        }
        // 缓存统计信息
        public class CacheStatistics
        {
            public int TotalCount { get; set; }
            public int ExpiredCount { get; set; }
            public int ValidCount => TotalCount - ExpiredCount;
        }
    }
}
