using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmLogs]监听类
    /// </summary>
    public class PfmLogsListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmLogs]监听实例
        /// </summary>
        private static PfmLogsListener _listener;
        /// <summary>
        /// 数据实体[PfmLogs]监听实例
        /// </summary>
        public static PfmLogsListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmLogsListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmLogs]集合
        /// </summary>
        public IList<PfmLogsMDL> PfmLogsCollection
        {
            get { return GetValue(PfmLogsProperty) as IList<PfmLogsMDL>; }
            set { SetValue(PfmLogsProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmLogs]依赖属性
        /// </summary>
        public static DependencyProperty PfmLogsProperty = DependencyProperty.Register("PfmLogsCollection", typeof(IList<PfmLogsMDL>), typeof(PfmLogsListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmLogsListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmLogs]信息
        /// </summary>
        /// <param name="list">[PfmLogs]数据实体</param>
        public void Receive(IList<PfmLogsMDL> list)
        {
            PfmLogsCollection = list;
            Debug.WriteLine(PfmLogsCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
