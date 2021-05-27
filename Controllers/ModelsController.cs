using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autodesk.Forge.Samples.Models;

namespace Autodesk.Forge.Samples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelsController : ControllerBase
    {
        private readonly ILogger<ModelsController> _logger;
        private readonly IForgeService _forgeService;

        public ModelsController(ILogger<ModelsController> logger, IForgeService forgeService)
        {
            _logger = logger;
            _forgeService = forgeService;
        }

        [HttpGet()]
        public async Task<IEnumerable<Autodesk.Forge.Samples.Models.Object>> GetModels()
        {
            var objects = await _forgeService.GetObjects();
            return objects;
        }
    }
}
