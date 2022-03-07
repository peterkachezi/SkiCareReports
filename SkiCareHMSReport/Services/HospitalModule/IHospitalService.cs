
using SkiCareHMSReport.DTOs.HospitalModule;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiCareHMSReport.Services.HospitalModule
{
    public interface IHospitalService
    {
        Task<HospitalDTO> GetById();
        Task<List<HospitalDTO>> GetAll();
    }
}