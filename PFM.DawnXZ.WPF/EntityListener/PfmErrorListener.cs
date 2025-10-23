using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;
using System.Collections.ObjectModel;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmError]监听类
    /// </summary>
    public class PfmErrorListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmError]监听实例
        /// </summary>
        private static PfmErrorListener _listener;
        /// <summary>
        /// 数据实体[PfmError]监听实例
        /// </summary>
        public static PfmErrorListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmErrorListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmError]集合
        /// </summary>
        public IList<PfmErrorMDL> PfmErrorCollection
        {
            get { return GetValue(PfmErrorProperty) as IList<PfmErrorMDL>; }
            set { SetValue(PfmErrorProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmError]依赖属性
        /// </summary>
        public static DependencyProperty PfmErrorProperty = DependencyProperty.Register("PfmErrorCollection", typeof(IList<PfmErrorMDL>), typeof(PfmErrorListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmErrorListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmError]信息
        /// </summary>
        /// <param name="list">[PfmError]数据实体</param>
        public void Receive(IList<PfmErrorMDL> list)
        {
            PfmErrorCollection = list;
            Debug.WriteLine(PfmErrorCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
