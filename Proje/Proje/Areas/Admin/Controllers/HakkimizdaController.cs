using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HakkimizdaController : Controller
    {
        HakkimizdaManager hakkimizdaManager = new HakkimizdaManager(new EfHakkimizdaDal());

        public IActionResult Index()
        {
            var values = hakkimizdaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateHakkimizda(int id)
        {
            var values = hakkimizdaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateHakkimizda(Hakkimizda hakkimizda)
        {
            hakkimizdaManager.TUpdate(hakkimizda);
            return RedirectToAction("Index");

        }
    }
}
