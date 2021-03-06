using System;
using System.Collections.Generic;
using System.Text;

namespace JKO.Dao.Interface
{
   public  interface IRepositry<T>
    {
        int InsertDto(T data);
        bool DeleteDto(T data);
        IEnumerable<T> SearchDto(T data);

    }
}
