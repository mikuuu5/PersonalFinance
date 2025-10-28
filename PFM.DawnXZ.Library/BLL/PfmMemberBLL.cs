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
    /// 业务逻辑层PfmMember
    /// </summary>
    public class PfmMemberBLL
    {
        #region ---------变量定义-----------

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmMemberDAL _dal = DALFactory.PfmMemberDALInstance();

        #endregion

        #region ---------函数定义-----------

        #region 基本CRUD操作

        /// <summary>
        /// 向数据表PfmMember中插入一条新记录
        /// </summary>
        /// <param name="pfmMember">PfmMember实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Insert(PfmMemberMDL pfmMember)
        {
            return pfmMember == null ? 0 : _dal.Insert(pfmMember);
        }

        /// <summary>
        /// 向数据表PfmMember修改一条记录
        /// </summary>
        /// <param name="pfmMember">PfmMember实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Update(PfmMemberMDL pfmMember)
        {
            return pfmMember == null ? 0 : _dal.Update(pfmMember);
        }

        /// <summary>
        /// 删除数据表PfmMember中的一条记录
        /// </summary>
        /// <param name="mbrId">会员ID</param>
        /// <returns>影响的行数</returns>
        public static int Delete(long mbrId)
        {
            return mbrId < 0 ? 0 : _dal.Delete(mbrId);
        }

        /// <summary>
        /// 删除数据表PfmMember中的一条记录
        /// </summary>
        /// <param name="pfmMember">PfmMember实体对象</param>
        /// <returns>影响的行数</returns>
        public static int Delete(PfmMemberMDL pfmMember)
        {
            return _dal.Delete(pfmMember);
        }

        #endregion

        #region 数据实体操作

        /// <summary>
        /// 通过DataRow创建一个PfmMember实体对象
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PfmMember实体对象</returns>
        public static PfmMemberMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 通过DataReader创建一个PfmMember实体对象
        /// </summary>
        /// <param name="dr">IDataReader</param>
        /// <returns>PfmMember实体对象</returns>
        public static PfmMemberMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID返回一个PfmMember实体对象
        /// </summary>
        /// <param name="mbrId">会员ID</param>
        /// <returns>PfmMember实体对象</returns>
        public static PfmMemberMDL Select(long mbrId)
        {
            return _dal.Select(mbrId);
        }

        #endregion

        #region 查询操作

        #region List查询
        public static List<PfmMemberMDL> LSelect()
        {
            return _dal.LSelect();
        }

        public static List<PfmMemberMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        public static List<PfmMemberMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        public static List<PfmMemberMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region IList查询
        public static IList<PfmMemberMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmMemberMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmMemberMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmMemberMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }
        #endregion

        #region Collection查询
        public static Collection<PfmMemberMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmMemberMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmMemberMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmMemberMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }
        #endregion

        #region ObservableCollection查询
        public static ObservableCollection<PfmMemberMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmMemberMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmMemberMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmMemberMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }
        #endregion

        /// <summary>
        /// 得到数据表PfmMember满足查询条件的记录数
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
        /// <param name="mbrId">会员ID</param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long mbrId)
        {
            return _dal.Exists(mbrId);
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
        public static List<PfmMemberMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmMemberMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmMemberMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmMemberMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region IList分页
        public static IList<PfmMemberMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmMemberMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmMemberMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmMemberMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region Collection分页
        public static Collection<PfmMemberMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmMemberMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmMemberMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmMemberMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #region ObservableCollection分页
        public static ObservableCollection<PfmMemberMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmMemberMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmMemberMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmMemberMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion

        #endregion

        #endregion
    }
}
