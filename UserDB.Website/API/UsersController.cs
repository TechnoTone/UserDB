using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using UserDB.Repository;

namespace UserDB.Website.API
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IStore store;

        public UsersController(IStore store) => this.store = store;

        [HttpPost]
        [Route("save")]
        public SavedUser Save([FromBody] NewUserRequest request)
        {
            return store.AddUser(request.EmailAddress, request.Password);
        }

        [HttpGet]
        [Route("ping")]
        public string Ping()
        {
            return "Pong";
        }
    }

    public class NewUserRequest
    {
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [Required] public string Password { get; set; }
    }
}
