using System;
using System.Collections.Generic;
using System.Linq;

namespace PFM.DawnXZ.Library.Transit
{
    //模块名称枚举
    public enum NameItems
    {
        //主程序名称
        Main,
        //收支明细
        IaeDetailed,
        //收支项目
        IaeItems,
        //收支类别
        IaeCategory,
        //账务账目
        Accounts,
        //账务成员
        Member,
        //账务报表
        Report,
        //账务字典
        Dictionary,
        //日志信息
        Logs,
        //错误信息
        Error,
        //关于系统
        About,
        //系统设置
        System
    }
    //模块名称管理类
    public class NameItemsTsit
    {
        private readonly Dictionary<NameItems, string> _moduleTitles;
        //初始化模块名称
        public NameItemsTsit()
        {
            _moduleTitles = new Dictionary<NameItems, string>
            {
                [NameItems.Main] = "个人账务管理系统—— 我的好帮手！",
                [NameItems.IaeDetailed] = "个人账务管理系统—— 收支明细管理",
                [NameItems.IaeItems] = "个人账务管理系统—— 收支项目管理",
                [NameItems.IaeCategory] = "个人账务管理系统—— 收支类别管理",
                [NameItems.Accounts] = "个人账务管理系统—— 账务账目管理",
                [NameItems.Member] = "个人账务管理系统—— 账务成员管理",
                [NameItems.Report] = "个人账务管理系统—— 账务报表管理",
                [NameItems.Dictionary] = "个人账务管理系统—— 账务字典管理",
                [NameItems.Logs] = "个人账务管理系统—— 日志信息管理",
                [NameItems.Error] = "个人账务管理系统—— 错误信息管理",
                [NameItems.About] = "个人账务管理系统—— 关于系统",
                [NameItems.System] = "个人账务管理系统—— 系统设置"
            };
        }
        //通过枚举值获取模块名称
        /// <param name="module">模块枚举</param>
        /// <returns>模块名称</returns>
        public string this[NameItems module]
        {
            get
            {
                if (_moduleTitles.TryGetValue(module, out string title))
                    return title;
                throw new ArgumentException($"未找到模块 {module} 对应的名称", nameof(module));
            }
        }
        //通过整数索引获取模块名称
        /// <param name="index">索引</param>
        /// <returns>模块名称</returns>
        public string this[int index]
        {
            get
            {
                if (Enum.IsDefined(typeof(NameItems), index))
                    return this[(NameItems)index];
                throw new ArgumentOutOfRangeException(nameof(index), $"索引 {index} 超出有效范围");
            }
        }
        //获取所有模块名称
        /// <returns>模块名称列表</returns>
        public IReadOnlyCollection<string> GetAllTitles()
        {
            return _moduleTitles.Values.ToList().AsReadOnly();
        }
        //获取模块数量
        public int Count => _moduleTitles.Count;
        //检查模块是否存在
        /// <param name="module">模块枚举</param>
        /// <returns>是否存在</returns>
        public bool ContainsModule(NameItems module)
        {
            return _moduleTitles.ContainsKey(module);
        }
    }
}
