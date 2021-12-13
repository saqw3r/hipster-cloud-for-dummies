using Microsoft.AspNetCore.Mvc;

namespace Hipster.Api
{
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok(new { 
                Title = "Lord of the Rings",
                Author = "J.R.R. Tolkien",
                Year = "1954",
                ISBN = "1234567890"
            });
        }
    }
}