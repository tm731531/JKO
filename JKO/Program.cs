using JKO.Dao;
using JKO.Model.DTO;
using JKO.Service;
using System;

namespace JKO
{
    class Program
    {
        static void Main(string[] args)
         {
            var crawler = new WorkerFactory().GetWorker(args);
            if (crawler != null)
            {
                crawler.DoWork();
            }
            else {
                Console.WriteLine("Error Job Type");
            }
        }
    }
}
