using DawnXZ.WebUtility;
using PFM.DawnXZ.Library.BLL;
using PFM.DawnXZ.Library.Entity;
using System;
using System.Threading;
namespace PFM.DawnXZ.Library.Transit
{
    //错误日志处理类
    public class ErrorTsit
    {
        #region 构造函数
        //数据层实例化
        public ErrorTsit()
        { }
        #endregion
        #region 添加数据
        //添加一条新记录
        /// <param name="ex">异常对象</param>
        /// <returns>插入记录的ID，-1表示ThreadAbortException，-2表示其他错误</returns>
        public static int Insert(Exception ex)
        {
            // 忽略线程中止异常
            if (ex is ThreadAbortException)
                return -1;
            try
            {
                PfmErrorMDL errMdl = CreateErrorModel(ex);
                return PfmErrorBLL.Insert(errMdl);
            }
            catch (Exception logEx)
            {
                // 记录日志失败时的备选方案
                System.Diagnostics.Debug.WriteLine($"错误日志记录失败: {logEx.Message}");
                return -2;
            }
        }
        //根据异常创建错误模型
        /// <param name="ex">异常对象</param>
        /// <returns>错误模型</returns>
        private static PfmErrorMDL CreateErrorModel(Exception ex)
        {
            var actualException = ex.InnerException ?? ex;
            return new PfmErrorMDL
            {
                ErrTime = DateTime.Now,
                ErrPage = GetSafeString(actualException.HelpLink, "非法数据！（页面信息）"),
                ErrMessage = GetSafeString(actualException.Message, "非法数据！（错误信息）"),
                ErrTargetSite = GetSafeString(actualException.TargetSite?.ToString(), "非法数据！（异常方法）"),
                ErrStackTrace = GetSafeString(actualException.StackTrace, "非法数据！（表示形式）"),
                ErrSource = GetSafeString(actualException.Source, "非法数据！（数据源）"),
                ErrIp = GetIPs(),
                ErrName = "未登录"
            };
        }
        //安全获取字符串，避免空引用
        /// <param name="value">原字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>安全的字符串</returns>
        private static string GetSafeString(string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
        //获取IP地址，如出错默认为本地
        /// <returns>IP地址字符串</returns>
        private static string GetIPs()
        {
            try
            {
                return RequestHelper.GetIPAddress() ?? "127.0.0.1";
            }
            catch (Exception)
            {
                // 记录到系统日志
                return "127.0.0.1";
            }
        }
        #endregion
        #region 扩展方法
        //添加错误记录并返回格式化错误信息
        /// <param name="ex">异常对象</param>
        /// <param name="customMessage">自定义消息</param>
        /// <returns>错误ID和消息</returns>
        public static (int errorId, string message) InsertWithMessage(Exception ex, string customMessage = null)
        {
            int errorId = Insert(ex);
            string message = customMessage ?? "系统发生错误，请稍后重试。";
            return (errorId, message);
        }
        //添加带用户信息的错误记录
        /// <param name="ex">异常对象</param>
        /// <param name="userName">用户名</param>
        /// <returns>错误ID</returns>
        public static int InsertWithUser(Exception ex, string userName)
        {
            if (ex is ThreadAbortException)
                return -1;
            try
            {
                var errMdl = CreateErrorModel(ex);
                errMdl.ErrName = GetSafeString(userName, "未登录");
                return PfmErrorBLL.Insert(errMdl);
            }
            catch (Exception logEx)
            {
                System.Diagnostics.Debug.WriteLine($"错误日志记录失败: {logEx.Message}");
                return -2;
            }
        }
        #endregion
    }
}
