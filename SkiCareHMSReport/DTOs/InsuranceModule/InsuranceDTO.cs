using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.InsuranceModule
{
   public class InsuranceDTO
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalAddress { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Town { get; set; }
        public string PhysicalAddress { get; set; }
        public string WebsiteURL { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
    }
}
