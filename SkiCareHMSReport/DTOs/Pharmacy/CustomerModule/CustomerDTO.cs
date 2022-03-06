using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.Pharmacy.CustomerModule
{
    public class CustomerDTO
    {
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CreatedBy { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public string FullName => FirstName + "  " + MiddleName + "  " + LastName;
        public string CreatedByName { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }


    }
}
