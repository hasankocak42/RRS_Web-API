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
        [HttpPost]
        public HttpResponseMessage PostRandevuHasta(Id id)
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
        [HttpPost]
        public HttpResponseMessage Postrandevu(Id id)
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
        [HttpPost]
        public HttpResponseMessage PostDoctor(Id id)
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
        [HttpPost]
        public HttpResponseMessage PostDoctorSonra(Id id)
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

        [Route("CancelledRandevuD")]
        [HttpPost]
        public HttpResponseMessage PostCancelDoctor(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.CanceledAppointmentDoctor(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [Route("CancelledRandevuH")]
        [HttpPost]
        public HttpResponseMessage PostCancelHasta(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.CanceledAppointmentPatient(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [Route("DetailRandevu")]
        [HttpPost]
        public HttpResponseMessage PostDetailRandevu(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.DetailRandevu(id.id).ToList());

                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [Route("DetailCancelledRandevu")]
        [HttpPost]
        public HttpResponseMessage PostDetailCancelledRandevu(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.DetailCanceledRandevu(id.id).ToList());

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
        [HttpPost]
        public HttpResponseMessage Postdoctor(randevu rande)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.RandevuDoctor(rande.HID,rande.DID).ToList());
                }
            }
             catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("UygunSaat")]
        [HttpPost]
        public HttpResponseMessage Postsaat(saat saat)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Randevudate(saat.id,saat.date).ToList());
                }
            }
             catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("RandevuAl")]
        [HttpPost]
        public HttpResponseMessage PostRandevu(rande ran)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.GetAnAppointment(ran.Pid, ran.Did, ran.date, ran.time));
                }
            }
             catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("AdminRandevu")]
        [HttpPost]
        public HttpResponseMessage PostAdminRandevu(rande ran)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.AdminAppointment(ran.Did,ran.date,ran.time));
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }


        }

        [Route("Favoriler")]
        [HttpPost]
        public HttpResponseMessage GetRandevu(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.favoriList(id.id).ToList());
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("Maaslar")]
        [HttpPost]
        public HttpResponseMessage PostMaas(Id id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.MaasList(id.id).ToList());
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("KullaniciBil")]
        [HttpPost]
        public HttpResponseMessage PostKullanıcı(Id id)
        {
            using (var db = new HastaneDBEntities())
            {
                try
                {

                
                tbl_Doctor Doctor = new tbl_Doctor();
                tbl_Admin Admin = new tbl_Admin();
                tbl_HospitalManager Manager = new tbl_HospitalManager();
                tbl_Patient Patient = new tbl_Patient();

                Patient = db.tbl_Patient.FirstOrDefault(x => x.PatientID == id.id);
                Doctor = db.tbl_Doctor.FirstOrDefault(x => x.DoctorID== id.id);
                Admin = db.tbl_Admin.FirstOrDefault(x => x.AdminID == id.id);
                Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == id.id);

                if(Patient!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Patient);
                }
                if (Doctor != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Doctor);
                }
                if (Admin != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Admin);
                }
                if (Manager != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Manager);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Id kullanılmamakta");
                }
                }
                catch (Exception ex)
                {

                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
                }
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
        public class rande
        {
            public int Pid;
            public int Did;
            public DateTime date;
            public TimeSpan time;

        }
    }
}
    