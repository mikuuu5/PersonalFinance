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
    /// 收支明细业务逻辑层
    /// </summary>
    public class PfmIaeDetailedBLL
    {
        #region 变量定义

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmIaeDetailedDAL _dal = DALFactory.PfmIaeDetailedDALInstance();

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeDetailedBLL()
        {
        }

        #endregion

        #region 基本操作

        #region 添加

        /// <summary>
        /// 插入收支明细记录
        /// </summary>
        /// <param name="pfmIaeDetailed">收支明细实体对象</param>
        /// <returns>影响行数</returns>
        public static int Insert(PfmIaeDetailedMDL pfmIaeDetailed)
        {
            if (pfmIaeDetailed == null) return 0;
            return _dal.Insert(pfmIaeDetailed);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 更新收支明细记录
        /// </summary>
        /// <param name="pfmIaeDetailed">收支明细实体对象</param>
        /// <returns>影响行数</returns>
        public static int Update(PfmIaeDetailedMDL pfmIaeDetailed)
        {
            if (pfmIaeDetailed == null) return 0;
            return _dal.Update(pfmIaeDetailed);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 根据ID删除收支明细记录
        /// </summary>
        /// <param name="detId">明细ID</param>
        /// <returns>影响行数</returns>
        public static int Delete(long detId)
        {
            if (detId < 0) return 0;
            return _dal.Delete(detId);
        }

        /// <summary>
        /// 根据实体删除收支明细记录
        /// </summary>
        /// <param name="pfmIaeDetailed">收支明细实体对象</param>
        /// <returns>影响行数</returns>
        public static int Delete(PfmIaeDetailedMDL pfmIaeDetailed)
        {
            return _dal.Delete(pfmIaeDetailed);
        }

        #endregion

        #region 数据实体

        /// <summary>
        /// 从DataRow创建收支明细实体
        /// </summary>
        /// <param name="row">数据行</param>
        /// <returns>收支明细实体</returns>
        public static PfmIaeDetailedMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 从DataReader创建收支明细实体
        /// </summary>
        /// <param name="dr">数据读取器</param>
        /// <returns>收支明细实体</returns>
        public static PfmIaeDetailedMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID获取收支明细实体
        /// </summary>
        /// <param name="detId">明细ID</param>
        /// <returns>收支明细实体</returns>
        public static PfmIaeDetailedMDL Select(long detId)
        {
            return _dal.Select(detId);
        }

        #endregion

        #region 查询

        #region List查询

        /// <summary>
        /// 获取所有收支明细记录
        /// </summary>
        /// <returns>收支明细列表</returns>
        public static List<PfmIaeDetailedMDL> LSelect()
        {
            return _dal.LSelect();
        }

        /// <summary>
        /// 根据条件查询收支明细记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>收支明细列表</returns>
        public static List<PfmIaeDetailedMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        /// <summary>
        /// 根据条件和排序查询收支明细记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>收支明细列表</returns>
        public static List<PfmIaeDetailedMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>收支明细列表</returns>
        public static List<PfmIaeDetailedMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region IList查询

        public static IList<PfmIaeDetailedMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmIaeDetailedMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmIaeDetailedMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmIaeDetailedMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }

        #endregion

        #region Collection查询

        public static Collection<PfmIaeDetailedMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmIaeDetailedMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmIaeDetailedMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmIaeDetailedMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region ObservableCollection查询

        public static ObservableCollection<PfmIaeDetailedMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region 报表查询

        /// <summary>
        /// 获取收支报表数据
        /// </summary>
        /// <param name="begin">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <returns>报表数据表</returns>
        public static DataTable Report(DateTime begin, DateTime end)
        {
            return _dal.Report(begin, end);
        }

        #endregion

        /// <summary>
        /// 获取收支明细记录数量
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数量</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        /// <summary>
        /// 检查收支明细记录是否存在
        /// </summary>
        /// <param name="detId">明细ID</param>
        /// <returns>是否存在</returns>
        public static bool Exists(long detId)
        {
            return _dal.Exists(detId);
        }

        /// <summary>
        /// 检查收支明细记录是否存在
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

        public static List<PfmIaeDetailedMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeDetailedMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeDetailedMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeDetailedMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region IList分页

        public static IList<PfmIaeDetailedMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeDetailedMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeDetailedMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeDetailedMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region Collection分页

        public static Collection<PfmIaeDetailedMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeDetailedMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeDetailedMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeDetailedMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region ObservableCollection分页

        public static ObservableCollection<PfmIaeDetailedMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeDetailedMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #endregion
    }
}
