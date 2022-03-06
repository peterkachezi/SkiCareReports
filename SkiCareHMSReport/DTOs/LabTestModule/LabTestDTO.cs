using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.LabTestModule
{
   public class LabTestDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public string NewAmount { get { return Amount.ToString(); } }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string Description { get; set; }
    }
}
