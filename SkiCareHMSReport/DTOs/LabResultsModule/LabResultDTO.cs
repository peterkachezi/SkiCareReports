using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.LabResultsModule
{
    public class LabResultDTO
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public Guid RequestDetailId { get; set; }
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientRegCode { get; set; }
        public Guid VisitId { get; set; }
        public string Results { get; set; }
        public string Note { get; set; }
        public string TestDoneBy { get; set; }
        public string TestDoneByName { get; set; }
        public string UpdatedBy { get; set; }
        public string ResultAttachment { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
