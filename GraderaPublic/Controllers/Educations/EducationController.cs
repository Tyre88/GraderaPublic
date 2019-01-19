using Gradera.Education.BLL;
using Gradera.Education.DAL;
using Gradera.Education.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace GraderaPublic.Controllers.Educations
{
    public class EducationController : ApiController
    {
        readonly EducationBLL _educationBLL;
        public EducationController()
        {
            _educationBLL = new EducationBLL();
        }

        [HttpGet]
        public HttpResponseMessage GetEducation(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new ObjectContent<Education>(_educationBLL.GetEducation(id), new JsonMediaTypeFormatter());

            return response;
        }
    }
}
