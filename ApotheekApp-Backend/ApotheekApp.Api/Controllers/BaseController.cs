using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApotheekApp.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected string UserId => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
