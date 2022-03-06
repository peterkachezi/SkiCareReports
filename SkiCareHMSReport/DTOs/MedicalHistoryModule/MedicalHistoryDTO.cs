using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.MedicalHistoryModule
{
    public class MedicalHistoryDTO
    {
        public Guid Id { get; set; }
        public byte Epilepsy { get; set; }
        public byte Hypertension { get; set; }
        public byte Respiratory { get; set; }
        public byte Cardiac { get; set; }
        public byte DiabetesMellitus { get; set; }
        public string OtherMedicalHistory { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid PatientId { get; set; }
    }
}
