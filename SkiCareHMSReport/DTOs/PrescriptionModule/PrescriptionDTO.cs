using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PrescriptionModule
{
    public class PrescriptionDTO
    {

        public Guid Id { get; set; }
        public Guid VisitId { get; set; }
        public Guid PatientId { get; set; }
        public string VisitCode { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public string CaseHistory { get; set; }
        public string Note { get; set; }
        public byte MedicineDispatchStatus { get; set; }
        public int TreatmentForId { get; set; }
        public string TreatmentForName { get; set; }
        public string PatientName { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientIdNumber { get; set; }
        public string PatientRegCode { get; set; }
        public ICollection<PrescriptionDetailDTO> PrescriptionDetailDTO { get; set; }
    }
}
