using System;
using System.Reflection;
using PFM.DawnXZ.Library.IDAL;
namespace PFM.DawnXZ.Library.DBFactory
{
	//数据层工厂
	public static class DALFactory
	{
		private static readonly string _assemblyPath = "PFM.DawnXZ.Library";
		// 添加配置常量，便于维护
		private const string SQL_SERVER_DAL_NAMESPACE = ".SqlServerDAL.";
		// 缓存键前缀，避免键冲突
		private const string CACHE_KEY_PREFIX = "DAL_";
		//通过反射机制，实例化接口对象
		/// <param name="cacheKey">缓存键</param>
		/// <param name="typeName">完整类型名称</param>
		/// <returns>接口对象</returns>
		private static object GetInstance(string cacheKey, string typeName)
		{
			// 尝试从缓存获取
			object instance = DataCache.GetCache(cacheKey);
			if (instance != null)
			{
				return instance;
			}
			try
			{
				// 创建实例
				instance = Assembly.Load(_assemblyPath).CreateInstance(typeName);
				if (instance != null)
				{
					// 设置缓存
					DataCache.SetCache(cacheKey, instance);
				}
				return instance;
			}
			catch (Exception ex)
			{
				// 记录详细异常信息
				throw new InvalidOperationException($"创建类型 {typeName} 的实例失败", ex);
			}
		}
		//通用的DAL实例创建方法
		/// <typeparam name="TInterface">接口类型</typeparam>
		/// <param name="dalClassName">DAL类名</param>
		/// <returns>接口实例</returns>
		private static TInterface CreateDALInstance<TInterface>(string dalClassName)
			where TInterface : class
		{
			string typeName = _assemblyPath + SQL_SERVER_DAL_NAMESPACE + dalClassName;
			string cacheKey = CACHE_KEY_PREFIX + dalClassName;
			object instance = GetInstance(cacheKey, typeName);
			return instance as TInterface ??
				   throw new InvalidCastException($"类型 {typeName} 无法转换为 {typeof(TInterface).Name}");
		}
		public static IPfmAccountsDAL PfmAccountsDALInstance()
			=> CreateDALInstance<IPfmAccountsDAL>("PfmAccountsDAL");
		public static IPfmDictionaryDAL PfmDictionaryDALInstance()
			=> CreateDALInstance<IPfmDictionaryDAL>("PfmDictionaryDAL");
		public static IPfmErrorDAL PfmErrorDALInstance()
			=> CreateDALInstance<IPfmErrorDAL>("PfmErrorDAL");
		public static IPfmIaeCategoryDAL PfmIaeCategoryDALInstance()
			=> CreateDALInstance<IPfmIaeCategoryDAL>("PfmIaeCategoryDAL");
		public static IPfmIaeDetailedDAL PfmIaeDetailedDALInstance()
			=> CreateDALInstance<IPfmIaeDetailedDAL>("PfmIaeDetailedDAL");
		public static IPfmIaeItemsDAL PfmIaeItemsDALInstance()
			=> CreateDALInstance<IPfmIaeItemsDAL>("PfmIaeItemsDAL");
		public static IPfmLogsDAL PfmLogsDALInstance()
			=> CreateDALInstance<IPfmLogsDAL>("PfmLogsDAL");
		public static IPfmMemberDAL PfmMemberDALInstance()
			=> CreateDALInstance<IPfmMemberDAL>("PfmMemberDAL");
		public static IPfmReportDAL PfmReportDALInstance()
			=> CreateDALInstance<IPfmReportDAL>("PfmReportDAL");
		public static IPfmReportRecordDAL PfmReportRecordDALInstance()
			=> CreateDALInstance<IPfmReportRecordDAL>("PfmReportRecordDAL");
	}
}
