using Gradera.Education.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace GraderaPublic.Controllers
{
    public class HomeController : Controller
    {
        GraderaPublic.Models.GraderaConnectionString db = new Models.GraderaConnectionString();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kyu5()
        {
            return View();
        }

        public ActionResult Kyu4()
        {
            return View();
        }

        public ActionResult Kyu3()
        {
            return View();
        }

        public ActionResult Kyu2()
        {
            return View();
        }

        public ActionResult Kyu1()
        {
            return View();
        }

        public ActionResult License()
        {
            return View();
        }

        public ActionResult Thanks()
        {
            return View();
        }

        public ActionResult Ordlista()
        {
            var wordlist = from w in db.Wordlist
                           orderby w.jpn
                           select w;
            return View(wordlist);
        }

        public ActionResult Technique()
        {
            var tec = from t in db.TECHNICS
                      orderby t.Type.ID
                      select t;

            return View(tec);
        }

        //[OutputCache(Duration=86400, VaryByParam="id")]
        [ChildActionOnly]
        public PartialViewResult TecCount(int id)
        {
            var count = (from c in db.TECHNICS
                         where c.Type.ID == id
                         select c).Count();
            return PartialView(count);
        }

        public ActionResult Kodord()
        {
            return View();
        }

        #region Send Feedback
        //[OutputCache(Duration = 86400, VaryByParam = "fb")]
        [HttpPost]
        public ActionResult SendFeedback(Models.Feedback fb)
        {
            Regex rx = new Regex(
                @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

            string result = null;

            if (fb.Name == null)
            {
                result += string.Format("<p style='color: #FF0000;'>Du måste fylla i ett namn.</p>");
            }
            if (fb.Email != null)
            {
                if (!rx.IsMatch(fb.Email))
                {
                    result += string.Format("<p style='color: #FF0000;'>Du måste fylla i en giltig e-post adress.</p>");
                }
            }
            else
            {
                result += string.Format("<p style='color: #FF0000;'>Du måste fylla i en e-post adress.</p>");
            }
            if (fb.Text == null)
            {
                result += string.Format("<p style='color: #FF0000;'>Du måste fylla i ett meddelande</p>");
            }

            if (result == null)
            {
                try
                {
                    //Client
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("victor@webbdudes.se", "never4get");
                    client.Port = 25;
                    client.Host = "mail.webbdudes.se";
                    client.EnableSsl = false;

                    //Mail
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.From = new MailAddress("victor@webbdudes.se");
                    mail.To.Add("victor@webbdudes.se");
                    //mail.CC.Add(fb.Email);
                    mail.Subject = "Feedback - " + fb.Subject;
                    mail.Body = string.Format("Från: {0} - {1} <br />{2}", fb.Name, fb.Email, fb.Text.Replace("\n", "<br />"));
                    mail.IsBodyHtml = true;

                    client.Send(mail);

                    result = "ok";
                }
                catch
                {
                    result = string.Format("<p style='color: #FF0000;'>Ett fel uppstod, försök igen senare.</p>");
                }
            }

            return Content(result, "text/html");
        }
        #endregion

        public ActionResult Education(string id)
        {
            EducationBLL _educationBLL = new EducationBLL();

            Gradera.Education.Entities.Education education = _educationBLL.GetEducation(id);

            return View(education);
        }
    }
}