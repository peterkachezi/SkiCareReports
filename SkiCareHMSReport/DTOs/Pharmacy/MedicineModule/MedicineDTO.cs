using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.Pharmacy.MedicineModule
{
    public class MedicineDTO
    {
        public Guid Id { get; set; }
        public string BarCode { get; set; }
        public string MedicineName { get; set; }
        public string Strength { get; set; }
        public string GenericName { get; set; }
        public Guid UnitId { get; set; }
        public string UnitName { get; set; }
        public Guid ShelfId { get; set; }
        public string ShelfName { get; set; }
        public string Note { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid MedicineTypeId { get; set; }
        public string MedicineTypeName { get; set; }
        public Guid ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public decimal ManufacturerPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Vat { get; set; }
        public byte Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string NewCreateDate { get { return CreateDate.ToShortDateString(); } }
        public string ImageName { get; set; }
        public string FullMecineName => MedicineName + " " + Strength;
    }
}
