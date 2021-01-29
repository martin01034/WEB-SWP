using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public interface IBookDataRepository
    {
        Task<IEnumerable<BookData>> GetAllBookDatas();
    }
}
