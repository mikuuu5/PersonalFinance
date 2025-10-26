using System;
using System.IO;
using System.Threading;
namespace PFM.DawnXZ.Library.Transit
{
    //文件日志类
    //默认：根目录logs文件夹
    public class LoggerTsit
    {
        #region Property
        //日志保存路径
        public static string LogPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
        //日志级别
        public static LogLevel Level { get; set; } = LogLevel.INFO;
        #endregion
        #region 日志级别枚举
        public enum LogLevel
        {
            DEBUG = 0,
            INFO = 1,
            WARN = 2,
            ERROR = 3,
            FATAL = 4
        }
        #endregion
        #region 成员方法
        #region 错误信息
        //记录错误日志
        /// <param name="ex">Exception</param>
        public static void Error(Exception ex)
        {
            if ((int)Level > (int)LogLevel.ERROR) return;
            Write(LogLevel.ERROR, $"发生错误：{ex.Message}\r\n错误描述：{ex.StackTrace}");
        }
        //记录错误日志
        /// <param name="logPath">日志路径</param>
        /// <param name="ex">Exception</param>
        public static void Error(string logPath, Exception ex)
        {
            if ((int)Level > (int)LogLevel.ERROR) return;
            Write(logPath, LogLevel.ERROR, $"发生错误：{ex.Message}\r\n错误描述：{ex.StackTrace}");
        }
        //记录错误日志
        /// <param name="message">错误信息</param>
        public static void Error(string message)
        {
            if ((int)Level > (int)LogLevel.ERROR) return;
            Write(LogLevel.ERROR, message);
        }
        #endregion
        #region 信息日志
        //记录信息日志
        /// <param name="message">信息</param>
        public static void Info(string message)
        {
            if ((int)Level > (int)LogLevel.INFO) return;
            Write(LogLevel.INFO, message);
        }
        //记录信息日志
        /// <param name="logPath">日志路径</param>
        /// <param name="message">信息</param>
        public static void Info(string logPath, string message)
        {
            if ((int)Level > (int)LogLevel.INFO) return;
            Write(logPath, LogLevel.INFO, message);
        }
        #endregion
        #region 调试日志
        //记录调试日志
        /// <param name="message">调试信息</param>
        public static void Debug(string message)
        {
            if ((int)Level > (int)LogLevel.DEBUG) return;
            Write(LogLevel.DEBUG, message);
        }
        #endregion
        #region 警告日志
        //记录警告日志
        /// <param name="message">警告信息</param>
        public static void Warn(string message)
        {
            if ((int)Level > (int)LogLevel.WARN) return;
            Write(LogLevel.WARN, message);
        }
        #endregion
        #region 核心写入方法
        //记录日志
        /// <param name="level">日志级别</param>
        /// <param name="msg">内容</param>
        private static void Write(LogLevel level, string msg)
        {
            Write(LogPath, level, msg);
        }
        //记录日志
        /// <param name="logPath">日志路径</param>
        /// <param name="level">日志级别</param>
        /// <param name="msg">内容</param>
        private static void Write(string logPath, LogLevel level, string msg)
        {
            try
            {
                EnsureDirectoryExists(logPath);

                string fileName = $"{DateTime.Now:yyyy-MM-dd}.log";
                string fullPath = Path.Combine(logPath, fileName);

                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {msg}";

                WriteToFile(fullPath, logEntry);
            }
            catch (Exception ex)
            {
                // 日志失败时的备用处理，可以输出到控制台或其他地方
                System.Diagnostics.Debug.WriteLine($"日志写入失败: {ex.Message}");
            }
        }
        //确保目录存在
        private static void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        //写文件
        private static void WriteToFile(string fileName, string message)
        {
            // 使用线程安全的方式写入文件
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(message);
                }
            }
            catch (IOException)
            {
                // 如果文件被占用，稍后重试一次
                Thread.Sleep(10);
                using (StreamWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(message);
                }
            }
        }

        public static void Write(Exception exception)
        {
            throw new NotImplementedException();
        }

        public static void Write(string v)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
