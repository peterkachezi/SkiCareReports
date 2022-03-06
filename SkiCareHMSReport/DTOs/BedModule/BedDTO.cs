using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.BedModule
{
    public class BedDTO
    {
        public Guid Id { get; set; }
        public Guid BedCategoryId { get; set; }
        public string BedCategoryName { get; set; }
        public string BedNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public byte Status { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
    }
}
