using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.DTOs.EmployeeModule
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string DesignationId { get; set; }
        public string DesignationName { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid HospitalId { get; set; }
        public string RegistrationCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + MiddleName + " " + LastName;
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string NHIFNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Specializations { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public int CountyId { get; set; }
        public string countyName { get; set; }
        public string Town { get; set; }
        public string KinFirstName { get; set; }
        public string KinLastName { get; set; }
        public string KinFullName => KinFirstName + " " + KinLastName;
        public string KinPhoneNumber { get; set; }
        public Guid KinId { get; set; }
        public string Relationship { get; set; }
        public string KRAPIN { get; set; }
    }
}
