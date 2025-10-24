using System;
using System.IO;
using DawnXZ.FileUtility;
using DawnXZ.DawnUtility;
namespace PFM.DawnXZ.Library.Transit
{
    public class ConfigTsit
    {
        // 配置文件路径
        private static readonly string _filePath = Path.Combine(Tools.AppPath, "config.ini");
        // 使用Lazy延迟初始化缓存配置值，避免重复文件访问
        private static readonly Lazy<int> _pageSize = new Lazy<int>(() =>IniHelper.ReadInt(_filePath, "Pager", "PageSize", 200));
        private static readonly Lazy<int> _yearOrigin = new Lazy<int>(() =>
        {
            int year = IniHelper.ReadInt(_filePath, "Date", "YearOrigin", 2025);
            return year > DateTime.Now.Year ? DateTime.Now.Year : year;
        });
        private static readonly Lazy<string> _reportTitle = new Lazy<string>(() => CryptoHelper.Decrypt(IniHelper.ReadString(_filePath, "General", "report","384E5A8021751039C11E917CD34F9D87")));
        // 每页显示记录数（带验证）
        public static int PageSize
        {
            get
            {
                int size = _pageSize.Value;
                return size > 0 ? size : 200; // 确保为正值
            }
        }
        // 报表原始年份（带边界检查）
        public static int YearOrigin => _yearOrigin.Value;
        // 报表默认标题
        public static string ReportTitle => _reportTitle.Value;
        // 其他有用的属性
        public static string FilePath => _filePath;
        // 验证配置文件是否存在的方法
        public static bool ConfigExists => File.Exists(_filePath);
    }
}
