using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.EmployeeModule
{
   public class NextOfKinDTO
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
