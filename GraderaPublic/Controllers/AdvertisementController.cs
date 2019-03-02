using GraderaPublic.Helpers;
using GraderaPublic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraderaPublic.Controllers
{
    public class AdvertisementController : Controller
    {
        private const byte POSITION_TOP = 1;
        private const byte POSITION_LEFT = 2;

        GraderaConnectionString db = new GraderaConnectionString();

        [ChildActionOnly]
        public PartialViewResult GetAdvertisements(string pos)
        {
            byte position = GetPosition(pos);

            //var advertisement = (from a in db.Advertisement
            //                     where a.Position == position && a.Active
            //                     select new AdvertisementModel
            //                     {
            //                         ID = a.ID,
            //                         ImgURL = a.ImgUrl,
            //                         Url = a.Url,
            //                         Shop = a.Shop,
            //                         Position = (byte)a.Position
            //                     }).ToList();

            //if (advertisement.Count > 0)
            //{
            //    AdvertisementModel advertisementToShow = advertisement.PickRandom<AdvertisementModel>();

            //    AdvertisementShow show = new AdvertisementShow()
            //    {
            //        AdvertisementId = advertisementToShow.ID,
            //        Date = DateTime.Now,
            //        Page = Request.Url.AbsoluteUri
            //    };

            //    db.AdvertisementShow.Add(show);
            //    db.SaveChanges();

            //    return PartialView(advertisementToShow);
            //}

            return null;
        }

        private byte GetPosition(string pos)
        {
            switch (pos.ToLower())
            {
                case "top":
                    return POSITION_TOP;
                case "left":
                    return POSITION_LEFT;
                default:
                    return POSITION_TOP;
            }
        }

        [HttpPost]
        public void Redirect(int id)
        {
            AdvertisementClicks click = new AdvertisementClicks
            {
                AdvertisementID = id,
                Date = DateTime.Now
            };

            db.AdvertisementClicks.Add(click);
            db.SaveChanges();
        }

        [HttpGet]
        public int GetClicks(int? days)
        {
            int clicks = 0;

            if (days != null)
            {
                clicks = (from ac in db.AdvertisementClicks
                          where ac.Date > DateTime.Now.AddDays(-(int)days)
                          select ac.ID).Count();
            }
            else
            {
                clicks = (from ac in db.AdvertisementClicks
                          select ac.ID).Count();
            }

            return clicks;
        }
    }
}