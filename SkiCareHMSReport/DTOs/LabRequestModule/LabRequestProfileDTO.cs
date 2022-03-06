using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.LabRequestModule
{
    public class LabRequestProfileDTO
    {
        public List<LabRequestDetailsDTO>  labRequestDetailsDTO { get; set; }
        public LabRequestDTO  labRequestDTO { get; set; }
    }
}
