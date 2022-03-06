using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.LabRequestModule
{
    public class LabRequestDetailsDTO
    {
        public Guid TestId { get; set; }
        public string TestName { get; set; }
        public decimal TestAmount { get; set; }
        public Guid Id { get; set; }
        public Guid VisitId { get; set; }
        public Guid RequestId { get; set; }
        public DateTime CreateDate { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedByName { get; set; }
        public string PatientName { get; set; }
        public byte PaymentMode { get; set; }
        public Guid PatientId { get; set; }
        public byte PaymentStatus { get; set; }
        public byte ResultStatus { get; set; }
    }
}
