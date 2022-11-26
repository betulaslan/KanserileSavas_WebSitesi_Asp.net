using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnaSayfaController : Controller
    {
        AnasayfaManager anasayfaManager= new AnasayfaManager(new EfAnaSayfaDal());
        public IActionResult Index()
        {
            var values = anasayfaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnaSayfa()
        {
            return View();
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = anasayfaManager.TGetByID(id);
            anasayfaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddAnaSayfa(AnaSayfa anaSayfa)
        {
            anasayfaManager.TAdd(anaSayfa);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnaSayfa(int id)
        {
            var values = anasayfaManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateAnaSayfa(AnaSayfa anasayfa)
        {
            anasayfaManager.TUpdate(anasayfa);
            return RedirectToAction("Index");

        }
    }
}
