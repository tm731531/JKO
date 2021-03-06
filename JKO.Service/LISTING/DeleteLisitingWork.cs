using JKO.Dao;
using JKO.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JKO.Service
{
    class DeleteLisitingWork : IWorker
    {
        private string[] _args;
        private MainRepository _mainRepository;

        public DeleteLisitingWork(string[] args, MainRepository mainRepository)
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
                    Console.WriteLine("Error - listing does not exist");
                }
                else
                {
                    if (checkData.First().user_name != _args[1])
                    {
                        Console.WriteLine("Error - listing owner mismatch");
                    }
                    else
                    {
                        _mainRepository.listRepositry.DeleteDto(
                      new JKOListingDto()
                      {
                          id = targetId
                      });
                        Console.WriteLine("Success");


                    }
                }


            }
            catch (Exception ex)
            {

            }
        }
    }
}
