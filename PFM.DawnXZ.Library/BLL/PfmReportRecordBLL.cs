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
    /// 业务逻辑层PfmReportRecord
    /// </summary>
    public class PfmReportRecordBLL
    {
        #region ---------变量定义-----------

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmReportRecordDAL _dal = DALFactory.PfmReportRecordDALInstance();

        #endregion

        #region ---------函数定义-----------

        #region 基本CRUD操作

        /// <summary>
        /// 向数据表PfmReportRecord中插入一条新记录
        /// </summary>
        /// <param name="pfmReportRecord">PfmReportRecord实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Insert(PfmReportRecordMDL pfmReportRecord)
        {
            return pfmReportRecord == null ? 0 : _dal.Insert(pfmReportRecord);
        }

        /// <summary>
        /// 向数据表PfmReportRecord修改一条记录
        /// </summary>
        /// <param name="pfmReportRecord">PfmReportRecord实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Update(PfmReportRecordMDL pfmReportRecord)
        {
            return pfmReportRecord == null ? 0 : _dal.Update(pfmReportRecord);
        }

        /// <summary>
        /// 删除数据表PfmReportRecord中的一条记录
        /// </summary>
        /// <param name="rrdId">记录ID</param>
        /// <returns>影响的行数</returns>
        public static int Delete(long rrdId)
        {
            return rrdId < 0 ? 0 : _dal.Delete(rrdId);
        }

        /// <summary>
        /// 删除数据表PfmReportRecord中的条件记录
        /// </summary>
        /// <param name="rptId">报告ID</param>
        /// <returns>影响的行数</returns>
        public static int DeleteAll(long rptId)
        {
            return rptId < 0 ? 0 : _dal.DeleteAll(rptId);
        }

        /// <summary>
        /// 删除数据表PfmReportRecord中的一条记录
        /// </summary>
        /// <param name="pfmReportRecord">PfmReportRecord实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Delete(PfmReportRecordMDL pfmReportRecord)
        {
            return _dal.Delete(pfmReportRecord);
        }

        #endregion

        #region 数据实体操作

        /// <summary>
        /// 通过DataRow创建一个PfmReportRecord实体对象
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PfmReportRecord实体对象</returns>
        public static PfmReportRecordMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 通过DataReader创建一个PfmReportRecord实体对象
        /// </summary>
        /// <param name="dr">IDataReader</param>
        /// <returns>PfmReportRecord实体对象</returns>
        public static PfmReportRecordMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID返回一个PfmReportRecord实体对象
        /// </summary>
        /// <param name="rrdId">记录ID</param>
        /// <returns>PfmReportRecord实体对象</returns>
        public static PfmReportRecordMDL Select(long rrdId)
        {
            return _dal.Select(rrdId);
        }

        #endregion

        #region 查询操作

        #region List查询
        public static List<PfmReportRecordMDL> LSelect()
        {
            return _dal.LSelect();
        }

        public static List<PfmReportRecordMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        public static List<PfmReportRecordMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        public static List<PfmReportRecordMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region IList查询
        public static IList<PfmReportRecordMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmReportRecordMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmReportRecordMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmReportRecordMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }
        #endregion

        #region Collection查询
        public static Collection<PfmReportRecordMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmReportRecordMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmReportRecordMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmReportRecordMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region ObservableCollection查询
        public static ObservableCollection<PfmReportRecordMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }
        #endregion

        /// <summary>
        /// 得到数据表PfmReportRecord满足查询条件的记录数
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
        /// <param name="rrdId">记录ID</param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long rrdId)
        {
            return _dal.Exists(rrdId);
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
        public static List<PfmReportRecordMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportRecordMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportRecordMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmReportRecordMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region IList分页
        public static IList<PfmReportRecordMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportRecordMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportRecordMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmReportRecordMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region Collection分页
        public static Collection<PfmReportRecordMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportRecordMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportRecordMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmReportRecordMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region ObservableCollection分页
        public static ObservableCollection<PfmReportRecordMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmReportRecordMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #endregion

        #endregion
    }
}
