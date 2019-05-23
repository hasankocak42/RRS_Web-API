using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RRS.Controllers


{
    public class LoginController : ApiController
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage GetPatient(tbl_Patient patient)
        {


            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = db.tbl_Patient.FirstOrDefault(x => (x.Tckn == patient.Tckn) || (x.PatientPassword == patient.PatientPassword));
                    if (Patient != null)
                    {

                        return Request.CreateResponse(HttpStatusCode.OK, Patient);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bulunamadı");

                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }


    









    public HttpResponseMessage Get(UyeBilgisi uye)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = new tbl_Patient();
                    tbl_Admin Admin = new tbl_Admin();
                    tbl_HospitalManager Manager = new tbl_HospitalManager();


                    Patient = db.tbl_Patient.FirstOrDefault(x => x.Tckn == uye.TcNo);
                    Admin = db.tbl_Admin.FirstOrDefault(x => x.Tckn == uye.TcNo);
                    Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.Tckn == uye.TcNo);

                    if (Patient != null)
                    {
                        if (Patient.PatientPassword == uye.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Patient);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Yanlış şifre");


                        }
                    }
                    if (Admin != null)
                    {
                        if (Admin.AdminPassword == uye.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Admin);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Yanlış şifre");


                        }
                    }
                    if (Manager != null)
                    {
                        if (Manager.ManagerPassword == uye.Password)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Manager);
                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Yanlış şifre");


                        }
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "TcNo Hatalı");
                    }
                }
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }


}
    public class UyeBilgisi
{
    public string TcNo;

    public string Password;



}

