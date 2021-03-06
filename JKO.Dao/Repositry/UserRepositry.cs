using JKO.Dao.Interface;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace JKO.Dao.Repositry
{



    public class UserRepositry : IRepositry<JKOUserDto>
    {
        private IDatabaseConnection _DatabaseConnection;

        public UserRepositry(IDatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }
        public bool DeleteDto(JKOUserDto jKOUserDto)
        {
            var sqlstr = @" DELETE  [jko_user] WITH (tablock)
                            WHERE id = @id";
            using (var conn = _DatabaseConnection.Create())
            {
                conn.Execute(sqlstr, jKOUserDto);
                return true;
            }
        }

        public int InsertDto(JKOUserDto jKOUserDto)
        {
            var sqlstr = @"INSERT INTO [dbo].[jko_user]
                                         ([user_name]) 
                                  OUTPUT INSERTED.[id]
                                  VALUES
                                         (@user_name)";
            using (var conn = _DatabaseConnection.Create())
            {
                return conn.QuerySingle<int>(sqlstr, jKOUserDto);
            }

        }

        public IEnumerable<JKOUserDto> SearchDto(JKOUserDto jKOUserDto)
        {
            var sqlstr = @"SELECT [id]
                                 ,[user_name]
                           FROM [dbo].[jko_user]
                           WHERE user_name = @user_name";
            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOUserDto>(sqlstr, jKOUserDto);
                return rtndata;
            }
        }
        public IEnumerable<JKOUserDto> SearchAllDto()
        {
            var sqlstr = @"SELECT [id]
                                 ,[user_name]
                           FROM [dbo].[jko_user](nolock)";
            using (var conn = _DatabaseConnection.Create())
            {
                var rtndata = conn.Query<JKOUserDto>(sqlstr);
                return rtndata;
            }
        }
    }
}
