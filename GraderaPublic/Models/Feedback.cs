using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraderaPublic.Models
{
    public class Feedback
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}