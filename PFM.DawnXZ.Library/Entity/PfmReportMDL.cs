using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 报表信息
    /// </summary>
    [Serializable]
    public class PfmReportMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmReportMDL()
        { }
        #endregion

        #region 私有字段
        private long _rptId;
        private byte _dictMark;
        private DateTime _rptTime;
        private DateTime _rptDate;
        private byte _rptState;
        private string _rptName;
        private string _rptMemo;
        private int _rptBkFd01;
        private byte _rptBkFd02;
        private string _rptBkFd03;
        private string _rptBkFd04;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long RptId
        {
            get { return _rptId; }
            set { _rptId = value; RaisePropertyChanged("RptId"); }
        }

        /// <summary>
        /// 账务字典标识
        /// </summary>
        public byte DictMark
        {
            get { return _dictMark; }
            set { _dictMark = value; RaisePropertyChanged("DictMark"); }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime RptTime
        {
            get { return _rptTime; }
            set { _rptTime = value; RaisePropertyChanged("RptTime"); }
        }

        /// <summary>
        /// 报表日期
        /// </summary>
        public DateTime RptDate
        {
            get { return _rptDate; }
            set { _rptDate = value; RaisePropertyChanged("RptDate"); }
        }

        /// <summary>
        /// 报表状态
        /// </summary>
        public byte RptState
        {
            get { return _rptState; }
            set { _rptState = value; RaisePropertyChanged("RptState"); }
        }

        /// <summary>
        /// 报表名称
        /// </summary>
        public string RptName
        {
            get { return _rptName; }
            set { _rptName = value; RaisePropertyChanged("RptName"); }
        }

        /// <summary>
        /// 报表备忘
        /// </summary>
        public string RptMemo
        {
            get { return _rptMemo; }
            set { _rptMemo = value; RaisePropertyChanged("RptMemo"); }
        }

        /// <summary>
        /// 保留字段01
        /// </summary>
        public int RptBkFd01
        {
            get { return _rptBkFd01; }
            set { _rptBkFd01 = value; RaisePropertyChanged("RptBkFd01"); }
        }

        /// <summary>
        /// 保留字段02
        /// </summary>
        public byte RptBkFd02
        {
            get { return _rptBkFd02; }
            set { _rptBkFd02 = value; RaisePropertyChanged("RptBkFd02"); }
        }

        /// <summary>
        /// 保留字段03
        /// </summary>
        public string RptBkFd03
        {
            get { return _rptBkFd03; }
            set { _rptBkFd03 = value; RaisePropertyChanged("RptBkFd03"); }
        }

        /// <summary>
        /// 保留字段04
        /// </summary>
        public string RptBkFd04
        {
            get { return _rptBkFd04; }
            set { _rptBkFd04 = value; RaisePropertyChanged("RptBkFd04"); }
        }

        #endregion
    }
}
