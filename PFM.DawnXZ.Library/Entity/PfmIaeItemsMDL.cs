using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 收支项目
    /// </summary>
    [Serializable]
    public class PfmIaeItemsMDL : EntityBase
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeItemsMDL()
        { }
        #endregion

        #region 私有字段
        private long _itemId;
        private DateTime _itemAddTime;
        private byte _itemStatus;
        private byte _itemType;
        private string _itemName;
        private string _itemDescription;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public long ItemId
        {
            get { return _itemId; }
            set { _itemId = value; RaisePropertyChanged("ItemId"); }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime ItemAddTime
        {
            get { return _itemAddTime; }
            set { _itemAddTime = value; RaisePropertyChanged("ItemAddTime"); }
        }

        /// <summary>
        /// 项目状态
        /// </summary>
        public byte ItemStatus
        {
            get { return _itemStatus; }
            set { _itemStatus = value; RaisePropertyChanged("ItemStatus"); }
        }

        /// <summary>
        /// 项目类别
        /// </summary>
        public byte ItemType
        {
            get { return _itemType; }
            set { _itemType = value; RaisePropertyChanged("ItemType"); }
        }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; RaisePropertyChanged("ItemName"); }
        }

        /// <summary>
        /// 项目说明
        /// </summary>
        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; RaisePropertyChanged("ItemDescription"); }
        }

        #endregion
    }
}
