
using SkiCareHMSReport.DTOs.MedicalHistoryModule;
using SkiCareHMSReport.DTOs.ObstetricHistoryModule;
using SkiCareHMSReport.DTOs.SocialHistoryModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiCareHMSReport.DTOs.TriageModule
{
    public class TriageProfileDTO
    {
        public TriageDTO triageDTO { get; set; }
        public MedicalHistoryDTO medicalHistoryDTO { get; set; }
        public ObstetricHistoryDTO obstetricHistoryDTO { get; set; }
        public SocialHistoryDTO socialHistoryDTO { get; set; }
    }
}
