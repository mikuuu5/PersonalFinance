using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 收支类别
    /// </summary>
    [Serializable]
    public class PfmIaeCategoryMDL : EntityBase
    {

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeCategoryMDL()
        { }

        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        private int _catId;
        /// <summary>
        /// 系统编号
        /// </summary>
        public int CatId
        {
            get { return this._catId; }
            set
            {
                this._catId = value;
                RaisePropertyChanged("CatId");
            }
        }
        /// <summary>
        /// 类别名称
        /// </summary>
        private string _catName;
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CatName
        {
            get { return this._catName; }
            set
            {
                this._catName = value;
                RaisePropertyChanged("CatName");
            }
        }
        /// <summary>
        /// 类别标识
        /// </summary>
        private int _catFather;
        /// <summary>
        /// 类别标识
        /// </summary>
        public int CatFather
        {
            get { return this._catFather; }
            set
            {
                this._catFather = value;
                RaisePropertyChanged("CatFather");
            }
        }
        /// <summary>
        /// 类别路径
        /// </summary>
        private string _catPath;
        /// <summary>
        /// 类别路径
        /// </summary>
        public string CatPath
        {
            get { return this._catPath; }
            set
            {
                this._catPath = value;
                RaisePropertyChanged("CatPath");
            }
        }
        /// <summary>
        /// 点击率
        /// </summary>
        private int _catClick;
        /// <summary>
        /// 点击率
        /// </summary>
        public int CatClick
        {
            get { return this._catClick; }
            set
            {
                this._catClick = value;
                RaisePropertyChanged("CatClick");
            }
        }
        /// <summary>
        /// 数据统计
        /// </summary>
        private int _catCounts;
        /// <summary>
        /// 数据统计
        /// </summary>
        public int CatCounts
        {
            get { return this._catCounts; }
            set
            {
                this._catCounts = value;
                RaisePropertyChanged("CatCounts");
            }
        }
        /// <summary>
        /// 类别描述
        /// </summary>
        private string _catDescription;
        /// <summary>
        /// 类别描述
        /// </summary>
        public string CatDescription
        {
            get { return this._catDescription; }
            set
            {
                this._catDescription = value;
                RaisePropertyChanged("CatDescription");
            }
        }

        #endregion

    }
}
