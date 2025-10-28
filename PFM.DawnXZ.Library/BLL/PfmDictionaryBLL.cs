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
    /// 业务逻辑层PfmDictionary
    /// </summary>
    public class PfmDictionaryBLL
    {
        #region 变量定义

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmDictionaryDAL _dal = DALFactory.PfmDictionaryDALInstance();

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmDictionaryBLL()
        {
        }

        #endregion

        #region 基本操作

        #region 添加

        /// <summary>
        /// 插入新记录
        /// </summary>
        /// <param name="pfmDictionary">实体对象</param>
        /// <returns>影响行数</returns>
        public static int Insert(PfmDictionaryMDL pfmDictionary)
        {
            if (pfmDictionary == null) return 0;
            return _dal.Insert(pfmDictionary);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="pfmDictionary">实体对象</param>
        /// <returns>影响行数</returns>
        public static int Update(PfmDictionaryMDL pfmDictionary)
        {
            if (pfmDictionary == null) return 0;
            return _dal.Update(pfmDictionary);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="dictId">字典ID</param>
        /// <returns>影响行数</returns>
        public static int Delete(long dictId)
        {
            if (dictId < 0) return 0;
            return _dal.Delete(dictId);
        }

        /// <summary>
        /// 根据实体删除记录
        /// </summary>
        /// <param name="pfmDictionary">实体对象</param>
        /// <returns>影响行数</returns>
        public static int Delete(PfmDictionaryMDL pfmDictionary)
        {
            return _dal.Delete(pfmDictionary);
        }

        #endregion

        #region 数据实体

        /// <summary>
        /// 从DataRow创建实体
        /// </summary>
        /// <param name="row">数据行</param>
        /// <returns>实体对象</returns>
        public static PfmDictionaryMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 从DataReader创建实体
        /// </summary>
        /// <param name="dr">数据读取器</param>
        /// <returns>实体对象</returns>
        public static PfmDictionaryMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="dictId">字典ID</param>
        /// <returns>实体对象</returns>
        public static PfmDictionaryMDL Select(long dictId)
        {
            return _dal.Select(dictId);
        }

        #endregion

        #region 查询

        #region List查询

        public static List<PfmDictionaryMDL> LSelect()
        {
            return _dal.LSelect();
        }

        public static List<PfmDictionaryMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        public static List<PfmDictionaryMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        public static List<PfmDictionaryMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region IList查询

        public static IList<PfmDictionaryMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmDictionaryMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmDictionaryMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmDictionaryMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }

        #endregion

        #region Collection查询

        public static Collection<PfmDictionaryMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmDictionaryMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmDictionaryMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmDictionaryMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region ObservableCollection查询

        public static ObservableCollection<PfmDictionaryMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }

        #endregion

        /// <summary>
        /// 获取记录数量
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        /// <summary>
        /// 检查记录是否存在
        /// </summary>
        /// <param name="dictId">字典ID</param>
        /// <returns>是否存在</returns>
        public static bool Exists(long dictId)
        {
            return _dal.Exists(dictId);
        }

        /// <summary>
        /// 检查记录是否存在
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

        public static List<PfmDictionaryMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmDictionaryMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmDictionaryMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmDictionaryMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region IList分页

        public static IList<PfmDictionaryMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmDictionaryMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmDictionaryMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmDictionaryMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region Collection分页

        public static Collection<PfmDictionaryMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmDictionaryMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmDictionaryMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmDictionaryMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region ObservableCollection分页

        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #endregion
    }
}
