using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmIaeDetailed]监听类
    /// </summary>
    public class PfmIaeDetailedListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmIaeDetailed]监听实例
        /// </summary>
        private static PfmIaeDetailedListener _listener;
        /// <summary>
        /// 数据实体[PfmIaeDetailed]监听实例
        /// </summary>
        public static PfmIaeDetailedListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmIaeDetailedListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmIaeDetailed]集合
        /// </summary>
        public IList<PfmIaeDetailedMDL> PfmIaeDetailedCollection
        {
            get { return GetValue(PfmIaeDetailedProperty) as IList<PfmIaeDetailedMDL>; }
            set { SetValue(PfmIaeDetailedProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmIaeDetailed]依赖属性
        /// </summary>
        public static DependencyProperty PfmIaeDetailedProperty = DependencyProperty.Register("PfmIaeDetailedCollection", typeof(IList<PfmIaeDetailedMDL>), typeof(PfmIaeDetailedListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmIaeDetailedListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmIaeDetailed]信息
        /// </summary>
        /// <param name="list">[PfmIaeDetailed]数据实体</param>
        public void Receive(IList<PfmIaeDetailedMDL> list)
        {
            PfmIaeDetailedCollection = list;
            Debug.WriteLine(PfmIaeDetailedCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
