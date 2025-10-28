using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 账务字典实体类
    /// </summary>
    [Serializable]
    public class PfmDictionaryMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmDictionaryMDL()
        { }
        #endregion

        #region 私有字段
        private long _dictId;
        private DateTime _dictTime;
        private byte _dictState;
        private byte _dictType;
        private string _dictName;
        private byte _dictMark;
        private string _dictMemo;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long DictId
        {
            get { return _dictId; }
            set
            {
                if (_dictId != value)
                {
                    _dictId = value;
                    RaisePropertyChanged("DictId");
                }
            }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime DictTime
        {
            get { return _dictTime; }
            set
            {
                if (_dictTime != value)
                {
                    _dictTime = value;
                    RaisePropertyChanged("DictTime");
                }
            }
        }

        /// <summary>
        /// 字典状态
        /// </summary>
        public byte DictState
        {
            get { return _dictState; }
            set
            {
                if (_dictState != value)
                {
                    _dictState = value;
                    RaisePropertyChanged("DictState");
                }
            }
        }

        /// <summary>
        /// 字典类型
        /// </summary>
        public byte DictType
        {
            get { return _dictType; }
            set
            {
                if (_dictType != value)
                {
                    _dictType = value;
                    RaisePropertyChanged("DictType");
                }
            }
        }

        /// <summary>
        /// 字典名称
        /// </summary>
        public string DictName
        {
            get { return _dictName; }
            set
            {
                if (_dictName != value)
                {
                    _dictName = value;
                    RaisePropertyChanged("DictName");
                }
            }
        }

        /// <summary>
        /// 字典标识
        /// </summary>
        public byte DictMark
        {
            get { return _dictMark; }
            set
            {
                if (_dictMark != value)
                {
                    _dictMark = value;
                    RaisePropertyChanged("DictMark");
                }
            }
        }

        /// <summary>
        /// 字典备注
        /// </summary>
        public string DictMemo
        {
            get { return _dictMemo; }
            set
            {
                if (_dictMemo != value)
                {
                    _dictMemo = value;
                    RaisePropertyChanged("DictMemo");
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
            return string.Format("{0} (类型:{1})", DictName, DictType);
        }
        #endregion
    }
}
