using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 账务账目实体类
    /// </summary>
    [Serializable]
    public class PfmAccountsMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmAccountsMDL()
        { }
        #endregion

        #region 私有字段
        private long _accId;
        private int _mbrId;
        private DateTime _accAddTime;
        private byte _accStatus;
        private string _accName;
        private string _accCode;
        private string _accCard;
        private string _accPurpose;
        private string _accDescription;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long AccId
        {
            get => _accId;
            set
            {
                if (_accId != value)
                {
                    _accId = value;
                    RaisePropertyChanged(nameof(AccId));
                }
            }
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        public int MbrId
        {
            get => _mbrId;
            set
            {
                if (_mbrId != value)
                {
                    _mbrId = value;
                    RaisePropertyChanged(nameof(MbrId));
                }
            }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AccAddTime
        {
            get => _accAddTime;
            set
            {
                if (_accAddTime != value)
                {
                    _accAddTime = value;
                    RaisePropertyChanged(nameof(AccAddTime));
                }
            }
        }

        /// <summary>
        /// 账目状态
        /// </summary>
        public byte AccStatus
        {
            get => _accStatus;
            set
            {
                if (_accStatus != value)
                {
                    _accStatus = value;
                    RaisePropertyChanged(nameof(AccStatus));
                }
            }
        }

        /// <summary>
        /// 账目名称
        /// </summary>
        public string AccName
        {
            get => _accName;
            set
            {
                if (_accName != value)
                {
                    _accName = value;
                    RaisePropertyChanged(nameof(AccName));
                }
            }
        }

        /// <summary>
        /// 账目编码
        /// </summary>
        public string AccCode
        {
            get => _accCode;
            set
            {
                if (_accCode != value)
                {
                    _accCode = value;
                    RaisePropertyChanged(nameof(AccCode));
                }
            }
        }

        /// <summary>
        /// 账目卡号
        /// </summary>
        public string AccCard
        {
            get => _accCard;
            set
            {
                if (_accCard != value)
                {
                    _accCard = value;
                    RaisePropertyChanged(nameof(AccCard));
                }
            }
        }

        /// <summary>
        /// 账目用途
        /// </summary>
        public string AccPurpose
        {
            get => _accPurpose;
            set
            {
                if (_accPurpose != value)
                {
                    _accPurpose = value;
                    RaisePropertyChanged(nameof(AccPurpose));
                }
            }
        }

        /// <summary>
        /// 账目描述
        /// </summary>
        public string AccDescription
        {
            get => _accDescription;
            set
            {
                if (_accDescription != value)
                {
                    _accDescription = value;
                    RaisePropertyChanged(nameof(AccDescription));
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
            return $"{AccName} ({AccCode})";
        }
        #endregion
    }
}
