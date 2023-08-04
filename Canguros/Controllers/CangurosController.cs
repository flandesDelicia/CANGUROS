using Api.Aplication.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Api.Canguros.Controllers
{
    public class CangurosController : BaseController
    {
        [HttpGet("[action]")]
        public async Task<ActionResult<string>> Encounters([FromQuery] IsItValidQuery query)
        {
            return await Sender!.Send(query);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<string>> IntersectionPoint([FromQuery] IntersectionQuery query)
        {
            return await Sender!.Send(query);
        }
    }
}
