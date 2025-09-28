using Microsoft.AspNetCore.Mvc;

namespace Service_Desk_IT.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
