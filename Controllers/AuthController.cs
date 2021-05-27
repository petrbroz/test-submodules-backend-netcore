using System;
using System.Threading.Tasks;
using Autodesk.Forge.Samples.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Autodesk.Forge.Samples.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class AuthController : ControllerBase {
        private readonly ILogger<AuthController> _logger;
        private readonly IForgeService _forgeService;

        public AuthController (ILogger<AuthController> logger, IForgeService forgeService) {
            _logger = logger;
            _forgeService = forgeService;
        }

        [HttpGet ("token")]
        public async Task<dynamic> GetAccessToken () {
            var token = await _forgeService.GetAccessToken ();
            return new {
                access_token = token.AccessToken,
                expires_in = Math.Round((token.ExpiresAt - DateTime.UtcNow).TotalSeconds)
            };
        }
    }
}