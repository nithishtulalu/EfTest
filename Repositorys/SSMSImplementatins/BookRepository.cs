using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;

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

        public async Task  insertManyAsync(List<Book> books)
        {
           await _dbContext.Books.AddRangeAsync(books);
            await _dbContext.SaveChangesAsync();

        }

    }
}
