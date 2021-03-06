using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Dao.Interface
{
   public  interface IRepositry<T>
    {
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int InsertDto(T data);

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool DeleteDto(T data);
        
        /// <summary>
        /// 查詢資料
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        IEnumerable<T> SearchDto(T data);

    }
}
