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

        [Route("RandevuHasta")]
        [HttpGet]
        public tbl_Appointment Get(int ID)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return db.tbl_Appointment.ToList().FirstOrDefault(x => x.PatientID == ID);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        [Route("RandevuDoctor")]
        [HttpGet]
        public tbl_Appointment GetDoctor(int Id)
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return db.tbl_Appointment.ToList().FirstOrDefault(x => x.DoctorID == Id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("Hospital")]
        [HttpGet]
        public IEnumerable<tbl_Hospital> GetHospital()
        {
            try
            {
                using (var db = new HastaneDBEntities())
                {
                    return db.tbl_Hospital.ToList();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("Department")]
        [HttpGet]
        public IEnumerable<tbl_Departmentss> GetDepartment(int ID)
        {
            using (var db = new HastaneDBEntities())
            {
                yield return db.tbl_Departmentss.ToList().FirstOrDefault(x => x.HospitalID == ID);
            }
        }

        [Route("Department")]
        [HttpGet]
        public IEnumerable<tbl_Doctor> Getdoctor(tbl_Doctor doctor)
        {
            using (var db = new HastaneDBEntities())
            {
                yield return db.tbl_Doctor.FirstOrDefault(x => x.HospitalID == doctor.HospitalID || x.DepartmentID == doctor.DepartmentID);
            }

        }
    }
}
    