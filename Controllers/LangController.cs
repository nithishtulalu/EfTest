using EFTEST.Data;
using EFTEST.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LangController : ControllerBase
    {
        private readonly ILanuageServices _languageServices;
        public LangController(ILanuageServices lanuageServices)
        {
            _languageServices = lanuageServices;

        }

        [HttpGet]
        [Route("ALL Languages")]

        public async Task<ActionResult<List<Language>>> GetALl()
        {
            var data = await _languageServices.GetAllLanguagesAsync();
            return data;
        }

        [HttpGet]
        [Route("get by id")]
        public async Task<ActionResult<Language>> GetById(int id)
        {
            var data = await _languageServices.GetCurrencyByIDAsync(id);
            return data;
        }

        [HttpGet]
        [Route("BY NAME")]
        public async Task<ActionResult<Language>> GetByName(string name)
        {
            var data = await _languageServices.GetCurrencyByNameAsync(name);
            return data;

        }

        [HttpGet]
        [Route("Get Data By  Using Multiple")]
        public async Task<ActionResult<Language>> GetDataByMultiple(string Title, string Des)
        {
            var data = await _languageServices.GetLangByMultiParaAsync(Title, Des);
            return Ok(data);
        }

        [HttpGet]
        [Route("ListOfIds")]

        public async Task<ActionResult<List<Language>>> GetDatamulti()
        {
            var data = await _languageServices.GetIDOfData();
            return Ok(data);
        }

    }
}
