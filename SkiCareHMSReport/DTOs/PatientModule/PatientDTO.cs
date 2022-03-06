using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PatientModule
{
    public class PatientDTO
    {
        public Guid Id { get; set; }
        public string RegCode { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string IdNumber { get; set; }
        public string Plan { get; set; }
        public string MaritalStatus { get; set; }
        public int CountryId { get; set; }
        public string Town { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string KinFirstName { get; set; }
        public string KinLastName { get; set; }
        public string KinPhoneNumber { get; set; }
        public string Relationship { get; set; }
        public string BloodGroup { get; set; }
        public string FullName => FirstName + " " + LastName;
        public DateTime CreateDate { get; set; }     
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public string NewDateOfBirth { get { return DateOfBirth.ToString("yyyy-MM-dd"); } }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string CountryName { get; set; }
        public string ImageName { get; set; }
        public string RawImageName { get; set; }
        public byte PaymentMode { get; set; }
        public Guid InsuranceCompanyId { get; set; }
        public int Age
        {
            get
            {
                int age = 0;

                age = DateTime.Now.Subtract(DateOfBirth).Days;

                age = (age / 365) ;

                return age;

            }
        }


    }
}
