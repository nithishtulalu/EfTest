using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using Microsoft.EntityFrameworkCore;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class BookPrices: IBookPrices
    {
        private readonly AppDBContext _dbContext;
        public BookPrices(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<BookPrice>> GetPricesAsync()
        {
            var data= await _dbContext.BookPrices.ToListAsync();
            return data;

        }
        public async Task CreateBookPricesAsync(BookPrice price)
        {
            _dbContext.BookPrices.Add(price);
            await _dbContext.SaveChangesAsync();

        }
        public async Task DeleteBookPricesAsync(int id, BookPrice price)
        {
            var book = await _dbContext.BookPrices.Where(i => i.Id == id).FirstOrDefaultAsync();
            if (book != null)
            {
                  _dbContext.BookPrices.Remove(book);
                await _dbContext.SaveChangesAsync();
            }

        }
        public async Task updateBookPricesAsync(int id, BookPrice price)
        {
            var existingData= await _dbContext.BookPrices.Where(i => i.Id == id).FirstOrDefaultAsync();
            if (existingData != null)
            {
                existingData.BookId=price.BookId;
                existingData.CurrencyId=price.CurrencyId;
                existingData.Amount=price.Amount;
                existingData.Book=price.Book;

                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
