using Microsoft.AspNetCore.Mvc;
 
namespace Presentation.Controllers
{
    public class AlunoController : EdenController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 