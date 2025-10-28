using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 报表记录
    /// </summary>
    [Serializable]
    public class PfmReportRecordMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmReportRecordMDL()
        { }
        #endregion

        #region 私有字段
        private long _rrdId;
        private int _rptId;
        private int _mbrId;
        private int _accId;
        private DateTime _rrdAddTime;
        private decimal _rrdInSum;
        private int _rrdInCount;
        private decimal _rrdOutSum;
        private int _rrdOutCount;
        private decimal _rrdSum;
        private int _rrdBkFd01;
        private byte _rrdBkFd02;
        private string _rrdBkFd03;
        private string _rrdBkFd04;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long RrdId
        {
            get { return _rrdId; }
            set { _rrdId = value; RaisePropertyChanged("RrdId"); }
        }

        /// <summary>
        /// 报表编号
        /// </summary>
        public int RptId
        {
            get { return _rptId; }
            set { _rptId = value; RaisePropertyChanged("RptId"); }
        }

        /// <summary>
        /// 成员编号
        /// </summary>
        public int MbrId
        {
            get { return _mbrId; }
            set { _mbrId = value; RaisePropertyChanged("MbrId"); }
        }

        /// <summary>
        /// 账户编号
        /// </summary>
        public int AccId
        {
            get { return _accId; }
            set { _accId = value; RaisePropertyChanged("AccId"); }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime RrdAddTime
        {
            get { return _rrdAddTime; }
            set { _rrdAddTime = value; RaisePropertyChanged("RrdAddTime"); }
        }

        /// <summary>
        /// 收入总额
        /// </summary>
        public decimal RrdInSum
        {
            get { return _rrdInSum; }
            set { _rrdInSum = value; RaisePropertyChanged("RrdInSum"); }
        }

        /// <summary>
        /// 收入次数
        /// </summary>
        public int RrdInCount
        {
            get { return _rrdInCount; }
            set { _rrdInCount = value; RaisePropertyChanged("RrdInCount"); }
        }

        /// <summary>
        /// 支出总额
        /// </summary>
        public decimal RrdOutSum
        {
            get { return _rrdOutSum; }
            set { _rrdOutSum = value; RaisePropertyChanged("RrdOutSum"); }
        }

        /// <summary>
        /// 支出次数
        /// </summary>
        public int RrdOutCount
        {
            get { return _rrdOutCount; }
            set { _rrdOutCount = value; RaisePropertyChanged("RrdOutCount"); }
        }

        /// <summary>
        /// 收支总额
        /// </summary>
        public decimal RrdSum
        {
            get { return _rrdSum; }
            set { _rrdSum = value; RaisePropertyChanged("RrdSum"); }
        }

        /// <summary>
        /// 保留字段01
        /// </summary>
        public int RrdBkFd01
        {
            get { return _rrdBkFd01; }
            set { _rrdBkFd01 = value; RaisePropertyChanged("RrdBkFd01"); }
        }

        /// <summary>
        /// 保留字段02
        /// </summary>
        public byte RrdBkFd02
        {
            get { return _rrdBkFd02; }
            set { _rrdBkFd02 = value; RaisePropertyChanged("RrdBkFd02"); }
        }

        /// <summary>
        /// 保留字段03
        /// </summary>
        public string RrdBkFd03
        {
            get { return _rrdBkFd03; }
            set { _rrdBkFd03 = value; RaisePropertyChanged("RrdBkFd03"); }
        }

        /// <summary>
        /// 保留字段04
        /// </summary>
        public string RrdBkFd04
        {
            get { return _rrdBkFd04; }
            set { _rrdBkFd04 = value; RaisePropertyChanged("RrdBkFd04"); }
        }

        #endregion
    }
}
