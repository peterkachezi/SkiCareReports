
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using SkiCareHMSReport.DTOs.PatientModule;
using SkiCareHMSReport.EDMX;
using System.Data.Entity;

namespace SkiCareHMSReport.Services.PatientModule
{
    public class PatientService : IPatientService
    {
        private SkiCareHMSEntities context;

        public PatientService(SkiCareHMSEntities context)
        {
            this.context = context;
        }


        public async Task<List<PatientDTO>> GetAll()
        {
            try
            {
                var patients = (from p in context.Patients

                                join u in context.AspNetUsers on p.CreatedBy equals u.Id

                                join c in context.Countries on p.CountryId equals c.Id

                                join nok in context.PatientNextOfKins on p.Id equals nok.PatientId

                                select new PatientDTO
                                {
                                    Id = p.Id,

                                    RegCode = p.RegCode,

                                    Title = p.Title,

                                    FirstName = p.FirstName,

                                    MiddleName = p.MiddleName,

                                    LastName = p.LastName,

                                    DateOfBirth = p.DateOfBirth,

                                    Gender = p.Gender,

                                    IdNumber = p.IdNumber,

                                    Plan = p.Plan,

                                    MaritalStatus = p.MaritalStatus,

                                    CountryId = p.CountryId,

                                    Town = p.Town,

                                    Occupation = p.Occupation,

                                    PhoneNumber = p.PhoneNumber,

                                    Email = p.Email,

                                    BloodGroup = p.BloodGroup,

                                    CreateDate = p.CreateDate,

                                    CreatedBy = p.CreatedBy,

                                    ImageName = p.ImageName,

                                    PaymentMode = p.PaymentMode,

                                    CountryName = c.CountryName,

                                    KinFirstName = nok.FirstName,

                                    KinLastName = nok.LastName,

                                    Relationship = nok.Relationship,

                                    KinPhoneNumber = nok.PhoneNumber,

                                    CreatedByName = u.FirstName + " " + u.LastName,

                                }).OrderByDescending(x => x.CreateDate).ToListAsync();

                return await patients;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }

        }

        public async Task<PatientDTO> GetById(Guid Id)
        {
            try
            {
                var patient = (from p in context.Patients

                               join u in context.AspNetUsers on p.CreatedBy equals u.Id

                               join c in context.Countries on p.CountryId equals c.Id

                               join nok in context.PatientNextOfKins on p.Id equals nok.PatientId

                               where p.Id == Id

                               select new PatientDTO
                               {
                                   Id = p.Id,

                                   RegCode = p.RegCode,

                                   Title = p.Title,

                                   FirstName = p.FirstName,

                                   MiddleName = p.MiddleName,

                                   LastName = p.LastName,

                                   DateOfBirth = p.DateOfBirth,

                                   Gender = p.Gender,

                                   IdNumber = p.IdNumber,

                                   Plan = p.Plan,

                                   MaritalStatus = p.MaritalStatus,

                                   CountryId = p.CountryId,

                                   Town = p.Town,

                                   Occupation = p.Occupation,

                                   PhoneNumber = p.PhoneNumber,

                                   Email = p.Email,

                                   BloodGroup = p.BloodGroup,

                                   CreateDate = p.CreateDate,

                                   CreatedBy = p.CreatedBy,

                                   ImageName = p.ImageName,

                                   PaymentMode = p.PaymentMode,

                                   CountryName = c.CountryName,

                                   KinFirstName = nok.FirstName,

                                   KinLastName = nok.LastName,

                                   KinPhoneNumber = nok.PhoneNumber,

                                   Relationship = nok.Relationship,

                                   CreatedByName = u.FirstName + " " + u.LastName,

                               }).FirstOrDefaultAsync();

                return await patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<PatientDTO> GetByIdNumber(string IdNumber)
        {
            try
            {
                var patient = (from p in context.Patients

                               join u in context.AspNetUsers on p.CreatedBy equals u.Id

                               join nok in context.PatientNextOfKins on p.Id equals nok.PatientId

                               join c in context.Countries on p.CountryId equals c.Id

                               where p.IdNumber == IdNumber

                               select new PatientDTO
                               {
                                   Id = p.Id,

                                   RegCode = p.RegCode,

                                   Title = p.Title,

                                   FirstName = p.FirstName,

                                   MiddleName = p.MiddleName,

                                   LastName = p.LastName,

                                   DateOfBirth = p.DateOfBirth,

                                   Gender = p.Gender,

                                   IdNumber = p.IdNumber,

                                   Plan = p.Plan,

                                   MaritalStatus = p.MaritalStatus,

                                   CountryId = p.CountryId,

                                   Town = p.Town,

                                   Occupation = p.Occupation,

                                   PhoneNumber = p.PhoneNumber,

                                   Email = p.Email,

                                   BloodGroup = p.BloodGroup,

                                   CreateDate = p.CreateDate,

                                   CreatedBy = p.CreatedBy,

                                   ImageName = p.ImageName,

                                   PaymentMode = p.PaymentMode,

                                   CountryName = c.CountryName,

                                   KinFirstName = nok.FirstName,

                                   KinLastName = nok.LastName,

                                   KinPhoneNumber = nok.PhoneNumber,

                                   Relationship = nok.Relationship,

                                   CreatedByName = u.FirstName + " " + u.LastName,

                               }).FirstOrDefaultAsync();

                return await patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }



    }
}
