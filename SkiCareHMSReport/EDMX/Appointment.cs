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
    
    public partial class Appointment
    {
        public System.Guid Id { get; set; }
        public System.Guid PatientId { get; set; }
        public System.Guid DoctorId { get; set; }
        public System.Guid HospitalId { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public System.DateTime CancelatonDate { get; set; }
        public byte AppointmentStatus { get; set; }
        public System.Guid TimeSlotId { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public string CanceledBy { get; set; }
        public string Token { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
