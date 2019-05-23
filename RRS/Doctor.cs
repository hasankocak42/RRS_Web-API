using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RRS
{
    public class Doctor
    {
        public string Tckn { get; set; }
        public string DoctorPassword { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public int DepartmanID { get; set; }
        public int HospitalID { get; set; }


    }
}