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
            var sqlstr = @" DELETE  [jko_user] WITH (tablock)
                            WHERE id = @id";
            using (var conn = _DatabaseConnection.Create())
            {
                conn.Execute(sqlstr, jKOListingDto);
                return true;
            }
        }

        public bool InsertDto(JKOListingDto jKOListingDto)
        {
            var sqlstr = @"INSERT INTO [dbo].[jko_listing]
                                      ([title]
                                      ,[description]
                                      ,[price]
                                      ,[user_name]
                                      ,[category]
                                      )
                                VALUES
                                      (@title
                                      ,@description
                                      ,@price
                                      ,@user_name
                                      ,@category
                                      )";
            using (var conn = _DatabaseConnection.Create())
            {
                conn.Execute(sqlstr, jKOListingDto);
                return true;
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
                             FROM [dbo].[jko_listing](nolock)";
            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOListingDto>(sqlstr);
                return rtndata;
            }
        }

        public IEnumerable<JKOListingDto> SearchAllDto() {
            var sqlstr = @"SELECT [id]
                                 ,[title]
                                 ,[description]
                                 ,[price]
                                 ,[user_name]
                                 ,[category]
                                 ,[create_time]
                             FROM [dbo].[jko_listing](nolock)";
            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOListingDto>(sqlstr);
                return rtndata;
            }
        }
    }
}
