using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.Interfaces;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AuthorController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetBy/{id}")]
        public async Task<IActionResult> GetById ( int id )
        {
            return Ok(await unitOfWork.AuthorRepo.Get(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll ()
        {
            return Ok(await unitOfWork.AuthorRepo.GetAll());
        }

    }
}
