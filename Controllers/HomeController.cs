using MVCTask2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTask2.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            IEnumerable<Article> articles = db.Articles;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Articles = articles;
            // возвращаем представление
            return View();
        }
        [HttpGet]
        public ActionResult Questionary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questionary(string username, string usersurname, string useremail, string userpass, string usercountry, string usercity, int userage, bool? usergendermale, bool? usergenderfemale, bool? useraccept)
        {
            string gender;
            if (usergendermale == true)
            {
                gender = "Мужской";
            }
            else if (usergenderfemale == true)
            {
                gender = "Женский";
            }
            else
            {
                gender = "Вы не указали пол";
            }
            if (userage > 145 || userage <= 0)
            {
                string unage = "Вы ввели не реальный возраст";
                ViewBag.Anceta = username + usersurname + useremail + userpass + usercountry + usercity + unage + gender + useraccept;
                return View("Show");
            }
            string age = Convert.ToString(userage);
            string accept = Convert.ToString(useraccept);
            string[] list = new string[] { username, usersurname, useremail, userpass, usercountry, usercity, age, gender, accept };
            ViewBag.Anceta = list;
            return View("Show");
        }
        public ActionResult Show()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Guest()
        {
            DateTime date1 = new DateTime(2020, 2, 02);
            ViewBag.Guest = "Beatiful\n" + date1.ToShortDateString();
            return View();
        }
        [HttpPost]
        public ActionResult Guest(string name, string comm)
        {
            ViewBag.Guest = ViewBag.Guest + "\n" + name + ": " + comm + "\n" + DateTime.Now.ToShortDateString();
            return View();
        }

    }
}