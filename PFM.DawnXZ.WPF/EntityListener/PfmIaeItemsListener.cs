using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmIaeItems]监听类
    /// </summary>
    public class PfmIaeItemsListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmIaeItems]监听实例
        /// </summary>
        private static PfmIaeItemsListener _listener;
        /// <summary>
        /// 数据实体[PfmIaeItems]监听实例
        /// </summary>
        public static PfmIaeItemsListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmIaeItemsListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmIaeItems]集合
        /// </summary>
        public IList<PfmIaeItemsMDL> PfmIaeItemsCollection
        {
            get { return GetValue(PfmIaeItemsProperty) as IList<PfmIaeItemsMDL>; }
            set { SetValue(PfmIaeItemsProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmIaeItems]依赖属性
        /// </summary>
        public static DependencyProperty PfmIaeItemsProperty = DependencyProperty.Register("PfmIaeItemsCollection", typeof(IList<PfmIaeItemsMDL>), typeof(PfmIaeItemsListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmIaeItemsListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmIaeItems]信息
        /// </summary>
        /// <param name="list">[PfmIaeItems]数据实体</param>
        public void Receive(IList<PfmIaeItemsMDL> list)
        {
            PfmIaeItemsCollection = list;
            Debug.WriteLine(PfmIaeItemsCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
