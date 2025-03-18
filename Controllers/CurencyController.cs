using EFTEST.Data;
using EFTEST.Services.Implementations;
using EFTEST.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurencyController : ControllerBase
    {
        private readonly ICurrencyServics _currencyServics;

        public CurencyController(ICurrencyServics currencyServics)
        {
            _currencyServics = currencyServics;
        }

        [HttpGet]
        [Route("ALL CUREENCY")]
        public async Task<ActionResult<List<CurrencyType>>> GetCurrencies()
        {
            var currencies = await _currencyServics.GetAllCurrenciesAsync();
            return Ok(currencies);
        }

        [HttpGet]
        [Route("Get Data By ID")]
        public async Task<ActionResult<Language>> GetByID(int id)
        {
            var currenct_id = await _currencyServics.GetCurrencyByID(id);
            return Ok(currenct_id);

        }


    }
}
