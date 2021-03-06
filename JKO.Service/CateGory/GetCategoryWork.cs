using JKO.Dao;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JKO.Service
{

    /// <summary>
    /// 取得商品分類
    /// </summary>
    class GetCategoryWork : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public GetCategoryWork(string[] args, MainRepository mainRepository)
        {
            _args = args;
            _mainRepository = mainRepository;
        }
        public void DoWork()
        {
            try
            {
                IEnumerable<JKOUserDto> userData = _mainRepository.userRepositry.SearchDto(new Model.DTO.JKOUserDto() { user_name = _args[1] });
                if (userData.Count() == 0)
                {
                    Console.WriteLine("Error - unknown user");
                    return;
                }
                var datas = _mainRepository.listRepositry.SearchDto(new JKOListingDto() { user_name = _args[1] });
                if (datas.Where(x => x.category == _args[2]).Count() == 0)
                {
                    Console.WriteLine("Error - category not found");
                }
                else
                {
                    foreach (var data in GetOrderData(datas))
                    {
                        Console.WriteLine($"{data.title}|{data.description}|{data.price}|{data.create_time}|{data.category}|{data.user_name}");
                    }


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error {ex.Message}");
            }
        }

        private IEnumerable<JKOListingDto> GetOrderData(IEnumerable<JKOListingDto> datas)
        {
            if (_args[3] == "sort_price" && _args[4] == "asc")
            { datas = datas.OrderBy(x => x.price); }
            else if (_args[3] == "sort_price" && _args[4] == "dsc")
            { datas = datas.OrderByDescending(x => x.price); }
            else if (_args[3] == "sort_time" && _args[4] == "asc")
            { datas = datas.OrderBy(x => x.create_time); }
            else if (_args[3] == "sort_time" && _args[4] == "dsc")
            { datas = datas.OrderByDescending(x => x.create_time); }

            return datas;
        }
    }
}
