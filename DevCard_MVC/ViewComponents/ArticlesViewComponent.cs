using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var devArticles = new List<IndexArticle>()
            {
                new IndexArticle(1, "سه فریمورک محبوب جاوااسکریپت",
                    "در این بخش به بررسی مباحث محبوب برنامه نویسان پرداخته و مسائل مرتبط با آنها را بررسی مینمائیم ",
                    "blog-post-thumb-card-1.jpg"),
                new IndexArticle(2, "راهکارهای دورکاری",
                    "در این بخش به بررسی مباحث محبوب برنامه نویسان پرداخته و مسائل مرتبط با آنها را بررسی مینمائیم ",
                    "blog-post-thumb-card-2.jpg"),
                new IndexArticle(3, "روشهای برنامه نویس شدن فول استک",
                    "در این بخش به بررسی مباحث محبوب برنامه نویسان پرداخته و مسائل مرتبط با آنها را بررسی مینمائیم ",
                    "blog-post-thumb-card-3.jpg"),
                new IndexArticle(4, "داکر از نزدیک",
                    "در این بخش به بررسی مباحث محبوب برنامه نویسان پرداخته و مسائل مرتبط با آنها را بررسی مینمائیم ",
                    "blog-post-thumb-card-4.jpg")
            };

            return View("_Articles", devArticles);
        }
    }
}