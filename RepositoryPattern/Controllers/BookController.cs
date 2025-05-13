using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.Interfaces;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork work;

        public BookController ( IUnitOfWork work )
        {
            this.work = work;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll ()
        {
            return Ok(await work.BookRepo.GetAll());
        }
    }
}
