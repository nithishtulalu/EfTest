using EFTEST.Data;

namespace EFTEST.Repositorys.Intrfases
{
    public interface IBookRepository
    {
        Task insertDataAsync(Book books);

        Task insertManyAsync(List<Book> books);
    }
}
