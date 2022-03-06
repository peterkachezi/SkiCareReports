using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PatientModule
{
    public class PatientImageDTO
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public string ImageName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
