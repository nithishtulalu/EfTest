using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDBContext _dbContext;
        public BookRepository( AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }

        public async Task insertData(Book books)
        {
            _dbContext.Books.Add(books);
            await _dbContext.SaveChangesAsync();

        }

    }
}
