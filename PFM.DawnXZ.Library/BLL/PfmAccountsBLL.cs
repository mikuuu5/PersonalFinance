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
    /// 业务逻辑层PfmAccounts - 负责账户相关的业务逻辑处理
    /// </summary>
    public class PfmAccountsBLL
    {
        #region ---------变量定义-----------

        /// <summary>
        /// 数据访问层实例 - 通过工厂模式获取，静态只读确保线程安全
        /// </summary>
        private static readonly IPfmAccountsDAL _dal = DALFactory.PfmAccountsDALInstance();

        #endregion

        #region ----------构造函数----------

        /// <summary>
        /// 构造函数 - 初始化业务逻辑层对象
        /// </summary>
        public PfmAccountsBLL()
        {
            // 构造函数体，可在此处添加初始化逻辑
        }

        #endregion

        #region ---------函数定义-----------

        #region 添加

        /// <summary>
        /// 向数据表PfmAccounts中插入一条新记录
        /// </summary>
        /// <param name="pfmAccounts">PfmAccounts实体对象</param>
        /// <returns>受影响的行数，0表示插入失败</returns>
        public static int Insert(PfmAccountsMDL pfmAccounts)
        {
            // 参数校验
            if (pfmAccounts == null)
                return 0;

            // 调用数据访问层执行插入操作
            return _dal.Insert(pfmAccounts);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 向数据表PfmAccounts修改一条记录
        /// </summary>
        /// <param name="pfmAccounts">PfmAccounts实体对象</param>
        /// <returns>受影响的行数，0表示更新失败</returns>
        public static int Update(PfmAccountsMDL pfmAccounts)
        {
            // 参数校验
            if (pfmAccounts == null)
                return 0;

            // 调用数据访问层执行更新操作
            return _dal.Update(pfmAccounts);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 根据账户ID删除数据表PfmAccounts中的一条记录
        /// </summary>
        /// <param name="accId">账户ID</param>
        /// <returns>受影响的行数，0表示删除失败</returns>
        public static int Delete(long accId)
        {
            // 参数校验
            if (accId < 0)
                return 0;

            // 调用数据访问层执行删除操作
            return _dal.Delete(accId);
        }

        /// <summary>
        /// 根据实体对象删除数据表PfmAccounts中的一条记录
        /// </summary>
        /// <param name="pfmAccounts">PfmAccounts实体对象</param>
        /// <returns>受影响的行数</returns>
        public static int Delete(PfmAccountsMDL pfmAccounts)
        {
            // 调用数据访问层执行删除操作
            return _dal.Delete(pfmAccounts);
        }

        #endregion

        #region 数据实体

        /// <summary>
        /// 通过DataRow创建一个PfmAccounts实体对象
        /// </summary>
        /// <param name="row">DataRow数据行</param>
        /// <returns>PfmAccounts实体对象</returns>
        public static PfmAccountsMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 通过DataReader创建一个PfmAccounts实体对象
        /// </summary>
        /// <param name="dr">IDataReader数据读取器</param>
        /// <returns>PfmAccounts实体对象</returns>
        public static PfmAccountsMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据账户ID返回一个PfmAccounts实体对象
        /// </summary>
        /// <param name="accId">账户ID</param>
        /// <returns>PfmAccounts实体对象</returns>
        public static PfmAccountsMDL Select(long accId)
        {
            return _dal.Select(accId);
        }

        #endregion

        #region 查询

        #region List查询方法

        /// <summary>
        /// 得到数据表PfmAccounts所有记录
        /// </summary>
        /// <returns>List泛型集合结果集</returns>
        public static List<PfmAccountsMDL> LSelect()
        {
            return _dal.LSelect();
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>List泛型集合结果集</returns>
        public static List<PfmAccountsMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>List泛型集合结果集</returns>
        public static List<PfmAccountsMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>List泛型集合结果集</returns>
        public static List<PfmAccountsMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region IList查询方法

        /// <summary>
        /// 得到数据表PfmAccounts所有记录
        /// </summary>
        /// <returns>IList接口集合结果集</returns>
        public static IList<PfmAccountsMDL> ISelect()
        {
            return _dal.ISelect();
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>IList接口集合结果集</returns>
        public static IList<PfmAccountsMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>IList接口集合结果集</returns>
        public static IList<PfmAccountsMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>IList接口集合结果集</returns>
        public static IList<PfmAccountsMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }

        #endregion

        #region Collection查询方法

        /// <summary>
        /// 得到数据表PfmAccounts所有记录
        /// </summary>
        /// <returns>Collection集合结果集</returns>
        public static Collection<PfmAccountsMDL> CSelect()
        {
            return _dal.CSelect();
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>Collection集合结果集</returns>
        public static Collection<PfmAccountsMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>Collection集合结果集</returns>
        public static Collection<PfmAccountsMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>Collection集合结果集</returns>
        public static Collection<PfmAccountsMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region ObservableCollection查询方法

        /// <summary>
        /// 得到数据表PfmAccounts所有记录
        /// </summary>
        /// <returns>ObservableCollection可观察集合结果集</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelect()
        {
            return _dal.OSelect();
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>ObservableCollection可观察集合结果集</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>ObservableCollection可观察集合结果集</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>ObservableCollection可观察集合结果集</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }

        #endregion

        /// <summary>
        /// 得到数据表PfmAccounts满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数 - 输出参数</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        /// <summary>
        /// 根据主键检测是否存在该条记录
        /// </summary>
        /// <param name="accId">账户ID</param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long accId)
        {
            return _dal.Exists(accId);
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

        #endregion

        #region 数据分页处理·SQLite

        #region List分页

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据列表</returns>
        public static List<PfmAccountsMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据列表</returns>
        public static List<PfmAccountsMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据列表</returns>
        public static List<PfmAccountsMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据列表</returns>
        public static List<PfmAccountsMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region IList分页

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据接口列表</returns>
        public static IList<PfmAccountsMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据接口列表</returns>
        public static IList<PfmAccountsMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据接口列表</returns>
        public static IList<PfmAccountsMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据接口列表</returns>
        public static IList<PfmAccountsMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region Collection分页

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据集合</returns>
        public static Collection<PfmAccountsMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据集合</returns>
        public static Collection<PfmAccountsMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据集合</returns>
        public static Collection<PfmAccountsMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据集合</returns>
        public static Collection<PfmAccountsMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region ObservableCollection分页

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据可观察集合</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据可观察集合</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据可观察集合</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数 - 输出参数</param>
        /// <returns>分页数据可观察集合</returns>
        public static ObservableCollection<PfmAccountsMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #endregion 数据分页处理·SQLite

    }
}
