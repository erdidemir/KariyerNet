using KariyerNet.Application.Features.Commands.Auhentications.SignUpUser;
using KariyerNet.Application.Settings;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace KariyerNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IMediator _mediator;
        private readonly JwtSettings _jwtSettings;
        public AuthController(IMediator mediator,
            IOptionsSnapshot<JwtSettings> jwtSettings
            )
        {
            _mediator = mediator;
            _jwtSettings = jwtSettings.Value;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpUserCommand signUpUserCommand)
        {
            var result = await _mediator.Send(signUpUserCommand);

            if (result != 0)
                return Ok();

            return BadRequest("User not created");
        }
    }
}
