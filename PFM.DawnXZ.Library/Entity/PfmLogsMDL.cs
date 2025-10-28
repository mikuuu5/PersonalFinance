using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 日志信息
    /// </summary>
    [Serializable]
    public class PfmLogsMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmLogsMDL()
        { }
        #endregion

        #region 私有字段
        private long _logId;
        private DateTime _logTime;
        private string _logTable;
        private string _logAction;
        private string _logRemark;
        private string _logUname;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long LogId
        {
            get { return _logId; }
            set { _logId = value; RaisePropertyChanged("LogId"); }
        }

        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime LogTime
        {
            get { return _logTime; }
            set { _logTime = value; RaisePropertyChanged("LogTime"); }
        }

        /// <summary>
        /// 记录表名
        /// </summary>
        public string LogTable
        {
            get { return _logTable; }
            set { _logTable = value; RaisePropertyChanged("LogTable"); }
        }

        /// <summary>
        /// 记录动作
        /// </summary>
        public string LogAction
        {
            get { return _logAction; }
            set { _logAction = value; RaisePropertyChanged("LogAction"); }
        }

        /// <summary>
        /// 记录备注
        /// </summary>
        public string LogRemark
        {
            get { return _logRemark; }
            set { _logRemark = value; RaisePropertyChanged("LogRemark"); }
        }

        /// <summary>
        /// 操作用户
        /// </summary>
        public string LogUname
        {
            get { return _logUname; }
            set { _logUname = value; RaisePropertyChanged("LogUname"); }
        }

        #endregion
    }
}
