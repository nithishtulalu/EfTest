using EFTEST.Data;

namespace EFTEST.Repositorys.Intrfases
{
    public interface IBookRepository
    {
        Task insertDataAsync(Book books);

        Task insertManyAsync(List<Book> books);

        Task DeleteMultipleBooksAsync(List<int> bookIds);
        Task DeleteSingleDataAsync(int id, Book book);
        Task UpdateSingleDataAsync(int id, Book book);

        Task UpdateMultipleDataAsync(List<int> ids);



    }
}
