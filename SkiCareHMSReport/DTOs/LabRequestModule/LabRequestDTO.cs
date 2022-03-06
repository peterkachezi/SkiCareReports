using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.LabRequestModule
{
    public class LabRequestDTO
    {
        public Guid Id { get; set; }
        public Guid VisitId { get; set; }
        public string Note { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedByName { get; set; }
        public string VisitCode { get; set; }
        public string PatientName { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientIdNumber { get; set; }
        public string PatientRegCode { get; set; }
        public byte PaymentStatus { get; set; }
        public byte LabResultsStatus { get; set; }
        public byte HospitalVisitLabRequestStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<LabRequestDetailsDTO>  RequestDetailsDTOs { get; set; }
    }
}
