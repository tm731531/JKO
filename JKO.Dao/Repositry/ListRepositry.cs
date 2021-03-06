using Dapper;
using JKO.Dao.Interface;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Dao.Repositry
{



    public class ListRepositry : IRepositry<JKOListingDto>
    {
        private IDatabaseConnection _DatabaseConnection;

        public ListRepositry(IDatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }
        public bool DeleteDto(JKOListingDto jKOListingDto)
        {
            var sqlstr = @" UPDATE  [jko_listing] WITH (tablock)
                            SET is_deleted=1
                            WHERE id = @id";
            using (var conn = _DatabaseConnection.Create())
            {
                conn.Execute(sqlstr, jKOListingDto);
                return true;
            }
        }

        public int InsertDto(JKOListingDto jKOListingDto)
        {
            var sqlstr = @"INSERT INTO [dbo].[jko_listing]
                                      ([title]
                                      ,[description]
                                      ,[price]
                                      ,[user_name]
                                      ,[category]
                                      )
                                OUTPUT INSERTED.[id]
                                VALUES
                                      (@title
                                      ,@description
                                      ,@price
                                      ,@user_name
                                      ,@category
                                      )";
            using (var conn = _DatabaseConnection.Create())
            {
                return conn.QuerySingle<int>(sqlstr, jKOListingDto);

            }
        }

        public IEnumerable<JKOListingDto> SearchDto(JKOListingDto jKOListingDto)
        {

            var sqlstr = @"SELECT [id]
                                 ,[title]
                                 ,[description]
                                 ,[price]
                                 ,[user_name]
                                 ,[category]
                                 ,[create_time]
                             FROM [dbo].[jko_listing](nolock)
                             WHERE is_deleted=0
                             ";
            if (jKOListingDto.id > 0) { sqlstr += " AND id = @id "; }
            if (!string.IsNullOrEmpty(jKOListingDto.user_name)) { sqlstr += " AND user_name = @user_name "; }

            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOListingDto>(sqlstr, jKOListingDto);
                return rtndata;
            }
        }

        public IEnumerable<JKOListingDto> SearchAllDto()
        {
            var sqlstr = @"SELECT [id]
                                 ,[title]
                                 ,[description]
                                 ,[price]
                                 ,[user_name]
                                 ,[category]
                                 ,[create_time]
                             FROM [dbo].[jko_listing](nolock)
                             WHERE is_deleted=0";
            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOListingDto>(sqlstr);
                return rtndata;
            }
        }
    }
}
