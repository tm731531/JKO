using JKO.Dao;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JKO.Service
{
    /// <summary>
    /// 取得第一名數量的分類
    /// </summary>
    class GetTopCategoryWork : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public GetTopCategoryWork(string[] args, MainRepository mainRepository)
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
                var targetCategory = datas.GroupBy(x => x.category).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
                Console.WriteLine(targetCategory);
            }
            catch (Exception ex) {


                Console.WriteLine($"Error {ex.Message}");
            }
        }
    }
}
