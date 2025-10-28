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
    /// 收支分类业务逻辑层
    /// </summary>
    public class PfmIaeCategoryBLL
    {
        #region 变量定义

        /// <summary>
        /// 数据访问层实例
        /// </summary>
        private static readonly IPfmIaeCategoryDAL _dal = DALFactory.PfmIaeCategoryDALInstance();

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PfmIaeCategoryBLL()
        {
        }

        #endregion

        #region 基本操作

        #region 获取最大ID

        /// <summary>
        /// 获取当前最大系统编号
        /// </summary>
        /// <returns>最大ID值</returns>
        public static int GetMaxId()
        {
            return _dal.GetMaxId();
        }

        #endregion

        #region 添加

        /// <summary>
        /// 插入收支分类记录
        /// </summary>
        /// <param name="pfmIaeCategory">收支分类实体对象</param>
        /// <param name="addFlag">添加标记：False-主分类，True-子分类</param>
        /// <returns>影响行数</returns>
        public static int Insert(PfmIaeCategoryMDL pfmIaeCategory, bool addFlag)
        {
            if (pfmIaeCategory == null) return 0;
            return _dal.Insert(pfmIaeCategory, addFlag);
        }

        #endregion

        #region 修改

        /// <summary>
        /// 更新收支分类记录
        /// </summary>
        /// <param name="pfmIaeCategory">收支分类实体对象</param>
        /// <returns>影响行数</returns>
        public static int Update(PfmIaeCategoryMDL pfmIaeCategory)
        {
            if (pfmIaeCategory == null) return 0;
            return _dal.Update(pfmIaeCategory);
        }

        #endregion

        #region 点击率

        /// <summary>
        /// 更新分类点击率
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <returns>影响行数</returns>
        public static int UpdateClick(int catId)
        {
            if (catId < 0) return 0;
            return _dal.UpdateClick(catId);
        }

        #endregion

        #region 数据统计

        /// <summary>
        /// 更新分类数据统计
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <param name="countFlag">统计标记：0-添加，1-删除</param>
        /// <returns>影响行数</returns>
        public static int UpdateCounts(int catId, byte countFlag)
        {
            if (catId < 0) return 0;
            return _dal.UpdateCounts(catId, countFlag);
        }

        #endregion

        #region 变更

        /// <summary>
        /// 变更分类父级关系
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <param name="catFather">父级ID</param>
        /// <returns>影响行数</returns>
        public static int Change(int catId, int catFather)
        {
            if (catId < 0) return 0;
            return _dal.Change(catId, catFather);
        }

        #endregion

        #region 删除

        /// <summary>
        /// 删除收支分类记录
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <param name="delFlag">删除标记：False-删除指定，True-删除所有</param>
        /// <returns>影响行数</returns>
        public static int Delete(int catId, bool delFlag)
        {
            if (catId < 0) return 0;
            return _dal.Delete(catId, delFlag);
        }

        #endregion

        #region 实体对象

        /// <summary>
        /// 从DataRow创建收支分类实体
        /// </summary>
        /// <param name="row">数据行</param>
        /// <returns>收支分类实体</returns>
        public static PfmIaeCategoryMDL Select(DataRow row)
        {
            return _dal.Select(row);
        }

        /// <summary>
        /// 从DataReader创建收支分类实体
        /// </summary>
        /// <param name="dr">数据读取器</param>
        /// <returns>收支分类实体</returns>
        public static PfmIaeCategoryMDL Select(IDataReader dr)
        {
            return _dal.Select(dr);
        }

        /// <summary>
        /// 根据ID获取收支分类实体
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <returns>收支分类实体</returns>
        public static PfmIaeCategoryMDL Select(int catId)
        {
            return _dal.Select(catId);
        }

        #endregion

        #region 查询

        #region List查询

        /// <summary>
        /// 获取所有收支分类记录
        /// </summary>
        /// <returns>收支分类列表</returns>
        public static List<PfmIaeCategoryMDL> LSelect()
        {
            return _dal.LSelect();
        }

        /// <summary>
        /// 获取所有父级分类记录
        /// </summary>
        /// <returns>父级分类列表</returns>
        public static List<PfmIaeCategoryMDL> LSelectFather()
        {
            return _dal.LSelectFather();
        }

        /// <summary>
        /// 根据条件查询收支分类记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>收支分类列表</returns>
        public static List<PfmIaeCategoryMDL> LSelect(string where)
        {
            return _dal.LSelect(where);
        }

        /// <summary>
        /// 根据条件和排序查询收支分类记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>收支分类列表</returns>
        public static List<PfmIaeCategoryMDL> LSelect(string where, string sortField)
        {
            return _dal.LSelect(where, sortField);
        }

        /// <summary>
        /// 执行自定义SQL查询
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">SQL参数</param>
        /// <returns>收支分类列表</returns>
        public static List<PfmIaeCategoryMDL> LSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.LSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region IList查询

        public static IList<PfmIaeCategoryMDL> ISelect()
        {
            return _dal.ISelect();
        }

        public static IList<PfmIaeCategoryMDL> ISelectFather()
        {
            return _dal.ISelectFather();
        }

        public static IList<PfmIaeCategoryMDL> ISelect(string where)
        {
            return _dal.ISelect(where);
        }

        public static IList<PfmIaeCategoryMDL> ISelect(string where, string sortField)
        {
            return _dal.ISelect(where, sortField);
        }

        public static IList<PfmIaeCategoryMDL> ISelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.ISelect(commandType, sqlCommand, param);
        }

        #endregion

        #region Collection查询

        public static Collection<PfmIaeCategoryMDL> CSelect()
        {
            return _dal.CSelect();
        }

        public static Collection<PfmIaeCategoryMDL> CSelectFather()
        {
            return _dal.CSelectFather();
        }

        public static Collection<PfmIaeCategoryMDL> CSelect(string where)
        {
            return _dal.CSelect(where);
        }

        public static Collection<PfmIaeCategoryMDL> CSelect(string where, string sortField)
        {
            return _dal.CSelect(where, sortField);
        }

        public static Collection<PfmIaeCategoryMDL> CSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.CSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region ObservableCollection查询

        public static ObservableCollection<PfmIaeCategoryMDL> OSelect()
        {
            return _dal.OSelect();
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelectFather()
        {
            return _dal.OSelectFather();
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelect(string where)
        {
            return _dal.OSelect(where);
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelect(string where, string sortField)
        {
            return _dal.OSelect(where, sortField);
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelect(CommandType commandType, string sqlCommand, params SQLiteParameter[] param)
        {
            return _dal.OSelect(commandType, sqlCommand, param);
        }

        #endregion

        #region 递归查询

        /// <summary>
        /// 递归查询所有分类记录
        /// </summary>
        /// <param name="mainMark">主制表符</param>
        /// <param name="childMark">子制表符</param>
        /// <returns>递归分类列表</returns>
        public static IList<PfmIaeCategoryMDL> RecursiveI(string mainMark, string childMark)
        {
            return _dal.RecursiveI(mainMark, childMark);
        }

        #endregion

        /// <summary>
        /// 获取分类记录数量
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数量</param>
        public static void Select(string where, out int recordCount)
        {
            _dal.Select(where, out recordCount);
        }

        #region 存在性检查

        /// <summary>
        /// 检查分类记录是否存在
        /// </summary>
        /// <param name="catId">分类ID</param>
        /// <returns>是否存在</returns>
        public static bool Exists(int catId)
        {
            return _dal.Exists(catId);
        }

        /// <summary>
        /// 检查分类名称是否存在
        /// </summary>
        /// <param name="catName">分类名称</param>
        /// <returns>是否存在</returns>
        public static bool Exists(string catName)
        {
            return _dal.Exists(catName);
        }

        /// <summary>
        /// 检查分类点击率是否存在
        /// </summary>
        /// <param name="catClick">点击率</param>
        /// <returns>是否存在</returns>
        public static bool ExistsClick(int catClick)
        {
            return _dal.ExistsClick(catClick);
        }

        /// <summary>
        /// 检查父级分类是否存在
        /// </summary>
        /// <param name="catFather">父级ID</param>
        /// <returns>是否存在</returns>
        public static bool ExistsFather(int catFather)
        {
            return _dal.ExistsFather(catFather);
        }

        /// <summary>
        /// 检查分类名称和父级是否存在
        /// </summary>
        /// <param name="catName">分类名称</param>
        /// <param name="catFather">父级ID</param>
        /// <returns>是否存在</returns>
        public static bool Exists(string catName, int catFather)
        {
            return _dal.Exists(catName, catFather);
        }

        #endregion

        #endregion

        #endregion

        #region 数据分页

        #region List分页

        public static List<PfmIaeCategoryMDL> LSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeCategoryMDL> LSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeCategoryMDL> LSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static List<PfmIaeCategoryMDL> LSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.LSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region IList分页

        public static IList<PfmIaeCategoryMDL> ISelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeCategoryMDL> ISelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeCategoryMDL> ISelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static IList<PfmIaeCategoryMDL> ISelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.ISelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region Collection分页

        public static Collection<PfmIaeCategoryMDL> CSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeCategoryMDL> CSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeCategoryMDL> CSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static Collection<PfmIaeCategoryMDL> CSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.CSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #region ObservableCollection分页

        public static ObservableCollection<PfmIaeCategoryMDL> OSelectPaging(int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelectPaging(string strWhere, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelectPaging(string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        public static ObservableCollection<PfmIaeCategoryMDL> OSelectPaging(string strColumns, string strWhere, string strOrder, int pageSize, int currentIndex, out int recordCount)
        {
            return _dal.OSelectPaging(strColumns, strWhere, strOrder, pageSize, currentIndex, out recordCount);
        }

        #endregion

        #endregion
    }
}
