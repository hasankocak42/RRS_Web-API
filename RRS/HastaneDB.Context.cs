﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HastaneDBEntities : DbContext
    {
        public HastaneDBEntities()
            : base("name=HastaneDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Appointment> tbl_Appointment { get; set; }
        public virtual DbSet<tbl_Date> tbl_Date { get; set; }
        public virtual DbSet<tbl_Department> tbl_Department { get; set; }
        public virtual DbSet<tbl_Departmentss> tbl_Departmentss { get; set; }
        public virtual DbSet<tbl_Doctor> tbl_Doctor { get; set; }
        public virtual DbSet<tbl_Favorite> tbl_Favorite { get; set; }
        public virtual DbSet<tbl_Hospital> tbl_Hospital { get; set; }
        public virtual DbSet<tbl_HospitalManager> tbl_HospitalManager { get; set; }
        public virtual DbSet<tbl_Hour> tbl_Hour { get; set; }
        public virtual DbSet<tbl_Patient> tbl_Patient { get; set; }
    
        public virtual int addFavoriteDoctor(Nullable<int> patientID, Nullable<int> doctorID)
        {
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(int));
    
            var doctorIDParameter = doctorID.HasValue ?
                new ObjectParameter("DoctorID", doctorID) :
                new ObjectParameter("DoctorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addFavoriteDoctor", patientIDParameter, doctorIDParameter);
        }
    
        public virtual ObjectResult<AppointmentAfter_Result> AppointmentAfter(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AppointmentAfter_Result>("AppointmentAfter", idParameter);
        }
    
        public virtual ObjectResult<AppointmentAfterdoctor_Result> AppointmentAfterdoctor(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AppointmentAfterdoctor_Result>("AppointmentAfterdoctor", idParameter);
        }
    
        public virtual ObjectResult<AppointmentBefore_Result> AppointmentBefore(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AppointmentBefore_Result>("AppointmentBefore", idParameter);
        }
    
        public virtual ObjectResult<AppointmentBeforedoctor_Result> AppointmentBeforedoctor(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AppointmentBeforedoctor_Result>("AppointmentBeforedoctor", idParameter);
        }
    
        public virtual ObjectResult<DepartmenList_Result> DepartmenList(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DepartmenList_Result>("DepartmenList", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DoctorSignIn(string tckn, string doctorPassword)
        {
            var tcknParameter = tckn != null ?
                new ObjectParameter("Tckn", tckn) :
                new ObjectParameter("Tckn", typeof(string));
    
            var doctorPasswordParameter = doctorPassword != null ?
                new ObjectParameter("DoctorPassword", doctorPassword) :
                new ObjectParameter("DoctorPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DoctorSignIn", tcknParameter, doctorPasswordParameter);
        }
    
        public virtual int DoctorUpdateInformation(Nullable<int> doctorID, string tckn, string doctorPassword, string doctorName, string doctorSurname, Nullable<int> departmentID)
        {
            var doctorIDParameter = doctorID.HasValue ?
                new ObjectParameter("DoctorID", doctorID) :
                new ObjectParameter("DoctorID", typeof(int));
    
            var tcknParameter = tckn != null ?
                new ObjectParameter("Tckn", tckn) :
                new ObjectParameter("Tckn", typeof(string));
    
            var doctorPasswordParameter = doctorPassword != null ?
                new ObjectParameter("DoctorPassword", doctorPassword) :
                new ObjectParameter("DoctorPassword", typeof(string));
    
            var doctorNameParameter = doctorName != null ?
                new ObjectParameter("DoctorName", doctorName) :
                new ObjectParameter("DoctorName", typeof(string));
    
            var doctorSurnameParameter = doctorSurname != null ?
                new ObjectParameter("DoctorSurname", doctorSurname) :
                new ObjectParameter("DoctorSurname", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoctorUpdateInformation", doctorIDParameter, tcknParameter, doctorPasswordParameter, doctorNameParameter, doctorSurnameParameter, departmentIDParameter);
        }
    
        public virtual int GetAnAppointment(Nullable<int> patientId, Nullable<int> doctorId, Nullable<System.DateTime> appointmentDate, Nullable<System.TimeSpan> appointmentTime)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("PatientId", patientId) :
                new ObjectParameter("PatientId", typeof(int));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("DoctorId", doctorId) :
                new ObjectParameter("DoctorId", typeof(int));
    
            var appointmentDateParameter = appointmentDate.HasValue ?
                new ObjectParameter("AppointmentDate", appointmentDate) :
                new ObjectParameter("AppointmentDate", typeof(System.DateTime));
    
            var appointmentTimeParameter = appointmentTime.HasValue ?
                new ObjectParameter("AppointmentTime", appointmentTime) :
                new ObjectParameter("AppointmentTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetAnAppointment", patientIdParameter, doctorIdParameter, appointmentDateParameter, appointmentTimeParameter);
        }
    
        public virtual ObjectResult<HospitalList_Result> HospitalList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HospitalList_Result>("HospitalList");
        }
    
        public virtual int MaasHesaplaa()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MaasHesaplaa");
        }
    
        public virtual int PaitentUpdateInformation(Nullable<int> patientID, string tckn, string patientPassword, string paitentName, string paitentSurname, string paitentMail)
        {
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(int));
    
            var tcknParameter = tckn != null ?
                new ObjectParameter("Tckn", tckn) :
                new ObjectParameter("Tckn", typeof(string));
    
            var patientPasswordParameter = patientPassword != null ?
                new ObjectParameter("PatientPassword", patientPassword) :
                new ObjectParameter("PatientPassword", typeof(string));
    
            var paitentNameParameter = paitentName != null ?
                new ObjectParameter("PaitentName", paitentName) :
                new ObjectParameter("PaitentName", typeof(string));
    
            var paitentSurnameParameter = paitentSurname != null ?
                new ObjectParameter("PaitentSurname", paitentSurname) :
                new ObjectParameter("PaitentSurname", typeof(string));
    
            var paitentMailParameter = paitentMail != null ?
                new ObjectParameter("PaitentMail", paitentMail) :
                new ObjectParameter("PaitentMail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PaitentUpdateInformation", patientIDParameter, tcknParameter, patientPasswordParameter, paitentNameParameter, paitentSurnameParameter, paitentMailParameter);
        }
    
        public virtual ObjectResult<Nullable<System.TimeSpan>> Randevudate(Nullable<int> doctorid, Nullable<System.DateTime> date)
        {
            var doctoridParameter = doctorid.HasValue ?
                new ObjectParameter("doctorid", doctorid) :
                new ObjectParameter("doctorid", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.TimeSpan>>("Randevudate", doctoridParameter, dateParameter);
        }
    
        public virtual ObjectResult<RandevuDoctor_Result> RandevuDoctor(Nullable<int> hospitalid, Nullable<int> departmenid)
        {
            var hospitalidParameter = hospitalid.HasValue ?
                new ObjectParameter("hospitalid", hospitalid) :
                new ObjectParameter("hospitalid", typeof(int));
    
            var departmenidParameter = departmenid.HasValue ?
                new ObjectParameter("departmenid", departmenid) :
                new ObjectParameter("departmenid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RandevuDoctor_Result>("RandevuDoctor", hospitalidParameter, departmenidParameter);
        }
    
        public virtual int Register(string tckn, string patientPassword, string name, string surname, string mail)
        {
            var tcknParameter = tckn != null ?
                new ObjectParameter("Tckn", tckn) :
                new ObjectParameter("Tckn", typeof(string));
    
            var patientPasswordParameter = patientPassword != null ?
                new ObjectParameter("PatientPassword", patientPassword) :
                new ObjectParameter("PatientPassword", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Register", tcknParameter, patientPasswordParameter, nameParameter, surnameParameter, mailParameter);
        }
    
        public virtual int RemoveAppointment(Nullable<int> appointmentID, Nullable<int> doctorID)
        {
            var appointmentIDParameter = appointmentID.HasValue ?
                new ObjectParameter("AppointmentID", appointmentID) :
                new ObjectParameter("AppointmentID", typeof(int));
    
            var doctorIDParameter = doctorID.HasValue ?
                new ObjectParameter("doctorID", doctorID) :
                new ObjectParameter("doctorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RemoveAppointment", appointmentIDParameter, doctorIDParameter);
        }
    
        public virtual ObjectResult<SearchHospital_Result> SearchHospital(string hospitalName)
        {
            var hospitalNameParameter = hospitalName != null ?
                new ObjectParameter("HospitalName", hospitalName) :
                new ObjectParameter("HospitalName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchHospital_Result>("SearchHospital", hospitalNameParameter);
        }
    
        public virtual int UpdateDepartment(string departmentName, Nullable<int> departmentID)
        {
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDepartment", departmentNameParameter, departmentIDParameter);
        }
    
        public virtual int UpdateDoctor(string tckn, string doctorPassword, string doctorName, string doctorSurname, Nullable<int> doctorID)
        {
            var tcknParameter = tckn != null ?
                new ObjectParameter("Tckn", tckn) :
                new ObjectParameter("Tckn", typeof(string));
    
            var doctorPasswordParameter = doctorPassword != null ?
                new ObjectParameter("DoctorPassword", doctorPassword) :
                new ObjectParameter("DoctorPassword", typeof(string));
    
            var doctorNameParameter = doctorName != null ?
                new ObjectParameter("DoctorName", doctorName) :
                new ObjectParameter("DoctorName", typeof(string));
    
            var doctorSurnameParameter = doctorSurname != null ?
                new ObjectParameter("DoctorSurname", doctorSurname) :
                new ObjectParameter("DoctorSurname", typeof(string));
    
            var doctorIDParameter = doctorID.HasValue ?
                new ObjectParameter("DoctorID", doctorID) :
                new ObjectParameter("DoctorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDoctor", tcknParameter, doctorPasswordParameter, doctorNameParameter, doctorSurnameParameter, doctorIDParameter);
        }
    
        public virtual int UpdateHospital(string hospitalName, Nullable<int> hospitalID)
        {
            var hospitalNameParameter = hospitalName != null ?
                new ObjectParameter("HospitalName", hospitalName) :
                new ObjectParameter("HospitalName", typeof(string));
    
            var hospitalIDParameter = hospitalID.HasValue ?
                new ObjectParameter("HospitalID", hospitalID) :
                new ObjectParameter("HospitalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateHospital", hospitalNameParameter, hospitalIDParameter);
        }
    
        public virtual ObjectResult<favoriList_Result> favoriList(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<favoriList_Result>("favoriList", idParameter);
        }
    
        public virtual ObjectResult<MaasList_Result> MaasList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MaasList_Result>("MaasList");
        }
    }
}
