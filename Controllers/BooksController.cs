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
        [Route("InsertDataToBooks")]
        public async Task<ActionResult> InsertData([FromBody] Book books)
        {
            await _bookServices.insertDataAsync(books);
            return CreatedAtAction(nameof(InsertData), new { id = books.Id }, books);
        }
        [HttpPost]
        [Route("insert-bulk-data")] // Fixed route name
        public async Task<ActionResult> InsertManyDataAsync(List<Book> books)
        {
            await _bookServices.insertManyAsync(books);

            return Ok(new { message = "Bulk data inserted successfully." }); // No need for CreatedAtAction
        }






    }
}
