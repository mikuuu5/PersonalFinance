using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// 数据实体[PfmAccounts]监听类
    /// </summary>
    public class PfmAccountsListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 数据实体[PfmAccounts]监听实例
        /// </summary>
        private static PfmAccountsListener _listener;
        /// <summary>
        /// 数据实体[PfmAccounts]监听实例
        /// </summary>
        public static PfmAccountsListener Instance
        {
            get
            {
                if (_listener == null) _listener = new PfmAccountsListener();
                return _listener;
            }
        }
        /// <summary>
        /// 数据实体[PfmAccounts]集合
        /// </summary>
        public IList<PfmAccountsMDL> PfmAccountsCollection
        {
            get { return GetValue(PfmAccountsProperty) as IList<PfmAccountsMDL>; }
            set { SetValue(PfmAccountsProperty, value); }
        }
        /// <summary>
        /// 数据实体[PfmAccounts]依赖属性
        /// </summary>
        public static DependencyProperty PfmAccountsProperty = DependencyProperty.Register("PfmAccountsCollection", typeof(IList<PfmAccountsMDL>), typeof(PfmAccountsListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private PfmAccountsListener()
        { }
        /// <summary>
        /// 接收数据实体[PfmAccounts]信息
        /// </summary>
        /// <param name="list">[PfmAccounts]数据实体</param>
        public void Receive(IList<PfmAccountsMDL> list)
        {
            PfmAccountsCollection = list;
            Debug.WriteLine(PfmAccountsCollection);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
