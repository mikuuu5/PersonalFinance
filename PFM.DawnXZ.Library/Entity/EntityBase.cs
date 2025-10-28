using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace PFM.DawnXZ.Library.Entity
{
    /// <summary>
    /// 实体基类，实现IDataErrorInfo和INotifyPropertyChanged接口
    /// </summary>
    public abstract class EntityBase : IDataErrorInfo, INotifyPropertyChanged
    {
        #region 属性变化事件
        /// <summary>
        /// 属性变化事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 触发属性变化通知
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region 属性验证
        /// <summary>
        /// 是否在属性名无效时抛出异常（调试用）
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        /// <summary>
        /// 验证属性名称是否存在
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)) return;

            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = $"无效的属性名: {propertyName}";
                if (ThrowOnInvalidPropertyName)
                    throw new ArgumentException(msg);
                else
                    Debug.Fail(msg);
            }
        }
        #endregion

        #region 错误处理
        /// <summary>
        /// 错误信息字典
        /// </summary>
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

        /// <summary>
        /// 索引器 - 实现IDataErrorInfo接口
        /// </summary>
        public string this[string columnName]
        {
            get
            {
                _errors.TryGetValue(columnName, out string error);
                return error ?? string.Empty;
            }
        }

        /// <summary>
        /// 设置错误信息
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        /// <param name="errorMessage">错误消息</param>
        public void SetError(string propertyName, string errorMessage)
        {
            if (string.IsNullOrEmpty(propertyName)) return;

            _errors[propertyName] = errorMessage;
            RaisePropertyChanged(propertyName);
        }

        /// <summary>
        /// 清除错误信息
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        public void ClearError(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)) return;

            if (_errors.Remove(propertyName))
            {
                RaisePropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// 获取所有错误信息
        /// </summary>
        public IReadOnlyDictionary<string, string> Errors =>
            new Dictionary<string, string>(_errors);
        #endregion

        #region 公共属性
        /// <summary>
        /// 错误信息 - 实现IDataErrorInfo接口
        /// </summary>
        public string Error => null;
        #endregion
    }
}
