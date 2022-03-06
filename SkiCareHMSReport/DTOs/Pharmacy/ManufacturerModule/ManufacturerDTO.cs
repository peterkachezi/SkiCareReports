using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.Pharmacy.ManufacturerModule
{
   public class ManufacturerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Fax { get; set; }
        public string State { get; set; }
        public string Town { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
    }
}
