using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class BookServices : IBookServices
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
        public async Task insertManyAsync(List<Book> books)
        {
            await _bookRepository.insertManyAsync(books);
        }

        public async Task DeleteMultipleBooksAsync(List<int> bookIds)
        {
            await _bookRepository.DeleteMultipleBooksAsync(bookIds);
        }
        public async Task DeleteSingleDataAsync(int id, Book book)
        {
            await _bookRepository.DeleteSingleDataAsync(id, book);
        }

        public async Task UpdateSingleDataAsync(int id, Book book)=>
            await _bookRepository.UpdateSingleDataAsync(id, book);

      public async  Task<List<Book>> GetAllAsync()=>
            await _bookRepository.GetAllAsync();    

    }
}
