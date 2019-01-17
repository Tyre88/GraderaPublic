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
        [HttpGet]
        public HttpResponseMessage GetEducation(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new ObjectContent<string>(id, new JsonMediaTypeFormatter());

            return response;
        }
    }
}
