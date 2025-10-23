using DawnXZ.WebUtility;
using PFM.DawnXZ.Library.BLL;
using PFM.DawnXZ.Library.Entity;
using System;

namespace PFM.DawnXZ.Library.Transit {
    /// <summary>
    /// 错误日志
    /// </summary>
    public class ErrorTsit
    {

        #region 构造函数
        /// <summary>
        /// 数据层实例化
        /// </summary>
        public ErrorTsit()
        { }
        #endregion

        #region 添加数据

        /// <summary>
        /// 添加一条新记录
        /// </summary>
        /// <param name="ex">错误包</param>
        /// <returns></returns>
        public static int Insert(Exception ex)
        {
            if ((ex is System.Threading.ThreadAbortException)) return -1;
            PfmErrorMDL errMdl = new PfmErrorMDL();
            if (ex.InnerException != null)
            {
                errMdl.ErrTime = System.DateTime.Now;
                errMdl.ErrPage = string.IsNullOrEmpty(ex.InnerException.HelpLink) == true ? "非法数据！（页面信息）" : ex.InnerException.HelpLink;
                errMdl.ErrMessage = string.IsNullOrEmpty(ex.InnerException.Message) == true ? "非法数据！（错误信息）" : ex.InnerException.Message;
                errMdl.ErrTargetSite = string.IsNullOrEmpty(ex.InnerException.TargetSite.ToString()) == true ? "非法数据！（异常方法）" : ex.InnerException.TargetSite.ToString();
                errMdl.ErrStackTrace = string.IsNullOrEmpty(ex.InnerException.StackTrace) == true ? "非法数据！（表示形式）" : ex.InnerException.StackTrace;
                errMdl.ErrSource = string.IsNullOrEmpty(ex.InnerException.Source) == true ? "非法数据！（数据源）" : ex.InnerException.Source;
                errMdl.ErrIp = GetIPs();
                errMdl.ErrName = "未登录";
            }
            else
            {
                errMdl.ErrTime = System.DateTime.Now;
                errMdl.ErrPage = string.IsNullOrEmpty(ex.HelpLink) == true ? "非法数据！（页面信息）" : ex.HelpLink;
                errMdl.ErrMessage = string.IsNullOrEmpty(ex.Message) == true ? "非法数据！（错误信息）" : ex.Message;
                errMdl.ErrTargetSite = string.IsNullOrEmpty(ex.TargetSite.ToString()) == true ? "非法数据！（异常方法）" : ex.TargetSite.ToString();
                errMdl.ErrStackTrace = string.IsNullOrEmpty(ex.StackTrace) == true ? "非法数据！（表示形式）" : ex.StackTrace;
                errMdl.ErrSource = string.IsNullOrEmpty(ex.Source) == true ? "非法数据！（数据源）" : ex.Source;
                errMdl.ErrIp = GetIPs();
                errMdl.ErrName = "未登录";
            }
            return PfmErrorBLL.Insert(errMdl);
        }
        /// <summary>
        /// 获取IP地址，如出错默认为本地
        /// </summary>
        /// <returns></returns>
        private static string GetIPs()
        {
            string strIP = "127.0.0.1";
            try
            {
                strIP = RequestHelper.GetIPAddress();
            }
            catch { }
            return strIP;
        }
        #endregion

    }
}
