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
    [RoutePrefix("api/Update")]
    public class RemoveController : ApiController
    {
        [Route("Doctor")]
        [HttpGet]
        public HttpResponseMessage Delete(int DoctorID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == DoctorID) != null)
                    {
                        db.tbl_Doctor.Remove(db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == DoctorID));
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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
        [Route("Patient")]
        [HttpGet]
        public HttpResponseMessage DeletePatient(int PatientID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Patient.FirstOrDefault(x => x.PatientID == PatientID) != null)
                    {
                        db.tbl_Patient.Remove(db.tbl_Patient.FirstOrDefault(x => x.PatientID == PatientID));
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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
        [Route("Manager")]
        [HttpGet]
        public HttpResponseMessage DeleteManager(int ManagerID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == ManagerID) != null)
                    {
                        db.tbl_HospitalManager.Remove(db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == ManagerID));
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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
        [Route("Depatment")]
        [HttpGet]
        public HttpResponseMessage DeleteDepartment(int DepartmentID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Department.FirstOrDefault(x => x.DepartmentID == DepartmentID) != null)
                    {
                        db.tbl_Department.Remove(db.tbl_Department.FirstOrDefault(x => x.DepartmentID == DepartmentID));
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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

        [Route("Hospital")]
        [HttpGet]
        public HttpResponseMessage DeleteHospital(int HospitalID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == HospitalID) != null)
                    {
                        db.tbl_Hospital.Remove(db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == HospitalID));
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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
        [Route("departmentss")]
        [HttpGet]
        public HttpResponseMessage Delete(tbl_Departmentss departments)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Departmentss.FirstOrDefault(x => x.HospitalID == departments.HospitalID || x.DepartmentID == departments.DepartmentID) != null)
                    {
                        db.tbl_Departmentss.Remove(departments);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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
        [Route("favori")]
        [HttpGet]
        public HttpResponseMessage Delete(tbl_Favorite favori)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Favorite.FirstOrDefault(x => x.DoctorID == favori.DoctorID || x.PatientID == favori.PatientID) != null)
                    {
                        db.tbl_Favorite.Remove(favori);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "silindi");
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





    }
    }
