using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.DTOs.AppointmentModule
{
  public  class AppointmentDTO
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Guid TimeSlotId { get; set; }
        public string TimeSlotName => Convert.ToDateTime(StartTime).ToString("hh:mm tt") + " " + Convert.ToDateTime(EndTime).ToString("hh:mm tt");
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public byte AppointmentStatus { get; set; }
        public string CreatedBy { get; set; }
        public string CanceledBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CancelatonDate { get; set; }
        public string Remarks { get; set; }
        public string NewBookingDate { get { return AppointmentDate.ToShortDateString(); } }
        public string CreatedByName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorDepartment { get; set; }
        public string PatientName { get; set; }
        public string PatientNHIF { get; set; }
        public string PatientIdNumber { get; set; }
        public string PatientGender { get; set; }
        public string PhoneNumber { get; set; }
        public Guid HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Token { get; set; }
    }
}
