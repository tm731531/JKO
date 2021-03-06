using JKO.Dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Service
{
    public class WorkerFactory
    {
        public IWorker GetWorker(string[] args)
        {

            IWorker worker = null;
            var jobName = args[0];
            MainRepository mainRepository = new MainRepository();
            switch (jobName)
            {
                case "REGISTER":
                    //註冊User
                    worker = new CreateUserWork(args, mainRepository);
                    break;
                case "CREATE_LISTING":
                    //建立 list
                    worker = new CreateListing(args, mainRepository);
                    break;
                case "GET_LISTING":

                    //取得 list
                    worker = new GETLISTING(args, mainRepository);
                    break;
                case "GET_CATEGORY":
                    //取得 分類
                    throw new Exception("還沒做");
                    break;
                case "GET_TOP_CATEGORY":
                    //取得 排名
                    throw new Exception("還沒做");
                    break;

                case "DELETE_LISTING":
                    //刪除清單 
                    worker = new DeleteLisiting(args, mainRepository);
                    break;




                default:
                    break;
            }

          
            return worker;
        }
    }
}
