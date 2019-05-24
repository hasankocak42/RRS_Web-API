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
    [RoutePrefix("api/remove")]
    public class RemoveController : ApiController
    {
        [Route("Doctor")]
        [HttpDelete]
        public HttpResponseMessage Delete(İd id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == id.id) != null)
                    {
                        db.tbl_Doctor.Remove(db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == id.id));
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("Patient")]
        [HttpDelete]
        public HttpResponseMessage DeletePatient(İd id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Patient.FirstOrDefault(x => x.PatientID == id.id) != null)
                    {
                        db.tbl_Patient.Remove(db.tbl_Patient.FirstOrDefault(x => x.PatientID == id.id));
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("Manager")]
        [HttpDelete]
        public HttpResponseMessage DeleteManager(İd id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == id.id) != null)
                    {
                        db.tbl_HospitalManager.Remove(db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == id.id));
                        
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("Department")]
        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(İd id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Department.FirstOrDefault(x => x.DepartmentID == id.id) != null)
                    {
                        db.tbl_Departmentss.Remove(db.tbl_Departmentss.FirstOrDefault(x => x.DepartmentID == id.id));
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("Hospital")]
        [HttpDelete]
        public HttpResponseMessage DeleteHospital(İd id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    if (db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == id.id) != null)
                    {
                        db.tbl_Hospital.Remove(db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == id.id));
                        db.tbl_Departmentss.Remove(db.tbl_Departmentss.FirstOrDefault(x => x.HospitalID == id.id));
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("departmentss")]
        [HttpDelete]
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }


        }
        [Route("favori")]
        [HttpDelete]
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }


        }

        [Route("RandevuSil")]
        [HttpDelete]
        public HttpResponseMessage DeleteRandevu(randevu ran)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, db.RemoveAppointment(ran.id, ran.Did));
                }

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }



        public class İd
        {
            public int id;
        }
        public class randevu
        {
            public int id { get; set; }
            public int Did { get; set; }
        }

    }
    }
