using Microsoft.AspNetCore.Mvc;

namespace Service_Desk_IT.Controllers
{
    [Route("Agente")]
    public class AgenteController : Controller
    {
        [Route("Cases")]
        public IActionResult Agente()
        {
            return View();
        }
    }
}
