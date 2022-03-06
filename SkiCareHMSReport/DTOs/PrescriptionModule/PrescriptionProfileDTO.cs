using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.PrescriptionModule
{
    public class PrescriptionProfileDTO
    {
        public PrescriptionDTO prescriptionDTO { get; set; }
        public List<PrescriptionDetailDTO> prescriptionDetailDTO { get; set; }
    }
}
