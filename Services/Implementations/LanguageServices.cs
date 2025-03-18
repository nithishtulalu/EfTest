using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class LanguageServices : ILanuageServices
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageServices(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<List<Language>> GetAllLanguagesAsync()
        {
            return await _languageRepository.GetAllLaungesAsync();
        }
        public async Task<Language> GetCurrencyByIDAsync(int id)
        {
            return await _languageRepository.GetLangByIDAsync(id);
        }
        public async Task<Language> GetCurrencyByNameAsync(string name)
        {
            return await _languageRepository.GetLangByNameAsync(name);
        }

        public async Task<Language> GetLangByMultiParaAsync(string Title, string Description)
        {
            return await _languageRepository.GetLangByMultiParaAsync(Title, Description);
        }

        public async Task<List<Language>> GetIDOfData()
        {
            return  await _languageRepository.GetIDOfData();
        }
    }
}
