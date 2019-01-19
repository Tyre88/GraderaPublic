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
        readonly EducationDbContext _educationDbContext;

        public EducationController()
        {
            _educationDbContext = new EducationDbContext();
        }

        [HttpGet]
        public HttpResponseMessage GetEducation(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new ObjectContent<Education>(_educationDbContext.Educations.FirstOrDefault(e => e.Id == id), new JsonMediaTypeFormatter());

            return response;
        }
    }
}
