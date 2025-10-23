using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmIaeCategory]监听类
    /// </summary>
    public class PfmIaeCategoryListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmIaeCategory]监听实例
        /// </summary>
        private static PfmIaeCategoryListener _listener;
        /// <summary>
        /// 数据实体[PfmIaeCategory]监听实例
        /// </summary>
        public static PfmIaeCategoryListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmIaeCategoryListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmIaeCategory]集合
        /// </summary>
        public IList<PfmIaeCategoryMDL> PfmIaeCategoryCollection
        {
            get { return GetValue(PfmIaeCategoryProperty) as IList<PfmIaeCategoryMDL>; }
            set { SetValue(PfmIaeCategoryProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmIaeCategory]依赖属性
        /// </summary>
        public static DependencyProperty PfmIaeCategoryProperty = DependencyProperty.Register("PfmIaeCategoryCollection", typeof(IList<PfmIaeCategoryMDL>), typeof(PfmIaeCategoryListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmIaeCategoryListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmIaeCategory]信息
        /// </summary>
        /// <param name="list">[PfmIaeCategory]数据实体</param>
        public void Receive(IList<PfmIaeCategoryMDL> list)
        {
            PfmIaeCategoryCollection = list;
            Debug.WriteLine(PfmIaeCategoryCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
