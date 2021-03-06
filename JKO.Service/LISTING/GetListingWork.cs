using JKO.Dao;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JKO.Service
{
    /// <summary>
    /// 取得商品清單
    /// </summary>
    class GetListingWork : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public GetListingWork(string[] args, MainRepository mainRepository)
        {
            _args = args;
            _mainRepository = mainRepository;
        }
        public void DoWork()
        {

            try
            {
                int targetId = Convert.ToInt32(_args[2]);
                var checkData = _mainRepository.listRepositry.SearchDto(
                      new JKOListingDto()
                      {
                          id = targetId
                      });
                if (checkData.Count() == 0)
                {
                    Console.WriteLine("Error - not found");
                }
                else
                {
                    var needData = checkData.First();
                    if (needData.user_name != _args[1])
                    {
                        Console.WriteLine("Error - unknown user");
                    }
                    else
                    {
                       
                        Console.WriteLine($"{needData.title}|{needData.description}|{needData.price}|{needData.create_time}|{needData.category}|{needData.user_name}");
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");

            }
        }
    }
}
