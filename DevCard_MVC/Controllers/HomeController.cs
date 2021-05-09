using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        public readonly List<Service> _services = new List<Service>
        {
            new Service(1, "الماسی"),
            new Service(2, "طلایی"),
            new Service(3, "نقره ای"),
            new Service(4, "برنزی")
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "ایراد در ورود اطلاعات! مجدداً تلاش کنید";
                ViewBag.success = "";
                return View(form);
            }

            ViewBag.error = "";
            ViewBag.success = "اطلاعات با موفقیت به سرور ارسال گردید";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
