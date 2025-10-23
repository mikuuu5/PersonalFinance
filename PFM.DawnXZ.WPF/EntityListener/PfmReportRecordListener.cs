using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmReportRecord]监听类
    /// </summary>
    public class PfmReportRecordListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmReportRecord]监听实例
        /// </summary>
        private static PfmReportRecordListener _listener;
        /// <summary>
        /// 数据实体[PfmReportRecord]监听实例
        /// </summary>
        public static PfmReportRecordListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmReportRecordListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmReportRecord]集合
        /// </summary>
        public IList<PfmReportRecordMDL> PfmReportRecordCollection
        {
            get { return GetValue(PfmReportRecordProperty) as IList<PfmReportRecordMDL>; }
            set { SetValue(PfmReportRecordProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmReportRecord]依赖属性
        /// </summary>
        public static DependencyProperty PfmReportRecordProperty = DependencyProperty.Register("PfmReportRecordCollection", typeof(IList<PfmReportRecordMDL>), typeof(PfmReportRecordListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmReportRecordListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmReportRecord]信息
        /// </summary>
        /// <param name="list">[PfmReportRecord]数据实体</param>
        public void Receive(IList<PfmReportRecordMDL> list)
        {
            PfmReportRecordCollection = list;
            Debug.WriteLine(PfmReportRecordCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
