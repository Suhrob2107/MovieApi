using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly CreateUserRegisterCommandHandler _createUserRegisterCommandHandler;

        public RegisterController(CreateUserRegisterCommandHandler createUserRegisterCommandHandler)
        {
            _createUserRegisterCommandHandler = createUserRegisterCommandHandler;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
        {
            await _createUserRegisterCommandHandler.Handle(command);
            return Ok("Kullanici basariyla eklendi");
        }
    }
}
