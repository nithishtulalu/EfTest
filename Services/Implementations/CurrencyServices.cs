using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class CurrencyServices: ICurrencyServics
    {
        private readonly ICuerrencyRepository _currencyRepository;
        public CurrencyServices(ICuerrencyRepository cuerrencyRepository)
        {
            _currencyRepository = cuerrencyRepository;
        }
        public async Task<List<CurrencyType>> GetAllCurrenciesAsync()
        {
            return await _currencyRepository.GetAllCurrenciesAsync();
        }

        public async Task<CurrencyType> GetCurrencyByID(int id)
        {
            return  await _currencyRepository.GetCurrencyById(id);
        }
    }
}
