using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmDictionary]监听类
    /// </summary>
    public class PfmDictionaryListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmDictionary]监听实例
        /// </summary>
        private static PfmDictionaryListener _listener;
        /// <summary>
        /// 数据实体[PfmDictionary]监听实例
        /// </summary>
        public static PfmDictionaryListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmDictionaryListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmDictionary]集合
        /// </summary>
        public IList<PfmDictionaryMDL> PfmDictionaryCollection
        {
            get { return GetValue(PfmDictionaryProperty) as IList<PfmDictionaryMDL>; }
            set { SetValue(PfmDictionaryProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmDictionary]依赖属性
        /// </summary>
        public static DependencyProperty PfmDictionaryProperty = DependencyProperty.Register("PfmDictionaryCollection", typeof(IList<PfmDictionaryMDL>), typeof(PfmDictionaryListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmDictionaryListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmDictionary]信息
        /// </summary>
        /// <param name="list">[PfmDictionary]数据实体</param>
        public void Receive(IList<PfmDictionaryMDL> list)
        {
            PfmDictionaryCollection = list;
            Debug.WriteLine(PfmDictionaryCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
