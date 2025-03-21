using EFTEST.Data;

namespace EFTEST.Repositorys.Intrfases
{
    public interface IBookPrices
    {
        Task <List<BookPrice>> GetPricesAsync();
        Task CreateBookPricesAsync(BookPrice price);
        Task DeleteBookPricesAsync (int id,BookPrice price);
        Task updateBookPricesAsync (int id,BookPrice price);
    }
}
