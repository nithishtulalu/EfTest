using EFTEST.Data;
using EFTEST.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }
        [HttpPost]
        [Route("Insert Data To Books")]

        public async Task<ActionResult> InsertData([FromBody] Book books)
        {
            await _bookServices.insertData(books);
            return CreatedAtAction(nameof(books), new { id = books.Id }, books);
            

        }

    }
}
