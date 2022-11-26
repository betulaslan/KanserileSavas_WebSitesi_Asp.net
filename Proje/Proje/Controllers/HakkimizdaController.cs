using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    [AllowAnonymous]

    public class HakkimizdaController : Controller
    {
        HakkimizdaManager hakkimizdaManager = new HakkimizdaManager(new EfHakkimizdaDal());

        public IActionResult Index()
        {
            var values = hakkimizdaManager.TGetList();
            return View(values);
        }
    }
}
