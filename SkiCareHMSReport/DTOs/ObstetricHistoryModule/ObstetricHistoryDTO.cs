using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.ObstetricHistoryModule
{
   public class ObstetricHistoryDTO
    {
        public Guid Id { get; set; }
        public string Para { get; set; }
        public string Gravida { get; set; }
        public string EDD { get; set; }
        public string LMP { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }    
        public Guid PatientId { get; set; }
    }
}
