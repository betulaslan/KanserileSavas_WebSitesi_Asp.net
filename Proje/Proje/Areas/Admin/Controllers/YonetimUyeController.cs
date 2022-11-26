using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class YonetimUyeController : Controller
    {
            YonetimUyeManager  yonetimUyeManager = new YonetimUyeManager(new EfYonetimUyeDal());
            public IActionResult Index()
            {
                var values = yonetimUyeManager.TGetList();
                return View(values);
            }
            [HttpGet]
            public IActionResult AddYonetimUye()
            {
                return View();
            }
           
            [HttpPost]
            public IActionResult AddYonetimUye(YonetimUye yonetimUye)
            {
                yonetimUyeManager.TAdd(yonetimUye);
                return RedirectToAction("Index");
            }
            public IActionResult DeleteYonetimUye(int id)
            {
                var values = yonetimUyeManager.TGetByID(id);
                yonetimUyeManager.TDelete(values);
                return RedirectToAction("Index");
            }
            [HttpGet]
            public IActionResult UpdateYonetimUye(int id)
            {
                var values = yonetimUyeManager.TGetByID(id);
                return View(values);

            }
            [HttpPost]
            public IActionResult UpdateYonetimUye(YonetimUye yonetimUye)
            {
                yonetimUyeManager.TUpdate(yonetimUye);
                return RedirectToAction("Index");

            }
    }
}
