using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.Pharmacy.UnitModule
{
   public  class UnitDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public DateTime CreateDate { get; set; }
    }
}
