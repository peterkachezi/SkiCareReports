//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkiCareHMSReport.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrescriptionDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid MedicineId { get; set; }
        public System.Guid PatientId { get; set; }
        public string VisitCode { get; set; }
        public string Frequency { get; set; }
        public string WhenToTake { get; set; }
        public string TimePeriod { get; set; }
        public System.DateTime CreateDate { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public System.Guid PrescriptionId { get; set; }
        public byte MedicineDispatchStatus { get; set; }
    
        public virtual Prescription Prescription { get; set; }
    }
}
