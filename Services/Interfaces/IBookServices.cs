using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface IBookServices
    {
        Task insertDataAsync(Book books);
        Task insertManyAsync(List<Book> books);

        Task DeleteMultipleBooksAsync(List<int> bookIds);

        Task DeleteSingleDataAsync(int id, Book book);


        Task UpdateSingleDataAsync(int id, Book book);
        Task<List<Book>> GetAllAsync();


    }
}
