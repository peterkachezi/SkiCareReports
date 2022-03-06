using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.Pharmacy.StockModule
{
    public class StockDTO
    {
        public Guid Id { get; set; }
        public Guid MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string GRNo { get; set; }

        public string MedicineName { get; set; }
        public string GenericName { get; set; }
        public decimal ManufacturerPrice { get; set; }
        public decimal SellingPrice { get; set; }

    }
}
