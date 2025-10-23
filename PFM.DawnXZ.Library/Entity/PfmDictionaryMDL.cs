using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 账务字典
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

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        private long _dictId;
        /// <summary>
        /// 系统编号
        /// </summary>
        public long DictId
        {
            get { return this._dictId; }
            set
            {
                this._dictId = value;
                RaisePropertyChanged("DictId");
            }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        private DateTime _dictTime;
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime DictTime
        {
            get { return this._dictTime; }
            set
            {
                this._dictTime = value;
                RaisePropertyChanged("DictTime");
            }
        }
        /// <summary>
        /// 字典状态
        /// </summary>
        private byte _dictState;
        /// <summary>
        /// 字典状态
        /// </summary>
        public byte DictState
        {
            get { return this._dictState; }
            set
            {
                this._dictState = value;
                RaisePropertyChanged("DictState");
            }
        }
        /// <summary>
        /// 字典类型
        /// </summary>
        private byte _dictType;
        /// <summary>
        /// 字典类型
        /// </summary>
        public byte DictType
        {
            get { return this._dictType; }
            set
            {
                this._dictType = value;
                RaisePropertyChanged("DictType");
            }
        }
        /// <summary>
        /// 字典名称
        /// </summary>
        private string _dictName;
        /// <summary>
        /// 字典名称
        /// </summary>
        public string DictName
        {
            get { return this._dictName; }
            set
            {
                this._dictName = value;
                RaisePropertyChanged("DictName");
            }
        }
        /// <summary>
        /// 字典标识
        /// </summary>
        private byte _dictMark;
        /// <summary>
        /// 字典标识
        /// </summary>
        public byte DictMark
        {
            get { return this._dictMark; }
            set
            {
                this._dictMark = value;
                RaisePropertyChanged("DictMark");
            }
        }
        /// <summary>
        /// 字典备注
        /// </summary>
        private string _dictMemo;
        /// <summary>
        /// 字典备注
        /// </summary>
        public string DictMemo
        {
            get { return this._dictMemo; }
            set
            {
                this._dictMemo = value;
                RaisePropertyChanged("DictMemo");
            }
        }

        #endregion

    }
}
