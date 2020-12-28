using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebbBibliotek.Data;
using WebbBibliotek.Models;
using WebbBibliotek.NewUser;

namespace WebbBibliotek.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepo = authRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
