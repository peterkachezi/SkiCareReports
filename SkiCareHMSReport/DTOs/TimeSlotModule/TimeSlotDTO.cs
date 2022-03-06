using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiCareHMSReport.DTOs.TimeSlotModule
{
    public class TimeSlotDTO
    {
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TimeSlot => StartTime + " To " + EndTime;
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string DoctorName { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }

     
    }
}
