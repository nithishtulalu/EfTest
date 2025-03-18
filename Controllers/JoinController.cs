using EFTEST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EFTEST.Controllers
{
    public class JoinController : ControllerBase
    {
        private readonly IJoinServise _join;
        public JoinController(IJoinServise join)
        {
            _join = join;   
        }
        [HttpGet]
        [Route("ALL DATA")]

        public async Task<ActionResult<List<dynamic>>> getJoinData()
        {
            var data = await _join.joindata();
            return Ok(data);
        }
    }
}
