//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkiCareHMSReport.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bed
    {
        public System.Guid Id { get; set; }
        public System.Guid BedCategoryId { get; set; }
        public string BedNumber { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
    }
}