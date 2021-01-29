using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Entities;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Library.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBookDataRepository _bookDataRepository;

        public IEnumerable<BookData> BookDatas { get; set; }


        public IndexModel(IBookDataRepository bookDataRepository)
        {
            _bookDataRepository = bookDataRepository;
        }

        public async Task OnGet()
        {
            this.BookDatas = await _bookDataRepository.GetAllBookDatas();
        }
    }
}
