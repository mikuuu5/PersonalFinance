using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 账务成员
    /// </summary>
    [Serializable]
    public class PfmMemberMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmMemberMDL()
        { }
        #endregion

        #region 私有字段
        private long _mbrId;
        private DateTime _mbrAddTime;
        private string _mbrName;
        private string _mbrRelation;
        private string _mbrDescription;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long MbrId
        {
            get { return _mbrId; }
            set { _mbrId = value; RaisePropertyChanged("MbrId"); }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime MbrAddTime
        {
            get { return _mbrAddTime; }
            set { _mbrAddTime = value; RaisePropertyChanged("MbrAddTime"); }
        }

        /// <summary>
        /// 成员名称
        /// </summary>
        public string MbrName
        {
            get { return _mbrName; }
            set { _mbrName = value; RaisePropertyChanged("MbrName"); }
        }

        /// <summary>
        /// 成员关系
        /// </summary>
        public string MbrRelation
        {
            get { return _mbrRelation; }
            set { _mbrRelation = value; RaisePropertyChanged("MbrRelation"); }
        }

        /// <summary>
        /// 成员描述
        /// </summary>
        public string MbrDescription
        {
            get { return _mbrDescription; }
            set { _mbrDescription = value; RaisePropertyChanged("MbrDescription"); }
        }

        #endregion
    }
}
