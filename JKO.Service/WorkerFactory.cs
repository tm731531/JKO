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
            switch (jobName)
            {
                case "REGISTER":
                    //註冊User
                    throw new Exception("還沒做");
                case "CREATE_LISTING":
                    //建立 list
                    throw new Exception("還沒做");
                case "GET_LISTING":
                    //取得 list
                    throw new Exception("還沒做");
                case "GET_CATEGORY":
                    //取得 分類
                    throw new Exception("還沒做");
                case "GET_TOP_CATEGORY":
                    //取得 排名
                    throw new Exception("還沒做");

                case "DELETE_LISTING":
                    //刪除清單 
                    throw new Exception("還沒做");

                    


                default:
                    break;
            }

          
            return worker;
        }
    }
}
