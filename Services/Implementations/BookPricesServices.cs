using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class BookPricesServices:IBookPriceservices
    {
        private readonly IBookPrices _bookPrices;
        public BookPricesServices(IBookPrices bookPrices)
        {
            _bookPrices = bookPrices;
        }

       public async Task<List<BookPrice>> GetPricesAsync()=>
            await _bookPrices.GetPricesAsync();
        public async Task CreateBookPricesAsync(BookPrice price)=>
            await _bookPrices.CreateBookPricesAsync(price);
        public async Task DeleteBookPricesAsync(int id, BookPrice price)=>
            await _bookPrices.updateBookPricesAsync(id, price);

        public async Task updateBookPricesAsync(int id, BookPrice price) =>
            await _bookPrices.updateBookPricesAsync(id, price);
    }
}
