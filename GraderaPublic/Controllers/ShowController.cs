using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace GraderaPublic.Controllers
{
    public class ShowController : Controller
    {
        GraderaPublic.Models.GraderaConnectionString db = new Models.GraderaConnectionString();

        public ActionResult Tec(string id)
        {
            try
            {
                var tec = (from t in db.TECHNICS
                           where t.name == id
                           select t).Single();
                return View(tec);
            }
            catch
            {
                var tec = string.Empty;
                return View("Error");
            }

        }

        //[OutputCache(Duration = 86400, VaryByParam = "id")]
        [ChildActionOnly]
        public PartialViewResult Movie(int id)
        {
            try
            {
                var movie = from m in db.Movie
                            join t in db.TECHNICS on m.tec_id equals t.id
                            where t.id == id
                            select m;
                return PartialView(movie);
            }
            catch
            {
                return PartialView();
            }
        }

        //[OutputCache(Duration = 86400, VaryByParam = "tec")]
        [HttpPost]
        public PartialViewResult TecImage(string tec)
        {
            var img = (from i in db.Image
                       join t in db.TECHNICS on i.tec_id equals t.id
                       where t.name == tec
                       orderby i.id descending
                       select i).First();
            return PartialView(img);
        }

        //[OutputCache(Duration = 86400, VaryByParam = "id")]
        [ChildActionOnly]
        public PartialViewResult Picture(int id)
        {
            var img = from i in db.Image
                      join t in db.TECHNICS on i.tec_id equals t.id
                      where t.id == id
                      select i;
            return PartialView(img);
        }

        public PartialViewResult Tecniques(string belt, string name)
        {
            try
            {
                var tecs = from t in db.TECHNICS
                           where t.belt == belt && t.name != name
                           orderby t.Type.ID
                           orderby t.Type.ID == 9 ? 0 : 1
                           select t;

                return PartialView(tecs);
            }
            catch
            {
                return PartialView();
            }
        }

        #region Sök
        //[OutputCache(Duration = 86400, VaryByParam = "query")]
        [HttpPost]
        public ActionResult Search(string query)
        {
            string content = null;
            try
            {
                var wordlist = from w in db.Wordlist
                               where (w.jpn.Contains(query) || w.swe.Contains(query))
                               orderby (w.jpn == query || w.swe == query) ? 0 : 1
                               select w;

                var tec = from t in db.TECHNICS
                          where (t.name.Contains(query) || t.Type.Name.Contains(query))
                          orderby (t.name == query || t.Type.Name == query) ? 0 : 1
                          select t;


                content += string.Format("<p style='text-decoration: underline;'>{0} resultat i ordlistan.</p>", wordlist.Count());

                foreach (var item in wordlist.Take(5))
                {
                    content += (string.Format("<p>{0} <-> {1}</p>", Regex.Replace(item.jpn, query, string.Format("<b>{0}</b>", query), RegexOptions.IgnoreCase), Regex.Replace(item.swe, query, string.Format("<b>{0}</b>", query), RegexOptions.IgnoreCase)));
                }

                if (wordlist.Count() > 5)
                {
                    content += string.Format("<div id='wordMore' style='display: none;'>");
                    foreach (var item in wordlist.Skip(5))
                    {
                        content += (string.Format("<p>{0} <-> {1}</p>", Regex.Replace(item.jpn, query, string.Format("<b>{0}</b>", query), RegexOptions.IgnoreCase), Regex.Replace(item.swe, query, string.Format("<b>{0}</b>", query), RegexOptions.IgnoreCase)));
                    }
                    content += string.Format("</div>");
                    content += string.Format("<p style='text-align: right;' id='wordShowMore'><a href='javascript:showWord()' class='show'>Visa fler..</a></p>");
                }

                content += string.Format("<br /><p style='text-decoration: underline;'>{0} resultat bland tekniker.</p>", tec.Count());

                foreach (var item in tec.Take(5))
                {
                    content += (string.Format("<p><a href='../../show/tec/{0}'>{0} - ({1})</a></p>", Regex.Replace(item.name, query, string.Format("{0}", query), RegexOptions.IgnoreCase), Regex.Replace(item.Type.Name, query, string.Format("{0}", query), RegexOptions.IgnoreCase)));
                }

                if (tec.Count() > 5)
                {
                    content += string.Format("<div id='tecMore' style='display: none;'>");
                    foreach (var item in tec.Skip(5))
                    {
                        content += (string.Format("<p><a href='../../show/tec/{0}'>{0} - ({1})</a></p>", Regex.Replace(item.name, query, string.Format("{0}", query), RegexOptions.IgnoreCase), Regex.Replace(item.Type.Name, query, string.Format("{0}", query), RegexOptions.IgnoreCase)));
                    }
                    content += string.Format("</div>");
                    content += string.Format("<p style='text-align: right;' id='tecShowMore'><a href='javascript:showTec()' class='show'>Visa fler..</a></p>");
                }

                Models.Search qq = new Models.Search
                {
                    query = query,
                    hitsTec = tec.Count(),
                    hitsWord = wordlist.Count(),
                    date = DateTime.Now.ToShortDateString(),
                    ip = HttpContext.Request.UserHostAddress
                };

                db.Search.Add(qq);
                db.SaveChanges();
            }
            catch
            {
                content = string.Format("<p>Sökningen gav inget resultat.</p>");
            }

            return Content(content, "text/html");
        }

        #endregion

        //[OutputCache(Duration = 86400, VaryByParam = "none")]
        public PartialViewResult SearchDialog()
        {
            var tecniques = from t in db.TECHNICS
                            select t.name;

            List<string> returningValues = new List<string>();

            foreach (var item in tecniques)
            {
                returningValues.Add(item);
            }

            return PartialView(returningValues);
        }
    }
}