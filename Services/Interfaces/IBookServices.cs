using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface IBookServices
    {
        Task insertData(Book books);
    }
}
