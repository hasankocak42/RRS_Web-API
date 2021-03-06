﻿using System;
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
    public class UpdateController : ApiController
    {
        [Route("Doctor")]
        [HttpPost]
        public HttpResponseMessage Put(tbl_Doctor doctor)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Doctor Doctor = db.tbl_Doctor.FirstOrDefault(x => x.DoctorID == doctor.DoctorID);

                    if (Doctor != null)
                    {
                       
                        
                        Doctor.DoctorName = doctor.DoctorName;
                        Doctor.DoctorSurname = doctor.DoctorSurname;
                        Doctor.DoctorPassword = doctor.DoctorPassword;

                        if ( db.SaveChanges()>0)
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("patient")]
        [HttpPost]
        public HttpResponseMessage Put(tbl_Patient patient)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Patient Patient = db.tbl_Patient.FirstOrDefault(x => x.PatientID == patient.PatientID);

                    if (Patient != null)
                    {
                        Patient.PaitentMail = patient.PaitentMail;
                        Patient.PaitentName = patient.PaitentName;
                        Patient.PaitentSurname = patient.PaitentSurname;
                        
                        Patient.PatientPassword = patient.PatientPassword;
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("manager")]
        [HttpPost]
        public HttpResponseMessage Put(tbl_HospitalManager manager)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_HospitalManager Manager = db.tbl_HospitalManager.FirstOrDefault(x => x.ManagerID == manager.ManagerID);

                    if (Manager != null)
                    {
                        Manager.ManagerName = manager.ManagerName;
                        Manager.ManagerPassword = manager.ManagerPassword;
                        Manager.ManagerSurname = manager.ManagerUserName;
                        
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Route("department")]
        [HttpPost]
        public HttpResponseMessage Put(tbl_Department  department)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Department Deparment = db.tbl_Department.FirstOrDefault(x => x.DepartmentID == department.DepartmentID);

                    if (Deparment != null)
                    {
                        Deparment.DepartmentName = department.DepartmentName;
                        
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [Route("hospital")]
        [HttpPost]
        public HttpResponseMessage Put(tbl_Hospital hospital)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    tbl_Hospital Hospital = db.tbl_Hospital.FirstOrDefault(x => x.HospitalID == hospital.HospitalID);

                    if (Hospital != null)
                    {
                        Hospital.HospitalName = hospital.HospitalName;
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
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Route("Maas")]
        [HttpGet]
        public void GetMaas()
        {
            using (var db = new HastaneDBEntities())
            {
                db.MaasHesaplaa();
            }
        }


    }
    }
