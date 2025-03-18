using EFTEST.Repositorys.Intrfases;
using EFTEST.Services.Interfaces;

namespace EFTEST.Services.Implementations
{
    public class JoinServises:IJoinServise
    {
        private readonly IJoinRepository _joinRepo;

        public JoinServises(IJoinRepository joinrepository)
        {
            _joinRepo = joinrepository;
        }
        public async Task<List<dynamic>> joindata()
        {
            return await _joinRepo.joindata();
        }
    }
}
