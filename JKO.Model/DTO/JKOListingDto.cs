using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JKO.Model.DTO
{
    [Table("jko_listing")]
  public   class JKOListingDto
    {
        /// <summary>
        /// 自動生成ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 敘述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 價格
        /// </summary>
        public int price { get; set; }
        /// <summary>
        /// 註冊名稱
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 分類
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 是否刪除
        /// </summary>
        public bool is_deleted { get; set; }

        /// <summary>
        /// 生成時間
        /// </summary>
        public DateTime create_time { get; set; }
    }
}
