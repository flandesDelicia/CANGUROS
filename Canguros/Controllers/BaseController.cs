using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Canguros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        private ISender? _sender;

        protected ISender? Sender => _sender ??= HttpContext.RequestServices.GetService<ISender>()!;
    }
}
