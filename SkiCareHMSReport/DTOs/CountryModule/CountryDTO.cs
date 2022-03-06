using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.CountryModule
{
   public class CountryDTO
    {
        public int Id { get; set; }
        public int PhoneCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
