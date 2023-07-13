using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Microservice.Domain.Entities;
using User.Microservice.Domain.Repositories;

namespace User.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserEntity _userEntity;

        public UserController(IUserEntity userEntity)
        {
            _userEntity = userEntity;
        }

        [HttpGet]
        public IEnumerable<UserEntity> GetAllMessageForUser()
        {
            IEnumerable<UserEntity> messages = _userEntity.GetAllMessageForUser();
            return messages;
        }

        [HttpGet("{id}")]
        public IResult GetMessageForUserById(int id)
        {
            UserEntity message = _userEntity.FindMessageForUserByID(id);
            if (message == null)
            {
                return Results.NotFound(new { message = "Message for Admin not found" });
            }
            return Results.Json(message);
        }
    }
}
