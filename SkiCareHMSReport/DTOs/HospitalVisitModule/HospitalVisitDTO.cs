using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.DTOs.HospitalVisitModule
{
    public class HospitalVisitDTO
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid HospitalId { get; set; }
        public string HospitalName { get; set; }
        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public DateTime VisitDate { get; set; }
        public string Token { get; set; }
        public string CreatedBy { get; set; }
        public string VisitCode { get; set; }
        public byte PaymentStatus { get; set; }
        public string CreatedByName { get; set; }
        public string Url { get; set; }
        public byte TriageStatus { get; set; }
        public byte DoctorStatus { get; set; }
        public byte LabRequestStatus { get; set; }
        public string LabRequestStatusDescription { get; set; }
        public string PatientFirstName { get; set; }
        public string FullName { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string TransactionNumber { get; set; }
        public bool isActive { get; set; }
        public byte PaymentMode { get; set; }
    }
}
