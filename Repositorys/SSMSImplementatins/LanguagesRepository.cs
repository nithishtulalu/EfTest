using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using Microsoft.EntityFrameworkCore;

namespace EFTEST.Repositorys.SSMSImplementatins
{
    public class LanguagesRepository : ILanguageRepository
    {
        private readonly AppDBContext _context;

        public LanguagesRepository(AppDBContext context)
        {
            _context = context;
        }


        public async Task<List<Language>> GetAllLaungesAsync()
        {
            var data = await _context.Languages.ToListAsync();
            return data;
        }

        public async Task<Language> GetLangByIDAsync(int id)
        {
            var data = await _context.Languages.FindAsync(id);
            return data;
        }

        public async Task<Language> GetLangByNameAsync(string name)
        {
            var data = await _context.Languages.Where(i => i.Title == name).FirstAsync();
            return data;

        }

        public async Task<Language> GetLangByMultiParaAsync(string Title, string Description)
        {
            var data = await _context.Languages.Where(i => i.Title == Title && i.Description == Description).FirstAsync();
            return data;
        }

        public async Task<List<Language>> GetIDOfData()
        {
            var ids= new List<int> { 1,2,5 };

            var result = await _context.Languages.Where(x => ids.Contains(x.id)).ToListAsync();
            return result;
        }


    }
}
