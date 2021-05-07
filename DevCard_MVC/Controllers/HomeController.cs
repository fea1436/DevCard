using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private List<IndexProject> indexProjects;
        private List<IndexArticle> indexArticles;

        public IActionResult Index()
        {
            indexProjects = new List<IndexProject>()
            {
                new IndexProject()
                {
                    projectCustomer = "گوگل",
                    projectTitle = " پروژۀ" + "\n" + "گوگل",
                    projectText = "پروژۀ جاری در سال 1983 توسط گروهی از همکاران در راستای " + "\n" +
                    "افزایش کارائی مووسه مشتری از شرکت فیکو درخواست گردیده و یکسال بعد با " + "\n" +
                    "موفقیت به پایان رسید و تحویل گردید.",
                    projectImage = "project-1.jpg"
                },
                new IndexProject()
                {
                    projectCustomer = "دراپ باکس",
                    projectTitle = "پروژۀ " + "\n" + "دراپ باکس",
                    projectText = "پروژۀ جاری در سال 1983 توسط گروهی از همکاران در راستای " + "\n" +
                                  "افزایش کارائی مووسه مشتری از شرکت فیکو درخواست گردیده و یکسال بعد با " + "\n" +
                                  "موفقیت به پایان رسید و تحویل گردید.",
                    projectImage = "project-2.jpg"
                },
                new IndexProject()
                {
                    projectCustomer = "گوگل",
                    projectTitle = "پروژۀ " + "\n" + "گوگل",
                    projectText = "پروژۀ جاری در سال 1983 توسط گروهی از همکاران در راستای " + "\n" +
                                  "افزایش کارائی مووسه مشتری از شرکت فیکو درخواست گردیده و یکسال بعد با " + "\n" +
                                  "موفقیت به پایان رسید و تحویل گردید.",
                    projectImage = "project-3.jpg"
                },
                new IndexProject()
                {
                    projectCustomer = "آبر",
                    projectTitle = "پروژۀ " + "\n" + "آبر",
                    projectText = "پروژۀ جاری در سال 1983 توسط گروهی از همکاران در راستای " + "\n" +
                                  "افزایش کارائی مووسه مشتری از شرکت فیکو درخواست گردیده و یکسال بعد با " + "\n" +
                                  "موفقیت به پایان رسید و تحویل گردید.",
                    projectImage = "project-4.jpg"
                },
            };

            indexArticles = new List<IndexArticle>()
            {
                new IndexArticle()
                {
                    articleTitle = "Top 3 JavaScript" + "\n" + "Frameworks",
                    articleSubject = "در این مقاله به چگونگی ایجاد یک چاچوب کامل" + "\n" +
                                     "در راستای تکمیل پروژه های وب با استفاده از ساختارهای برنامه نویسی" + "\n" +
                                     "خواهیم پرداخت." + "\n",
                    articleImage = "blog-post-thumb-card-1.jpg"
                },
                new IndexArticle()
                {
                    articleTitle = "About Remote " + "\n" + "Working",
                    articleSubject = "در این مقاله به چگونگی ایجاد یک چاچوب کامل" + "\n" +
                                     "در راستای تکمیل پروژه های وب با استفاده از ساختارهای برنامه نویسی" + "\n" +
                                     "خواهیم پرداخت." + "\n",
                    articleImage = "blog-post-thumb-card-2.jpg"
                },
                new IndexArticle()
                {
                    articleTitle = "A Guide to Becoming a " + "\n" + "Full-Stack Developer",
                    articleSubject = "در این مقاله به چگونگی ایجاد یک چاچوب کامل" + "\n" +
                                     "در راستای تکمیل پروژه های وب با استفاده از ساختارهای برنامه نویسی" + "\n" +
                                     "خواهیم پرداخت." + "\n",
                    articleImage = "blog-post-thumb-card-3.jpg"
                },
            };

            return View(indexProjects);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
