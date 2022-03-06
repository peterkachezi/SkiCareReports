using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.AppointmentLimitModule
{
    public class AppointmentLimitDTO
    {
        public Guid Id { get; set; }
        public int Limit { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }

        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
    }
}
