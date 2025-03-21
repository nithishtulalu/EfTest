using EFTEST.Data;
using EFTEST.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace EFTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookPricesController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        public BookPricesController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }
        [HttpGet]
        [Route("Get ALl  Data")]
        public async Task<ActionResult<List<BookPrice>>> getALlAsync()
        {
            var data = await _bookServices.GetAllAsync();
            return Ok(data);

        }
        //[HttpPost]
        //[Route("Insert Data")]
        //public async Task<ActionResult> InsertData(BookPrice books)
        //{
        //    await _bookServices.insertManyAsync(books);

        //    return Ok(new { message = "Bulk data inserted successfully." });
        //}

        //[HttpDelete]
        //[Route("Delete Data")]
        //public async Task<ActionResult> Deelte(int id ,BookPrice bookPrice)
        //{
        //     await  _bookServices.DeleteSingleDataAsync(id, bookPrice);
        //    return Ok();
        //}
    }
}
