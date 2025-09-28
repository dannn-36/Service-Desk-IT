using Microsoft.AspNetCore.Mvc;

namespace Service_Desk_IT.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller
    {
        [Route("Tickets")]
        public IActionResult Cliente()
        {
            return View();
        }
    }
}
