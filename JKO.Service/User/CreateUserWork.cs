using JKO.Dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Service
{
    /// <summary>
    /// 註冊user
    /// </summary>
   
    class CreateUserWork : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public CreateUserWork(string[] args, MainRepository mainRepository) {
            _args = args;
            _mainRepository = mainRepository;
        }
        public void DoWork()
        {
            try
            {
                _mainRepository.userRepositry.InsertDto(new Model.DTO.JKOUserDto() { user_name = _args[1] });
                Console.WriteLine("Success");
            }
            catch (Exception) {
                Console.WriteLine("Error - user already existing");
            }
            }
    }
}
