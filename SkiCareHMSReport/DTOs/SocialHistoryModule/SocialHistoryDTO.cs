using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.SocialHistoryModule
{
   public class SocialHistoryDTO
    {
        public Guid Id { get; set; }
        public byte Smoking { get; set; }
        public byte Alcohol { get; set; }
        public byte Drug { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid PatientId { get; set; }
        public Guid HospitalVisitId { get; set; }

    }
}
