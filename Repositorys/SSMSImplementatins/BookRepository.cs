using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using Microsoft.EntityFrameworkCore;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDBContext _dbContext;
        public BookRepository(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }

        public async Task insertDataAsync(Book books)
        {
            var Lang = await _dbContext.Languages.FindAsync(books.LanguageId);
            if (Lang == null)
            {
                throw new Exception("Invalid LanguageId: Language does not exist.");
            }

            await _dbContext.Books.AddAsync(books);
            await _dbContext.SaveChangesAsync();

        }

        public async Task insertManyAsync(List<Book> books)
        {
            await _dbContext.Books.AddRangeAsync(books);
            await _dbContext.SaveChangesAsync();

        }
        public async Task DeleteMultipleBooksAsync(List<int> bookIds)
        {
            var books = await _dbContext.Books
                                        .Where(b => bookIds.Contains(b.Id))
                                        .ToListAsync();

            if (books.Any())
            {
                _dbContext.Books.RemoveRange(books);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteSingleDataAsync(int id, Book book)
        {
            var boo = await _dbContext.Books
                                      .Where(b => b.Id == id)
                                      .FirstOrDefaultAsync();
            if (boo != null)
            {
                _dbContext.Books.Remove(boo);
                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
