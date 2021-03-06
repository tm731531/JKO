using JKO.Dao.Connection;
using JKO.Dao.Repositry;
using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Dao
{
    public class MainRepository
    {
        public UserRepositry userRepositry;
        public ListRepositry  listRepositry;
        

        public MainRepository() {
            userRepositry = new UserRepositry(new AzureDB());
            listRepositry= new ListRepositry(new AzureDB());
        }
    }
}
