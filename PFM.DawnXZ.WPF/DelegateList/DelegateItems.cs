using System;
namespace PFM.DawnXZ.WPF.DelegateList
{
    /// 模块扩展通用委托
    /// <param name="isChild">是否为模块子控件</param>
    /// <param name="nameItems">模块名称标识</param>
    public delegate void ModuleExtendEventHandler(bool isChild, PFM.DawnXZ.Library.Transit.NameItems nameItems);
    /// 报表模块专用委托
    /// <param name="rptId">报表编号</param>
    public delegate void ReportViewEventHandler(long rptId);
    /// 委托项目
    public class DelegateItems{}
}
