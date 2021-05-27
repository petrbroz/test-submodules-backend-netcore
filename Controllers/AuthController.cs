using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autodesk.Forge.Samples.Models;

namespace Autodesk.Forge.Samples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IForgeService _forgeService;

        public AuthController(ILogger<AuthController> logger, IForgeService forgeService)
        {
            _logger = logger;
            _forgeService = forgeService;
        }

        [HttpGet("token")]
        public async Task<Token> GetAccessToken()
        {
            var token = await _forgeService.GetAccessToken();
            return token;
        }
    }
}
