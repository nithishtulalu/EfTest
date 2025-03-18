using EFTEST.Data;

namespace EFTEST.Services.Interfaces
{
    public interface ILanuageServices
    {
        Task<List<Language>> GetAllLanguagesAsync();
        Task<Language> GetCurrencyByIDAsync(int id);

        Task<Language> GetCurrencyByNameAsync(string name);
        Task<Language> GetLangByMultiParaAsync(string Title, string Description);
        Task<List<Language>> GetIDOfData();

    }
}
