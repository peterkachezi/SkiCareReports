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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Appointments = new HashSet<Appointment>();
            this.HospitalVisits = new HashSet<HospitalVisit>();
            this.InsurancePatients = new HashSet<InsurancePatient>();
            this.MedicalHistories = new HashSet<MedicalHistory>();
            this.ObstetricHistories = new HashSet<ObstetricHistory>();
            this.PatientImages = new HashSet<PatientImage>();
            this.PatientNextOfKins = new HashSet<PatientNextOfKin>();
            this.SocialHistories = new HashSet<SocialHistory>();
        }
    
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string Town { get; set; }
        public string BloodGroup { get; set; }
        public int CountryId { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string ImageName { get; set; }
        public string MaritalStatus { get; set; }
        public string MiddleName { get; set; }
        public string Occupation { get; set; }
        public string Plan { get; set; }
        public string RegCode { get; set; }
        public string Title { get; set; }
        public byte PaymentMode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HospitalVisit> HospitalVisits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePatient> InsurancePatients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObstetricHistory> ObstetricHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientImage> PatientImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientNextOfKin> PatientNextOfKins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SocialHistory> SocialHistories { get; set; }
    }
}
