using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface ICurrencyServics
    {
        Task<List<CurrencyType>> GetAllCurrenciesAsync();
        Task<CurrencyType> GetCurrencyByID(int id);
    }
}
