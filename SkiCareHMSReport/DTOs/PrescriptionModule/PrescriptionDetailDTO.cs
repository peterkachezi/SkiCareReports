using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PrescriptionModule
{
   public class PrescriptionDetailDTO
    {
        public Guid Id { get; set; }
        public Guid MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineStrength { get; set; }
        public Guid PatientId { get; set; }
        public string VisitCode { get; set; }
        public string CaseHistory { get; set; }
        public string Medication { get; set; }
        public string Frequency { get; set; }
        public string WhenToTake { get; set; }
        public string TimePeriod { get; set; }
        public byte MedicineDispatchStatus { get; set; }
  
        public DateTime CreateDate { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }     
        public Guid PrescriptionId { get; set; }
     
    }
}
