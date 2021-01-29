using Library.Data;
using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class BookDataRepository : IBookDataRepository
    {
        private readonly ApplicationDbContext _context;

        public BookDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BookData>> GetAllBookDatas()
        {
            return await _context.BookDatas.ToListAsync();
        }
    }
}
