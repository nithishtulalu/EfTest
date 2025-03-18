using EFTEST.Data;

namespace EFTEST.Repositorys.Intrfases
{
    public interface ILanguageRepository
    {

        Task<List<Language>> GetAllLaungesAsync();
        Task<Language> GetLangByIDAsync(int id);
        Task<Language> GetLangByNameAsync(string name);

        Task<Language> GetLangByMultiParaAsync(string Title, string Description);

        Task<List<Language>> GetIDOfData();

    }
}
