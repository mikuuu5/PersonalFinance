using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmMember]监听类
    /// </summary>
    public class PfmMemberListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmMember]监听实例
        /// </summary>
        private static PfmMemberListener _listener;
        /// <summary>
        /// 数据实体[PfmMember]监听实例
        /// </summary>
        public static PfmMemberListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmMemberListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmMember]集合
        /// </summary>
        public IList<PfmMemberMDL> PfmMemberCollection
        {
            get { return GetValue(PfmMemberProperty) as IList<PfmMemberMDL>; }
            set { SetValue(PfmMemberProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmMember]依赖属性
        /// </summary>
        public static DependencyProperty PfmMemberProperty = DependencyProperty.Register("PfmMemberCollection", typeof(IList<PfmMemberMDL>), typeof(PfmMemberListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmMemberListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmMember]信息
        /// </summary>
        /// <param name="list">[PfmMember]数据实体</param>
        public void Receive(IList<PfmMemberMDL> list)
        {
            PfmMemberCollection = list;
            Debug.WriteLine(PfmMemberCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
