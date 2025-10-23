﻿using System;
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
    /// 业务逻辑层PfmIaeItems
    /// </summary>
    public class PfmIaeItemsBLL
    {

        #region ---------变量定义-----------

        ///<summary>
        ///得到数据工厂
        ///</summary>
        private static readonly IPfmIaeItemsDAL _dal = DALFactory.PfmIaeItemsDALInstance();

        #endregion

        #region ----------构造函数----------

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeItemsBLL()
        { }

        #endregion

        #region ---------函数定义-----------

        #region 添加

        /// <summary>
        /// 向数据表PfmIaeItems中插入一条新记录
        /// </summary>
        /// <param name="pfmIaeItems">PfmIaeItems实体对象</param>
        /// <returns></returns>
        public static int Insert(PfmIaeItemsMDL pfmIaeItems)
        {
            if (pfmIaeItems == null)
                return 0;
            return PfmIaeItemsBLL._dal.Insert(pfmIaeItems);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 向数据表PfmIaeItems修改一条记录
        /// </summary>
        /// <param name="pfmIaeItems">PfmIaeItems实体对象</param>
        /// <returns></returns>
        public static int Update(PfmIaeItemsMDL pfmIaeItems)
        {
            if (pfmIaeItems == null)
                return 0;
            return PfmIaeItemsBLL._dal.Update(pfmIaeItems);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 删除数据表PfmIaeItems中的一条记录
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static int Delete(long itemId)
        {
            if (itemId < 0)
                return 0;
            return PfmIaeItemsBLL._dal.Delete(itemId);
        }
        /// <summary>
        /// 删除数据表PfmIaeItems中的一条记录
        /// </summary>
        /// <param name="pfmIaeItems">PfmIaeItems实体对象</param>
        /// <returns></returns>
        public static int Delete(PfmIaeItemsMDL pfmIaeItems)
        {
            return PfmIaeItemsBLL._dal.Delete(pfmIaeItems);
        }

        #endregion

        #region 数据实体

        /// <summary>
        /// 通过DataRow创建一个PfmIaeItems实体对象
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>PfmIaeItems实体对象</returns>
        public static PfmIaeItemsMDL Select(DataRow row)
        {
            return PfmIaeItemsBLL._dal.Select(row);
        }
        /// <summary>
        /// 通过DataReader创建一个PfmIaeItems实体对象
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>PfmIaeItems实体对象</returns>
        public static PfmIaeItemsMDL Select(IDataReader dr)
        {
            return PfmIaeItemsBLL._dal.Select(dr);
        }
        /// <summary>
        /// 根据ID,返回一个PfmIaeItems实体对象
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns>PfmIaeItems实体对象</returns>
        public static PfmIaeItemsMDL Select(long itemId)
        {
            return PfmIaeItemsBLL._dal.Select(itemId);
        }

        #endregion

        #region 查询

        #region List
        /// <summary>
        /// 得到数据表PfmIaeItems所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static List<PfmIaeItemsMDL> LSelect()
        {
            return PfmIaeItemsBLL._dal.LSelect();
        }/// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static List<PfmIaeItemsMDL> LSelect(string where)
        {
            return PfmIaeItemsBLL._dal.LSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static List<PfmIaeItemsMDL> LSelect(string where, string sortField)
        {
            return PfmIaeItemsBLL._dal.LSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static List<PfmIaeItemsMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmIaeItemsBLL._dal.LSelect(commandType, sqlCommand, param);
        }
        #endregion List

        #region IList
        /// <summary>
        /// 得到数据表PfmIaeItems所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static IList<PfmIaeItemsMDL> ISelect()
        {
            return PfmIaeItemsBLL._dal.ISelect();
        }/// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static IList<PfmIaeItemsMDL> ISelect(string where)
        {
            return PfmIaeItemsBLL._dal.ISelect(where);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static IList<PfmIaeItemsMDL> ISelect(string where, string sortField)
        {
            return PfmIaeItemsBLL._dal.ISelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static IList<PfmIaeItemsMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmIaeItemsBLL._dal.ISelect(commandType, sqlCommand, param);
        }
        #endregion IList

        #region Collection
        /// <summary>
        /// 得到数据表PfmIaeItems所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static Collection<PfmIaeItemsMDL> CSelect()
        {
            return PfmIaeItemsBLL._dal.CSelect();
        }/// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static Collection<PfmIaeItemsMDL> CSelect(string where)
        {
            return PfmIaeItemsBLL._dal.CSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static Collection<PfmIaeItemsMDL> CSelect(string where, string sortField)
        {
            return PfmIaeItemsBLL._dal.CSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static Collection<PfmIaeItemsMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmIaeItemsBLL._dal.CSelect(commandType, sqlCommand, param);
        }
        #endregion Collection

        #region ObservableCollection
        /// <summary>
        /// 得到数据表PfmIaeItems所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelect()
        {
            return PfmIaeItemsBLL._dal.OSelect();
        }/// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelect(string where)
        {
            return PfmIaeItemsBLL._dal.OSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelect(string where, string sortField)
        {
            return PfmIaeItemsBLL._dal.OSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmIaeItemsBLL._dal.OSelect(commandType, sqlCommand, param);
        }
        #endregion ObservableCollection

        /// <summary>
        /// 得到数据表PfmIaeItems满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public static void Select(string where, out int recordCount)
        {
            PfmIaeItemsBLL._dal.Select(where, out recordCount);
        }
        /// <summary>
        /// 根据主键检测是否存在该条记录
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long itemId)
        {
            return PfmIaeItemsBLL._dal.Exists(itemId);
        }
        /// <summary>
        /// 根据指定条件检测是否存在该条记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>存在/不存在</returns>
        public bool Exists(string where)
        {
            return PfmIaeItemsBLL._dal.Exists(where);
        }

        #endregion

        #endregion

        #region 数据分页处理·SQLite

        #region List
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static List<PfmIaeItemsMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static List<PfmIaeItemsMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static List<PfmIaeItemsMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static List<PfmIaeItemsMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion List

        #region IList
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static IList<PfmIaeItemsMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static IList<PfmIaeItemsMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static IList<PfmIaeItemsMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static IList<PfmIaeItemsMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion IList

        #region Collection
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static Collection<PfmIaeItemsMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static Collection<PfmIaeItemsMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static Collection<PfmIaeItemsMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static Collection<PfmIaeItemsMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion Collection

        #region ObservableCollection
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strColumns">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrder">排序字段</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static ObservableCollection<PfmIaeItemsMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmIaeItemsBLL._dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion ObservableCollection

        #endregion 数据分页处理·SQLite

    }
}
