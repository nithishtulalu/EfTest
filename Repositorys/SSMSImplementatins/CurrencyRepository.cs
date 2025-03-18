using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class CurrencyRepository:ICuerrencyRepository
    {
        private readonly AppDBContext _context;

        public CurrencyRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<CurrencyType>> GetAllCurrenciesAsync()
        {
            var data = await _context.CurrencyTypes.ToListAsync();
            return data;
        }

        public async Task<CurrencyType> GetCurrencyById(int id)
        {
            var data = await _context.CurrencyTypes.FindAsync(id);
            return data;
        }
    }
}
