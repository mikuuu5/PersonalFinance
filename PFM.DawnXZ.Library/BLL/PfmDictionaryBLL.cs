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
    /// 业务逻辑层PfmDictionary
    /// </summary>
    public class PfmDictionaryBLL
    {

        #region ---------变量定义-----------

        ///<summary>
        ///得到数据工厂
        ///</summary>
        private static readonly IPfmDictionaryDAL _dal = DALFactory.PfmDictionaryDALInstance();

        #endregion

        #region ----------构造函数----------

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmDictionaryBLL()
        { }

        #endregion

        #region ---------函数定义-----------

        #region 添加

        /// <summary>
        /// 向数据表PfmDictionary中插入一条新记录
        /// </summary>
        /// <param name="pfmDictionary">PfmDictionary实体对象</param>
        /// <returns></returns>
        public static int Insert(PfmDictionaryMDL pfmDictionary)
        {
            if (pfmDictionary == null)
                return 0;
            return PfmDictionaryBLL._dal.Insert(pfmDictionary);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 向数据表PfmDictionary修改一条记录
        /// </summary>
        /// <param name="pfmDictionary">PfmDictionary实体对象</param>
        /// <returns></returns>
        public static int Update(PfmDictionaryMDL pfmDictionary)
        {
            if (pfmDictionary == null)
                return 0;
            return PfmDictionaryBLL._dal.Update(pfmDictionary);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 删除数据表PfmDictionary中的一条记录
        /// </summary>
        /// <param name="dictId"></param>
        /// <returns></returns>
        public static int Delete(long dictId)
        {
            if (dictId < 0)
                return 0;
            return PfmDictionaryBLL._dal.Delete(dictId);
        }
        /// <summary>
        /// 删除数据表PfmDictionary中的一条记录
        /// </summary>
        /// <param name="pfmDictionary">PfmDictionary实体对象</param>
        /// <returns></returns>
        public static int Delete(PfmDictionaryMDL pfmDictionary)
        {
            return PfmDictionaryBLL._dal.Delete(pfmDictionary);
        }

        #endregion

        #region 数据实体

        /// <summary>
        /// 通过DataRow创建一个PfmDictionary实体对象
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>PfmDictionary实体对象</returns>
        public static PfmDictionaryMDL Select(DataRow row)
        {
            return PfmDictionaryBLL._dal.Select(row);
        }
        /// <summary>
        /// 通过DataReader创建一个PfmDictionary实体对象
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>PfmDictionary实体对象</returns>
        public static PfmDictionaryMDL Select(IDataReader dr)
        {
            return PfmDictionaryBLL._dal.Select(dr);
        }
        /// <summary>
        /// 根据ID,返回一个PfmDictionary实体对象
        /// </summary>
        /// <param name="dictId"></param>
        /// <returns>PfmDictionary实体对象</returns>
        public static PfmDictionaryMDL Select(long dictId)
        {
            return PfmDictionaryBLL._dal.Select(dictId);
        }

        #endregion

        #region 查询

        #region List
        /// <summary>
        /// 得到数据表PfmDictionary所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static List<PfmDictionaryMDL> LSelect()
        {
            return PfmDictionaryBLL._dal.LSelect();
        }/// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static List<PfmDictionaryMDL> LSelect(string where)
        {
            return PfmDictionaryBLL._dal.LSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static List<PfmDictionaryMDL> LSelect(string where, string sortField)
        {
            return PfmDictionaryBLL._dal.LSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static List<PfmDictionaryMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmDictionaryBLL._dal.LSelect(commandType, sqlCommand, param);
        }
        #endregion List

        #region IList
        /// <summary>
        /// 得到数据表PfmDictionary所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static IList<PfmDictionaryMDL> ISelect()
        {
            return PfmDictionaryBLL._dal.ISelect();
        }/// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static IList<PfmDictionaryMDL> ISelect(string where)
        {
            return PfmDictionaryBLL._dal.ISelect(where);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static IList<PfmDictionaryMDL> ISelect(string where, string sortField)
        {
            return PfmDictionaryBLL._dal.ISelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static IList<PfmDictionaryMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmDictionaryBLL._dal.ISelect(commandType, sqlCommand, param);
        }
        #endregion IList

        #region Collection
        /// <summary>
        /// 得到数据表PfmDictionary所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static Collection<PfmDictionaryMDL> CSelect()
        {
            return PfmDictionaryBLL._dal.CSelect();
        }/// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static Collection<PfmDictionaryMDL> CSelect(string where)
        {
            return PfmDictionaryBLL._dal.CSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static Collection<PfmDictionaryMDL> CSelect(string where, string sortField)
        {
            return PfmDictionaryBLL._dal.CSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static Collection<PfmDictionaryMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmDictionaryBLL._dal.CSelect(commandType, sqlCommand, param);
        }
        #endregion Collection

        #region ObservableCollection
        /// <summary>
        /// 得到数据表PfmDictionary所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmDictionaryMDL> OSelect()
        {
            return PfmDictionaryBLL._dal.OSelect();
        }/// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmDictionaryMDL> OSelect(string where)
        {
            return PfmDictionaryBLL._dal.OSelect(where);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmDictionaryMDL> OSelect(string where, string sortField)
        {
            return PfmDictionaryBLL._dal.OSelect(where, sortField);
        }
        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static ObservableCollection<PfmDictionaryMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return PfmDictionaryBLL._dal.OSelect(commandType, sqlCommand, param);
        }
        #endregion ObservableCollection

        /// <summary>
        /// 得到数据表PfmDictionary满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public static void Select(string where, out int recordCount)
        {
            PfmDictionaryBLL._dal.Select(where, out recordCount);
        }
        /// <summary>
        /// 根据主键检测是否存在该条记录
        /// </summary>
        /// <param name="dictId"></param>
        /// <returns>存在/不存在</returns>
        public static bool Exists(long dictId)
        {
            return PfmDictionaryBLL._dal.Exists(dictId);
        }
        /// <summary>
        /// 根据指定条件检测是否存在该条记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>存在/不存在</returns>
        public bool Exists(string where)
        {
            return PfmDictionaryBLL._dal.Exists(where);
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
        public static List<PfmDictionaryMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static List<PfmDictionaryMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
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
        public static List<PfmDictionaryMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static List<PfmDictionaryMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static IList<PfmDictionaryMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static IList<PfmDictionaryMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
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
        public static IList<PfmDictionaryMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static IList<PfmDictionaryMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static Collection<PfmDictionaryMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static Collection<PfmDictionaryMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
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
        public static Collection<PfmDictionaryMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static Collection<PfmDictionaryMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }
        /// <summary>
        /// 数据分页处理·SQLite
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="currentIndex">当前页码</param>
        /// <param name="recordCount">总记录数</param>
        /// <returns></returns>
        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
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
        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
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
        public static ObservableCollection<PfmDictionaryMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return PfmDictionaryBLL._dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }
        #endregion ObservableCollection

        #endregion 数据分页处理·SQLite

    }
}
