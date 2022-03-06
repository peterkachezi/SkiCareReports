using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PatientModule
{
  public  class PatientNextOfKinDTO
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
