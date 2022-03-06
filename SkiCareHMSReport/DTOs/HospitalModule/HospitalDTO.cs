using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.DTOs.HospitalModule
{
   public class HospitalDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public string CMLastName { get; set; }
        public string CMFirstName { get; set; }
        public string CMPhoneNumber { get; set; }
        public string OpeningHours { get; set; }
        public string ClosingHours { get; set; }
        public int CountyId { get; set; }

        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
    }
}

               
                    