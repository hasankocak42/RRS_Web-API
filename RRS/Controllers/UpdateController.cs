using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RRS.Controllers
{
    public class UpdateController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Put(tbl_Doctor doctor)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Doctor Doctor = db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == doctor.DoctorID);

                    if (Doctor != null)
                    {
                        Doctor = doctor;
                        if( db.SaveChanges()>0)
                        {
                        return Request.CreateResponse(HttpStatusCode.OK, "Güncellendi");

                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Güncelleme yapi1lamadi");
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
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        public HttpResponseMessage Put(tbl_Patient patient)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = db.tbl_Patient.FirstOrDefault(x => x.PatientID == patient.PatientID);

                    if (Patient != null)
                    {
                        Patient = patient;
                        if (db.SaveChanges() > 0)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, "Güncellendi");

                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Güncelleme yapi1lamadi");
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
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        public HttpResponseMessage Put(tbl_HospitalManager manager)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_HospitalManager Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == manager.ManagerID);

                    if (Manager != null)
                    {
                        Manager = manager;
                        if (db.SaveChanges() > 0)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, "Güncellendi");

                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Güncelleme yapi1lamadi");
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
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }



        public HttpResponseMessage Put(tbl_Department  department)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Department Manager = db.tbl_Department.FirstOrDefault(x => x.DepartmentID == department.DepartmentID);

                    if (Manager != null)
                    {
                        Manager = department;
                        if (db.SaveChanges() > 0)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, "Güncellendi");

                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Güncelleme yapi1lamadi");
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
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        public HttpResponseMessage Put(tbl_Hospital hospital)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Hospital Hospital = db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == hospital.HospitalID);

                    if (Hospital != null)
                    {
                        Hospital = hospital;
                        if (db.SaveChanges() > 0)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, "Güncellendi");

                        }
                        else
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Güncelleme yapi1lamadi");
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
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }



    }
    }
