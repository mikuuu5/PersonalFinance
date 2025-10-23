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

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        private long _logId;
        /// <summary>
        /// 系统编号
        /// </summary>
        public long LogId
        {
            get { return this._logId; }
            set
            {
                this._logId = value;
                RaisePropertyChanged("LogId");
            }
        }
        /// <summary>
        /// 记录时间
        /// </summary>
        private DateTime _logTime;
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime LogTime
        {
            get { return this._logTime; }
            set
            {
                this._logTime = value;
                RaisePropertyChanged("LogTime");
            }
        }
        /// <summary>
        /// 记录表名
        /// </summary>
        private string _logTable;
        /// <summary>
        /// 记录表名
        /// </summary>
        public string LogTable
        {
            get { return this._logTable; }
            set
            {
                this._logTable = value;
                RaisePropertyChanged("LogTable");
            }
        }
        /// <summary>
        /// 记录动作
        /// </summary>
        private string _logAction;
        /// <summary>
        /// 记录动作
        /// </summary>
        public string LogAction
        {
            get { return this._logAction; }
            set
            {
                this._logAction = value;
                RaisePropertyChanged("LogAction");
            }
        }
        /// <summary>
        /// 记录备注
        /// </summary>
        private string _logRemark;
        /// <summary>
        /// 记录备注
        /// </summary>
        public string LogRemark
        {
            get { return this._logRemark; }
            set
            {
                this._logRemark = value;
                RaisePropertyChanged("LogRemark");
            }
        }
        /// <summary>
        /// 操作用户
        /// </summary>
        private string _logUname;
        /// <summary>
        /// 操作用户
        /// </summary>
        public string LogUname
        {
            get { return this._logUname; }
            set
            {
                this._logUname = value;
                RaisePropertyChanged("LogUname");
            }
        }

        #endregion

    }
}
