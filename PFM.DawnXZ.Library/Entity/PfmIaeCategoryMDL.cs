using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{using System;
using System.Collections.Generic;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 收支类别实体类
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

        #region 私有字段
        private int _catId;
        private string _catName;
        private int _catFather;
        private string _catPath;
        private int _catClick;
        private int _catCounts;
        private string _catDescription;
        #endregion

        #region 公共属性

        /// <summary>
        /// 系统编号
        /// </summary>
        public int CatId
        {
            get { return _catId; }
            set
            {
                if (_catId != value)
                {
                    _catId = value;
                    RaisePropertyChanged("CatId");
                }
            }
        }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string CatName
        {
            get { return _catName; }
            set
            {
                if (_catName != value)
                {
                    _catName = value;
                    RaisePropertyChanged("CatName");
                }
            }
        }

        /// <summary>
        /// 父级类别ID
        /// </summary>
        public int CatFather
        {
            get { return _catFather; }
            set
            {
                if (_catFather != value)
                {
                    _catFather = value;
                    RaisePropertyChanged("CatFather");
                }
            }
        }

        /// <summary>
        /// 类别路径
        /// </summary>
        public string CatPath
        {
            get { return _catPath; }
            set
            {
                if (_catPath != value)
                {
                    _catPath = value;
                    RaisePropertyChanged("CatPath");
                }
            }
        }

        /// <summary>
        /// 点击次数
        /// </summary>
        public int CatClick
        {
            get { return _catClick; }
            set
            {
                if (_catClick != value)
                {
                    _catClick = value;
                    RaisePropertyChanged("CatClick");
                }
            }
        }

        /// <summary>
        /// 数据统计
        /// </summary>
        public int CatCounts
        {
            get { return _catCounts; }
            set
            {
                if (_catCounts != value)
                {
                    _catCounts = value;
                    RaisePropertyChanged("CatCounts");
                }
            }
        }

        /// <summary>
        /// 类别描述
        /// </summary>
        public string CatDescription
        {
            get { return _catDescription; }
            set
            {
                if (_catDescription != value)
                {
                    _catDescription = value;
                    RaisePropertyChanged("CatDescription");
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
            return string.Format("{0} (ID:{1})", _catName, _catId);
        }
        #endregion

        #region 便捷属性
        /// <summary>
        /// 是否为根类别（父级ID为0）
        /// </summary>
        public bool IsRootCategory
        {
            get { return _catFather == 0; }
        }

        /// <summary>
        /// 是否有子类别（根据数据统计判断）
        /// </summary>
        public bool HasSubCategories
        {
            get { return _catCounts > 0; }
        }

        /// <summary>
        /// 显示名称（包含ID和名称）
        /// </summary>
        public string DisplayName
        {
            get { return string.Format("{0}. {1}", _catId, _catName); }
        }
        #endregion

        #region 便捷方法
        /// <summary>
        /// 增加点击次数
        /// </summary>
        public void IncrementClick()
        {
            CatClick++;
        }

        /// <summary>
        /// 增加数据统计
        /// </summary>
        public void IncrementCounts()
        {
            CatCounts++;
        }

        /// <summary>
        /// 减少数据统计
        /// </summary>
        public void DecrementCounts()
        {
            if (_catCounts > 0)
            {
                CatCounts--;
            }
        }
        #endregion
    }
}
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
