using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using PFM.DawnXZ.Library.Entity;

namespace PFM.DawnXZ.WPF.EntityListener
{
    /// <summary>
    /// Message listener, singlton pattern.
    /// <remarks>
    /// Inherit from DependencyObject to implement DataBinding.
    /// </remarks>
    /// </summary>
    public class MessageListener : DependencyObject
    {
        #region 成员方法

        /// <summary>
        /// 消息监听
        /// </summary>
        private static MessageListener mInstance;
        /// <summary>
        /// Get MessageListener instance
        /// </summary>
        public static MessageListener Instance
        {
            get
            {
                if (mInstance == null) mInstance = new MessageListener();
                return mInstance;
            }
        }
        /// <summary>
        /// Get or set received message
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }
        /// <summary>
        /// 消息属性
        /// </summary>
        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(MessageListener), new UIPropertyMetadata(null));
        /// <summary>
        /// 构造函数
        /// </summary>
        private MessageListener()
        { }
        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="message">消息</param>
        public void Receive(string message)
        {
            Message = message;
            Debug.WriteLine(Message);
            DispatcherHelper.DoEvents();
        }

        #endregion 成员方法
    }
}
