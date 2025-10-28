using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 收支明细
    /// </summary>
    [Serializable]
    public class PfmIaeDetailedMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeDetailedMDL()
        { }
        #endregion

        #region 私有字段
        private long _detId;
        private int _mbrId;
        private int _accId;
        private int _catId;
        private DateTime _detAddTime;
        private string _detName;
        private decimal _detMoney;
        private string _detAddress;
        private string _detDescription;
        private string _detMemo;
        private byte _detStatus;
        private DateTime _detEditTime;
        private int _detEditCount;
        private int _catBkFd01;
        private byte _catBkFd02;
        private string _catBkFd03;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long DetId
        {
            get { return _detId; }
            set { _detId = value; RaisePropertyChanged("DetId"); }
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
        /// 类别编号
        /// </summary>
        public int CatId
        {
            get { return _catId; }
            set { _catId = value; RaisePropertyChanged("CatId"); }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime DetAddTime
        {
            get { return _detAddTime; }
            set { _detAddTime = value; RaisePropertyChanged("DetAddTime"); }
        }

        /// <summary>
        /// 收支名称
        /// </summary>
        public string DetName
        {
            get { return _detName; }
            set { _detName = value; RaisePropertyChanged("DetName"); }
        }

        /// <summary>
        /// 收支金额
        /// </summary>
        public decimal DetMoney
        {
            get { return _detMoney; }
            set { _detMoney = value; RaisePropertyChanged("DetMoney"); }
        }

        /// <summary>
        /// 收支地点
        /// </summary>
        public string DetAddress
        {
            get { return _detAddress; }
            set { _detAddress = value; RaisePropertyChanged("DetAddress"); }
        }

        /// <summary>
        /// 收支描述
        /// </summary>
        public string DetDescription
        {
            get { return _detDescription; }
            set { _detDescription = value; RaisePropertyChanged("DetDescription"); }
        }

        /// <summary>
        /// 收支备忘
        /// </summary>
        public string DetMemo
        {
            get { return _detMemo; }
            set { _detMemo = value; RaisePropertyChanged("DetMemo"); }
        }

        /// <summary>
        /// 收支状态
        /// </summary>
        public byte DetStatus
        {
            get { return _detStatus; }
            set { _detStatus = value; RaisePropertyChanged("DetStatus"); }
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime DetEditTime
        {
            get { return _detEditTime; }
            set { _detEditTime = value; RaisePropertyChanged("DetEditTime"); }
        }

        /// <summary>
        /// 修改次数
        /// </summary>
        public int DetEditCount
        {
            get { return _detEditCount; }
            set { _detEditCount = value; RaisePropertyChanged("DetEditCount"); }
        }

        /// <summary>
        /// 保留字段01
        /// </summary>
        public int CatBkFd01
        {
            get { return _catBkFd01; }
            set { _catBkFd01 = value; RaisePropertyChanged("CatBkFd01"); }
        }

        /// <summary>
        /// 保留字段02
        /// </summary>
        public byte CatBkFd02
        {
            get { return _catBkFd02; }
            set { _catBkFd02 = value; RaisePropertyChanged("CatBkFd02"); }
        }

        /// <summary>
        /// 保留字段03
        /// </summary>
        public string CatBkFd03
        {
            get { return _catBkFd03; }
            set { _catBkFd03 = value; RaisePropertyChanged("CatBkFd03"); }
        }

        #endregion
    }
}
