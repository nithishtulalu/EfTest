using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface IBookPriceservices
    {
        Task<List<BookPrice>> GetPricesAsync();
        Task CreateBookPricesAsync(BookPrice price);
        Task DeleteBookPricesAsync(int id, BookPrice price);
        Task updateBookPricesAsync(int id, BookPrice price);
    }
}

