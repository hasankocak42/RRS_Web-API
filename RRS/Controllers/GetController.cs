using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RRS.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Get")]
    public class GetController : ApiController
    {
        [Route("GRandevu")]
        [HttpGet]
        public HttpResponseMessage GetRandevuHasta(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.AppointmentBefore(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [Route("SRandevu")]
        [HttpGet]
        public HttpResponseMessage Getrandevu(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.AppointmentAfter(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [Route("GDoctorRandevu")]
        [HttpGet]
        public HttpResponseMessage GetDoctor(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK,db.AppointmentBeforedoctor(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("RandevuDoctorG")]
        [HttpGet]
        public HttpResponseMessage GetDoctorSonra(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.AppointmentAfterdoctor(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
       

        [Route("Hospital")]
        [HttpGet]
        public HttpResponseMessage GetHospital()
        {
            try
            {
                var db = new HastaneDBEntities();
                return Request.CreateResponse(HttpStatusCode.OK, db.HospitalList().ToList());
              

                

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        
        [Route("Depart")]
        [HttpPost]
        public HttpResponseMessage PostDepart(Id id)
        {
            try
            {
                var db = new HastaneDBEntities();
                return Request.CreateResponse(HttpStatusCode.OK, db.DepartmenList(id.id).ToList());
            
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Route("DoctorDepartmen")]
        [HttpGet]
        public HttpResponseMessage Getdoctor(randevu rande)
        {
            using (var db = new HastaneDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.RandevuDoctor(rande.HID,rande.DID).ToList());

            }
        }

        [Route("UygunSaat")]
        [HttpGet]
        public HttpResponseMessage Getsaat(saat saat)
        {
            using (var db = new HastaneDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Randevudate(saat.id,saat.date).ToList());

            }
        }


        public class saat
        {
            public int id;
            public DateTime date;
        }


        public class randevu
            {
                public int HID;
                public int DID;
            }
        public class Id
        {
            public int id;
        }
    }
}
    