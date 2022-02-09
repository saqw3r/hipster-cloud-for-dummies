using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hipster.Api
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DataBaseContext _db;

        public BooksController(DataBaseContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        [ProducesResponseType(typeof(Book[]), 200)]
        public async Task<IActionResult> Get()
        {
            var books = await _db.Books.ToArrayAsync();
            return Ok(books);
        }
    }
}