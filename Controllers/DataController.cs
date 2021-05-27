using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autodesk.Forge.Samples.Models;

namespace Autodesk.Forge.Samples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;
        private readonly IForgeService _forgeService;

        public DataController(ILogger<DataController> logger, IForgeService forgeService)
        {
            _logger = logger;
            _forgeService = forgeService;
        }

        [HttpGet("objects")]
        public async Task<IEnumerable<Autodesk.Forge.Samples.Models.Object>> GetObjects()
        {
            var objects = await _forgeService.GetObjects();
            return objects;
        }
    }
}
