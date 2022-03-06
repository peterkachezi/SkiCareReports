

using SkiCareHMSReport.DTOs.PatientModule;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiCareHMSReport.Services.PatientModule
{
    public interface IPatientService
    {

        Task<List<PatientDTO>> GetAll();     
        Task<PatientDTO> GetById(Guid Id);
        Task<PatientDTO> GetByIdNumber(string IdNumber);

    }
}