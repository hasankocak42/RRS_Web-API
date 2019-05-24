using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RRS.Controllers


{
        [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("patient")]
        [HttpPost]
        public HttpResponseMessage PostPatient(UyeBilgisi uye)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = db.tbl_Patient.FirstOrDefault(x => x.Tckn == uye.TcNo);
                    if (Patient != null)
                    {

                        if (Patient.PatientPassword == uye.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Patient);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Yanlış şifre");


                        }
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bulunamadı");

                    }
                }
                }
            
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }











        [Route("managerial")]
        [HttpPost]
        public HttpResponseMessage Postmanagerial(UyeBilgisi uyee)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Doctor Doctor = new tbl_Doctor();
                    tbl_Admin Admin = new tbl_Admin();
                    tbl_HospitalManager Manager = new tbl_HospitalManager();


                    Doctor = db.tbl_Doctor.FirstOrDefault(x => x.Tckn == uyee.TcNo);
                    Admin = db.tbl_Admin.FirstOrDefault(x => x.Tckn == uyee.TcNo);
                    Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.Tckn == uyee.TcNo);

                    if (Doctor != null)
                    {
                        if (Doctor.DoctorPassword == uyee.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Doctor);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Yanlış şifre");


                        }
                    }
                    if (Admin != null)
                    {
                        if (Admin.AdminPassword == uyee.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Admin);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Yanlış şifre");


                        }
                    }
                    if (Manager != null)
                    {
                        if (Manager.ManagerPassword == uyee.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Manager);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Yanlış şifre");


                        }
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "TcNo Hatalı");
                    }
                }
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }


}
    public class UyeBilgisi
{
    public string TcNo;

    public string Password;



}

