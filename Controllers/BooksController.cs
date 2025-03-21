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
        [Route("insert-bulk-data")]
        public async Task<ActionResult> InsertManyDataAsync(List<Book> books)
        {
            await _bookServices.insertManyAsync(books);

            return Ok(new { message = "Bulk data inserted successfully." });
        }

        [HttpDelete]
        [Route("Delete Multiple based on id")]
        public async Task<ActionResult> DeleteMultipleBooksAsync(List<int> bookIds)
        {
            await _bookServices.DeleteMultipleBooksAsync(bookIds);
            return Ok(new { message = $"{bookIds}Deleted successfully" });

        }

        [HttpDelete]
        [Route("Delete Single Data")]
        public async Task<ActionResult> DeleteSingleDataAsync(int id, Book book)
        {
            await _bookServices.DeleteSingleDataAsync(id, book);
            return Ok(new { message = $"{id} Deleted successfully " });


        }

        [HttpPut]
        [Route("update Single  Data")]
        public async Task<ActionResult<bool>> UpdateSingleDataAsync(int id, Book book)
        {
            await _bookServices.UpdateSingleDataAsync(id, book);
            return Ok(new { message = $"{id} Updated successfully " });
        }


        [HttpGet]
        [Route("getting all Data")]
        public async Task<ActionResult> GetAll()
        {
             var  execdata= await _bookServices.GetAllAsync();
            return Ok(execdata);
        }









    }
}
