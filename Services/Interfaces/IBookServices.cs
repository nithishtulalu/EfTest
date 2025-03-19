using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface IBookServices
    {
        Task insertDataAsync(Book books);
    }
}
