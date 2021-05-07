using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<IndexProject> indexProject = new List<IndexProject>()
            {
                new IndexProject(1, "زودفود", "درخواست آنلاین غذا در بستر اینترنت", "Zotopya", "project-1.jpg"),
                new IndexProject(2, "بلوباکس", "درخواست آنلاین انتقال مرسولات درون شهری", "Kayas", "project-2.jpg"),
                new IndexProject(3, "مونوپال", "آموزش آنلاین بسته های آموزشی در شبکه های مجازی", "Entropy", "project-3.jpg"),
                new IndexProject(4, "کاپوس", "درخواست آنلاین تهیه مایحتاج روزانه سوپرمارکتی", "SuperLact", "project-4.jpg")
            };

            return View("_Projects", indexProject);
        }
    }
}
