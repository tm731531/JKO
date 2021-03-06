using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JKO.Model.DTO
{
    [Table("jko_user")]
    public class JKOUserDto
    {
        /// <summary>
        /// 自動生成ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 註冊名稱
        /// </summary>
        public string user_name { get; set; }
    }
}
