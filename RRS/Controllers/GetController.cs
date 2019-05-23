using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RRS.Controllers
{
    [RoutePrefix("api/Get")]
    public class GetController : ApiController
    {
        
        [Route("Randevu")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "TEST AA");

        }



    }
}
