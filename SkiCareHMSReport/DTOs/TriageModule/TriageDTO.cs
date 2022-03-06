using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.DTOs.TriageModule
{
    public class TriageDTO
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid HospitalVisitId { get; set; }
        public string PatientName { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BMI { get; set; }
        public string Respiration { get; set; }
        public string Pulse { get; set; }
        public string FoodAllergy { get; set; }
        public string DrugAllergy { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Temprature { get; set; }
        public string Systolic { get; set; }
        public string Diastolic { get; set; }
        public string Notes { get; set; }
        public string SP02 { get; set; }
        public string SurgicalHistory { get; set; }
        public string FamilyHistory { get; set; }
        public string TransfusionHistory { get; set; }
        


        //medical history
        public Guid MedicalHistoryId { get; set; }
        public byte Epilepsy { get; set; }
        public byte Hypertension { get; set; }
        public byte Respiratory { get; set; }
        public byte Cardiac { get; set; }
        public byte DiabetesMellitus { get; set; }
        public string OtherMedicalHistory { get; set; }

        //obstretric history
        public Guid ObstretricHistoryId { get; set; }
        public string Para { get; set; }
        public string Gravida { get; set; }
        public string EDD { get; set; }
        public string LMP { get; set; }


        //Social history
        public Guid SocialHistoryId { get; set; }
        public byte Smoking { get; set; }
        public byte Alcohol { get; set; }
        public byte Drug { get; set; }


    }
}
