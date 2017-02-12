using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraderaPublic.Models
{
    public class AdvertisementModel
    {
        public int ID { get; set; }
        public string ImgURL { get; set; }
        public string Url { get; set; }
        public string Shop { get; set; }
        public byte Position { get; set; }
    }
}