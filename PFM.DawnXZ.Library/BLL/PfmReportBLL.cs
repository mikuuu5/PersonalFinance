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
    /// 业务逻辑层PfmReport
    /// </summary>
    public class PfmReportBLL
    {
        #region ---------变量定义-----------

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmReportDAL _dal = DALFactory.PfmReportDALInstance();

        #endregion

        #region ---------函数定义-----------

        #region 基本CRUD操作

        /// <summary>
        /// 向数据表PfmReport中插入一条新记录
        /// </summary>
        /// <param name="pfmReport">PfmReport实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Insert(PfmReportMDL pfmReport)
        {
            return pfmReport == null ? 0 : _dal.Insert(pfmReport);
        }

        /// <summary>
        /// 向数据表PfmReport修改一条记录
        /// </summary>
        /// <param name="pfmReport">PfmReport实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Update(PfmReportMDL pfmReport)
        {
            return pfmReport == null ? 0 : _dal.Update(pfmReport);
        }

        /// <summary>
        /// 删除数据表PfmReport中的一条记录
        /// </summary>
        /// <param name="rptId">报告ID</param>
        /// <returns>影响的行数</returns>
        public static int Delete(long rptId)
        {
            return rptId < 0 ? 0 : _dal.Delete(rptId);
        }

        /// <summary>
        /// 删除数据表PfmReport中的一条记录
        /// </summary>
        /// <param name="pfmReport">PfmReport实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Delete(PfmReportMDL pfmReport)
        {
            return _dal.Delete(pfmReport);
        }

        #endregion

        #region 数据实体操作

        /// <summary>
        /// 通过DataRow创建一个PfmReport实体对象
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PfmReport实体对象</returns>
        public static PfmReportMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 通过DataReader创建一个PfmReport实体对象
        /// </summary>
        /// <param name="dr">IDataReader</param>
        /// <returns>PfmReport实体对象</returns>
        public static PfmReportMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID返回一个PfmReport实体对象
        /// </summary>
        /// <param name="rptId">报告ID</param>
        /// <returns>PfmReport实体对象</returns>
        public static PfmReportMDL Select(long rptId)
        {
            return _dal.Select(rptId);
        }

        #endregion

        #region 查询操作

        #region List查询
        public static List<PfmReportMDL> LSelect()
        {
            return _dal.LSelect();
        }

        public static List<PfmReportMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        public static List<PfmReportMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        public static List<PfmReportMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region IList查询
        public static IList<PfmReportMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmReportMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmReportMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmReportMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }
        #endregion

        #region Collection查询
        public static Collection<PfmReportMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmReportMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmReportMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmReportMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region ObservableCollection查询
        public static ObservableCollection<PfmReportMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmReportMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmReportMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmReportMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }
        #endregion

        /// <summary>
        /// 获取最大系统编号
        /// </summary>
        /// <returns>最大ID</returns>
        public static int GetMaxId()
        {
            return _dal.GetMaxId();
        }

        /// <summary>
        /// 得到数据表PfmReport满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        /// <summary>
        /// 根据主键检测是否存在该条记录
        /// </summary>
        /// <param name="rptId">报告ID</param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long rptId)
        {
            return _dal.Exists(rptId);
        }

        /// <summary>
        /// 根据指定条件检测是否存在该条记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(string where)
        {
            return _dal.Exists(where);
        }

        #endregion

        #region 数据分页处理·SQLite

        #region List分页
        public static List<PfmReportMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region IList分页
        public static IList<PfmReportMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region Collection分页
        public static Collection<PfmReportMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region ObservableCollection分页
        public static ObservableCollection<PfmReportMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #endregion

        #endregion
    }
}
