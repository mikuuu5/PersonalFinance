using System;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using PFM.DawnXZ.Library.Entity;
using PFM.DawnXZ.Library.IDAL;
using PFM.DawnXZ.Library.DBFactory;

namespace PFM.DawnXZ.Library.BLL
{
    /// <summary>
    /// 错误信息业务逻辑层
    /// </summary>
    public class PfmErrorBLL
    {
        #region 变量定义

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmErrorDAL _dal = DALFactory.PfmErrorDALInstance();

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmErrorBLL()
        {
        }

        #endregion

        #region 基本操作

        #region 添加

        /// <summary>
        /// 插入错误记录
        /// </summary>
        /// <param name="pfmError">错误实体对象</param>
        /// <returns>影响行数</returns>
        public static int Insert(PfmErrorMDL pfmError)
        {
            if (pfmError == null) return 0;
            return _dal.Insert(pfmError);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 根据ID删除错误记录
        /// </summary>
        /// <param name="errId">错误ID</param>
        /// <returns>影响行数</returns>
        public static int Delete(long errId)
        {
            if (errId < 0) return 0;
            return _dal.Delete(errId);
        }

        /// <summary>
        /// 删除所有错误记录
        /// </summary>
        /// <returns>影响行数</returns>
        public static int DeleteAll()
        {
            return _dal.DeleteAll();
        }

        #endregion

        #region 实体对象

        /// <summary>
        /// 从DataRow创建错误实体
        /// </summary>
        /// <param name="row">数据行</param>
        /// <returns>错误实体</returns>
        public static PfmErrorMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 从DataReader创建错误实体
        /// </summary>
        /// <param name="dr">数据读取器</param>
        /// <returns>错误实体</returns>
        public static PfmErrorMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID获取错误实体
        /// </summary>
        /// <param name="errId">错误ID</param>
        /// <returns>错误实体</returns>
        public static PfmErrorMDL Select(long errId)
        {
            return _dal.Select(errId);
        }

        #endregion

        #region 查询

        #region List查询

        /// <summary>
        /// 获取所有错误记录
        /// </summary>
        /// <returns>错误列表</returns>
        public static List<PfmErrorMDL> LSelect()
        {
            return _dal.LSelect();
        }

        /// <summary>
        /// 获取排序后的所有错误记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误列表</returns>
        public static List<PfmErrorMDL> LSelect(string sortField)
        {
            return _dal.LSelect(sortField);
        }

        /// <summary>
        /// 根据条件和排序查询错误记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误列表</returns>
        public static List<PfmErrorMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>错误列表</returns>
        public static List<PfmErrorMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region IList查询

        /// <summary>
        /// 获取所有错误记录
        /// </summary>
        /// <returns>错误接口列表</returns>
        public static IList<PfmErrorMDL> ISelect()
        {
            return _dal.ISelect();
        }

        /// <summary>
        /// 获取排序后的所有错误记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误接口列表</returns>
        public static IList<PfmErrorMDL> ISelect(string sortField)
        {
            return _dal.ISelect(sortField);
        }

        /// <summary>
        /// 根据条件和排序查询错误记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误接口列表</returns>
        public static IList<PfmErrorMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>错误接口列表</returns>
        public static IList<PfmErrorMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }

        #endregion

        #region Collection查询

        /// <summary>
        /// 获取所有错误记录
        /// </summary>
        /// <returns>错误集合</returns>
        public static Collection<PfmErrorMDL> CSelect()
        {
            return _dal.CSelect();
        }

        /// <summary>
        /// 获取排序后的所有错误记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误集合</returns>
        public static Collection<PfmErrorMDL> CSelect(string sortField)
        {
            return _dal.CSelect(sortField);
        }

        /// <summary>
        /// 根据条件和排序查询错误记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误集合</returns>
        public static Collection<PfmErrorMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>错误集合</returns>
        public static Collection<PfmErrorMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region ObservableCollection查询

        /// <summary>
        /// 获取所有错误记录
        /// </summary>
        /// <returns>错误可观察集合</returns>
        public static ObservableCollection<PfmErrorMDL> OSelect()
        {
            return _dal.OSelect();
        }

        /// <summary>
        /// 获取排序后的所有错误记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误可观察集合</returns>
        public static ObservableCollection<PfmErrorMDL> OSelect(string sortField)
        {
            return _dal.OSelect(sortField);
        }

        /// <summary>
        /// 根据条件和排序查询错误记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>错误可观察集合</returns>
        public static ObservableCollection<PfmErrorMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>错误可观察集合</returns>
        public static ObservableCollection<PfmErrorMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }

        #endregion

        /// <summary>
        /// 获取错误记录数量
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数量</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        /// <summary>
        /// 检查错误记录是否存在
        /// </summary>
        /// <param name="errId">错误ID</param>
        /// <returns>是否存在</returns>
        public static bool Exists(long errId)
        {
            return _dal.Exists(errId);
        }

        /// <summary>
        /// 检查错误记录是否存在
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>是否存在</returns>
        public static bool Exists(string where)
        {
            return _dal.Exists(where);
        }

        #endregion

        #endregion

        #region 数据分页

        #region List分页

        /// <summary>
        /// 错误记录分页查询
        /// </summary>
        /// <param name="pageSize">页大小</param>
        /// <param name="currentIndex">当前页</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns>分页数据</returns>
        public static List<PfmErrorMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 带条件的错误记录分页查询
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="currentIndex">当前页</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns>分页数据</returns>
        public static List<PfmErrorMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 带条件和排序的错误记录分页查询
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="currentIndex">当前页</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns>分页数据</returns>
        public static List<PfmErrorMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 完整参数的错误记录分页查询
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="currentIndex">当前页</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns>分页数据</returns>
        public static List<PfmErrorMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region IList分页

        public static IList<PfmErrorMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmErrorMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmErrorMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmErrorMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region Collection分页

        public static Collection<PfmErrorMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmErrorMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmErrorMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmErrorMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region ObservableCollection分页

        public static ObservableCollection<PfmErrorMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmErrorMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmErrorMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmErrorMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #endregion
    }
}
