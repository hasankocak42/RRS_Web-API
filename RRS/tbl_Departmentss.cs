//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Departmentss
    {
        public int DepartmentssID { get; set; }
        public int DepartmentID { get; set; }
        public int HospitalID { get; set; }
    
        public virtual tbl_Department tbl_Department { get; set; }
        public virtual tbl_Hospital tbl_Hospital { get; set; }
    }
}