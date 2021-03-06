﻿using JKO.Dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Service.CateGory
{
    class GetCategory : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public GetCategory(string[] args, MainRepository mainRepository)
        {
            _args = args;
            _mainRepository = mainRepository;
        }
        public void DoWork()
        {
            _mainRepository.listRepositry.SearchDto()
            IEnumerable<JKOUserDto> userData = _mainRepository.userRepositry.SearchDto(new Model.DTO.JKOUserDto() { user_name = _args[1] });
            if (userData.Count() == 0)
            {
                Console.WriteLine("Error - unknown user");

            }
            else
            {
                try
                {
                    var returnData = _mainRepository.listRepositry.InsertDto(
                          new JKOListingDto()
                          {
                              user_name = _args[1]
                          ,
                              title = _args[2]
                          ,
                              description = _args[3]
                          ,
                              price = Convert.ToInt32(_args[4])
                          ,
                              category = _args[5]
                          });
                    Console.WriteLine(returnData);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
