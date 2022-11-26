using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    [AllowAnonymous]
    public class AnaSayfaController : Controller
    {
        AnasayfaManager anasayfaManager = new AnasayfaManager(new EfAnaSayfaDal());
        public IActionResult Index()
        {
            var values = anasayfaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Detay(int id)
        {
            ViewBag.i = id;
            var values = anasayfaManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Detay(AnaSayfa p)
        {
            return View();
        }
    }
}
