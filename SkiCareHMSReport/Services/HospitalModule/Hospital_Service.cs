
using SkiCareHMSReport.DTOs.HospitalModule;
using SkiCareHMSReport.EDMX;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCareHMSReport.Services.HospitalModule
{
    public class Hospital_Service : IHospitalService
    {
        private SkiCareHMSEntities context;

        public Hospital_Service(SkiCareHMSEntities context)
        {
            this.context = context;
        }

        public async Task<List<HospitalDTO>> GetAll()
        {
            try
            {
                var clinics = (from c in context.Hospitals

                               select new HospitalDTO
                               {
                                   Id = c.Id,

                                   Name = c.Name,

                                   Town = c.Town,

                                   PhoneNumber = c.PhoneNumber,

                                   PhysicalAddress = c.PhysicalAddress,

                                   CMFirstName = c.CMFirstName,

                                   CMLastName = c.CMLastName,

                                   CMPhoneNumber = c.CMPhoneNumber,

                                   OpeningHours = c.OpeningHours,

                                   ClosingHours = c.ClosingHours,

                                   CountyId = c.CountyId,

                                   CreatedBy = c.CreatedBy,

                                   CreateDate = c.CreateDate,

                                   Status = c.Status,

                                   Logo = c.Logo,

                               }).OrderBy(x => x.CreateDate).ToListAsync();

                return await clinics;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<HospitalDTO> GetById()
        {
            try
            {
                var clinics = (from c in context.Hospitals

                               join u in context.AspNetUsers on c.CreatedBy equals u.Id                              

                               select new HospitalDTO
                               {
                                   Id = c.Id,

                                   Name = c.Name,

                                   Town = c.Town,

                                   PhoneNumber = c.PhoneNumber,

                                   PhysicalAddress = c.PhysicalAddress,

                                   CMFirstName = c.CMFirstName,

                                   CMLastName = c.CMLastName,

                                   CMPhoneNumber = c.CMPhoneNumber,

                                   OpeningHours = c.OpeningHours,

                                   ClosingHours = c.ClosingHours,

                                   CountyId = c.CountyId,

                                   CreatedBy = c.CreatedBy,

                                   CreatedByName = u.FirstName + " " + u.LastName,

                                   CreateDate = c.CreateDate,

                                   Status = c.Status,

                                   Logo = c.Logo,

                               }).FirstOrDefaultAsync();

                return await clinics;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

    }
}
