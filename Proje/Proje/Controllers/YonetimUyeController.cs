using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    [AllowAnonymous]

    public class YonetimUyeController : Controller
    {
        YonetimUyeManager  yonetimUyeManager = new YonetimUyeManager(new EfYonetimUyeDal());

        public IActionResult Index()
        {
            var values = yonetimUyeManager.TGetList();
            return View(values);
        }
    }
}
