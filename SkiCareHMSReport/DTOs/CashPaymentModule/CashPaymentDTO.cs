using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.CashPaymentModule
{
  public  class CashPaymentDTO
    {

        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
    }
}
