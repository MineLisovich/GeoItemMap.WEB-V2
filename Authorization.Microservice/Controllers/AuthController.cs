using Authorization.Microservice.Domain.Entities;
using Authorization.Microservice.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public AuthController(IUsersRepository usersRepository) { _usersRepository = usersRepository; }

        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            IEnumerable<Users> users = _usersRepository.GetUsersList();
            return users;
        }
        [HttpPost]
        public IResult GetUserLoginPass(string login, string password)
        {
            Users user = _usersRepository.FindByLoginPassword(login, password);
            if (user == null)
            { return Results.NotFound(new { message = "User not found" }); }
            return Results.Json(user);
        }
    }
}
