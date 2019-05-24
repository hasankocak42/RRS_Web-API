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
    [RoutePrefix("api/register")]
    public class RegisterController : ApiController
    {
        [Route("hasta")]
        [HttpPost]
        public HttpResponseMessage HastaPost(tbl_Patient patient)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = db.tbl_Patient.FirstOrDefault(x => x.Tckn == patient.Tckn);
                    if (Patient != null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bu Tc kullanılmakta");
                    }
                    else
                    {
                        db.tbl_Patient.Add(patient);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, patient);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("doktor")]
        [HttpPost]
        public HttpResponseMessage DoctorPost(tbl_Doctor doctor)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                    tbl_Doctor Doctor = db.tbl_Doctor.FirstOrDefault(x => x.Tckn == doctor.Tckn);
                    if (Doctor != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu Tc kullanılmakta");
                }
                else
                {
                    db.tbl_Doctor.Add(doctor);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, doctor);
                }
            }
        }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("manager")]
        [HttpPost]
        public HttpResponseMessage Post(tbl_HospitalManager manager)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                tbl_HospitalManager Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.Tckn == manager.Tckn);
                if (Manager != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu Tc kullanılmakta");
                }
                else
                {
                    db.tbl_HospitalManager.Add(manager);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, manager);
                }
            }
}
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("departman")]
        [HttpPost]
        public HttpResponseMessage Post(tbl_Department departman)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                    tbl_Department Departman = db.tbl_Department.FirstOrDefault(x => x.DepartmentName == departman.DepartmentName);
                    if (Departman != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu departman bulunmakta");
                }
                else
                {
                    db.tbl_Department.Add(departman);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, departman);
                }
            }
}
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("hospital")]
        [HttpPost]
        public HttpResponseMessage Post(tbl_Hospital hospital)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                    tbl_Hospital Hospital = db.tbl_Hospital.FirstOrDefault(x => x.HospitalName == hospital.HospitalName);
                    if (db.tbl_Hospital.FirstOrDefault(x => x.HospitalName== hospital.HospitalName) != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu hastane bulunmakta");
                }
                else
                {
                    db.tbl_Hospital.Add(hospital);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, hospital);
                }
            }
}
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("departman")]
        [HttpPost]
        public HttpResponseMessage Post(tbl_Departmentss departmens)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                tbl_Departmentss Departmens = db.tbl_Departmentss.FirstOrDefault(x => x.HospitalID == departmens.HospitalID || x.DepartmentID == departmens.DepartmentID);
                if (Departmens != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu hastanede bu departman bulunmakta bulunmakta");
                }
                else
                {
                    db.tbl_Departmentss.Add(departmens);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, departmens);
                }
            }
}
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("departman")]
        [HttpPost]
        public HttpResponseMessage Post(tbl_Favorite favori)
        {
            try
            {
                using (var db = new HastaneDBEntities())
            {
                    tbl_Favorite Favori = db.tbl_Favorite.FirstOrDefault(x => x.DoctorID == favori.DoctorID || x.PatientID == favori.PatientID);
                if (Favori != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bu hastanede bu departman bulunmakta bulunmakta");
                }
                else
                {
                    db.tbl_Favorite.Add(favori);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, favori);
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
