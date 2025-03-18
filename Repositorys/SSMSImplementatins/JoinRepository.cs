using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using Microsoft.EntityFrameworkCore;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class JoinRepository : IJoinRepository
    {
        private readonly AppDBContext _appDBContext;
        public JoinRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;

        }

        public async Task<List<dynamic>> joindata()
        {
            var Lang = await _appDBContext.Languages.ToListAsync();
            var currency= await _appDBContext.CurrencyTypes.ToListAsync();

            var result_data = (from c in currency
                         join l in Lang on c.id equals l.id
                         select new
                         {
                             CurrencyId = c.id,
                             CurrencyName = c.Currency,
                             LanguageId = l.id,
                             LanguageTitle = l.Title,
                             DESC = c.Description +","+ l.Description

                         }).ToList();

            return result_data.Cast<dynamic>().ToList();

        }

       
    }
}
