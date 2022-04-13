using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OOP2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly MessageOptions getMessage;

        public UserController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
            getMessage = new MessageOptions();
            _configuration.GetSection(MessageOptions.Message).Bind(getMessage);
        }

        [HttpGet("hello")]
        public string GetHello([FromQuery(Name = "name")] string userName)
        {
            return _userService.Hello(getMessage.Text, userName);
        }

        [HttpPost("psyhAge")]
        public User PostPsyhAge([FromBody] User user)
        {
            return _userService.PsyhAge(user);
        }
    }

}
