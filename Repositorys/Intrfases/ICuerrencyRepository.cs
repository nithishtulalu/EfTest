using EFTEST.Data;

namespace EFTEST.Repositorys.Intrfases
{
    public interface ICuerrencyRepository
    {
        Task<List<CurrencyType>> GetAllCurrenciesAsync();
        Task <CurrencyType>GetCurrencyById(int id);
    }
}
