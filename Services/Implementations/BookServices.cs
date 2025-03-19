using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class BookServices:IBookServices
    {
        private readonly IBookRepository _bookRepository;
        public BookServices(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task insertDataAsync(Book books)
        {
            await _bookRepository.insertDataAsync(books);
        }
    }
}
