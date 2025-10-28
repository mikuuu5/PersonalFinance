using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 错误信息实体类
    /// </summary>
    [Serializable]
    public class PfmErrorMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmErrorMDL()
        { }
        #endregion

        #region 私有字段
        private long _errId;
        private DateTime _errTime;
        private string _errPage;
        private string _errMessage;
        private string _errTargetSite;
        private string _errStackTrace;
        private string _errSource;
        private string _errIp;
        private string _errName;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long ErrId
        {
            get { return _errId; }
            set
            {
                if (_errId != value)
                {
                    _errId = value;
                    RaisePropertyChanged("ErrId");
                }
            }
        }

        /// <summary>
        /// 错误时间
        /// </summary>
        public DateTime ErrTime
        {
            get { return _errTime; }
            set
            {
                if (_errTime != value)
                {
                    _errTime = value;
                    RaisePropertyChanged("ErrTime");
                }
            }
        }

        /// <summary>
        /// 页面名称
        /// </summary>
        public string ErrPage
        {
            get { return _errPage; }
            set
            {
                if (_errPage != value)
                {
                    _errPage = value;
                    RaisePropertyChanged("ErrPage");
                }
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMessage
        {
            get { return _errMessage; }
            set
            {
                if (_errMessage != value)
                {
                    _errMessage = value;
                    RaisePropertyChanged("ErrMessage");
                }
            }
        }

        /// <summary>
        /// 错误目标
        /// </summary>
        public string ErrTargetSite
        {
            get { return _errTargetSite; }
            set
            {
                if (_errTargetSite != value)
                {
                    _errTargetSite = value;
                    RaisePropertyChanged("ErrTargetSite");
                }
            }
        }

        /// <summary>
        /// 错误堆栈跟踪
        /// </summary>
        public string ErrStackTrace
        {
            get { return _errStackTrace; }
            set
            {
                if (_errStackTrace != value)
                {
                    _errStackTrace = value;
                    RaisePropertyChanged("ErrStackTrace");
                }
            }
        }

        /// <summary>
        /// 错误源
        /// </summary>
        public string ErrSource
        {
            get { return _errSource; }
            set
            {
                if (_errSource != value)
                {
                    _errSource = value;
                    RaisePropertyChanged("ErrSource");
                }
            }
        }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string ErrIp
        {
            get { return _errIp; }
            set
            {
                if (_errIp != value)
                {
                    _errIp = value;
                    RaisePropertyChanged("ErrIp");
                }
            }
        }

        /// <summary>
        /// 操作用户
        /// </summary>
        public string ErrName
        {
            get { return _errName; }
            set
            {
                if (_errName != value)
                {
                    _errName = value;
                    RaisePropertyChanged("ErrName");
                }
            }
        }

        #endregion

        #region 重写方法
        /// <summary>
        /// 重写ToString方法
        /// </summary>
        public override string ToString()
        {
            return string.Format("错误ID:{0} 时间:{1} 页面:{2}",
                _errId, _errTime.ToString("yyyy-MM-dd HH:mm:ss"), _errPage);
        }
        #endregion

        #region 便捷方法
        /// <summary>
        /// 获取简化的错误信息
        /// </summary>
        public string GetSimpleErrorMessage()
        {
            if (string.IsNullOrEmpty(_errMessage))
                return "无错误信息";

            return _errMessage.Length > 100 ? _errMessage.Substring(0, 100) + "..." : _errMessage;
        }

        /// <summary>
        /// 是否包含堆栈跟踪信息
        /// </summary>
        public bool HasStackTrace
        {
            get { return !string.IsNullOrEmpty(_errStackTrace); }
        }
        #endregion
    }
}
