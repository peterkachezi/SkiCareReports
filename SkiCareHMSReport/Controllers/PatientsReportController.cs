using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SkiCareHMSReport.DataSet;
using SkiCareHMSReport.EDMX;
using SkiCareHMSReport.Services.PatientModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SkiCareHMSReport.Controllers
{
    public class PatientsReportController : Controller
    {

        private readonly IPatientService patientService;

        public PatientsReportController(IPatientService patientService)
        {
            this.patientService = patientService;
        }
        // GET: PatientsReport
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult>Download()
        {
            try
            {
                ReportDocument rd = new ReportDocument();

                rd.Load(Path.Combine(Server.MapPath("~/Reports"), "PatientsReport.rpt"));

                var list = await patientService.GetAll();

                ReportDataSet dataSet = new ReportDataSet();

                foreach (var item in list)
                {
                    dataSet.Patients.AddPatientsRow(

                                           item.Id,

                                           item.FullName,                                                                              

                                           item.IdNumber,

                                           item.Email,

                                           item.PhoneNumber,

                                           item.Gender,

                                           item.CreateDate,

                                           item.CreatedBy,

                                           item.Town,

                                           item.BloodGroup,

                                           item.CountryId,

                                           item.DateOfBirth ,

                                           item.ImageName,

                                           item.MaritalStatus,

                                           item.MiddleName,

                                           item.Occupation == null ? "" : item.Occupation.ToString(),
                                           item.Plan,

                                           item.RegCode,

                                           item.Title,

                                           item.PaymentMode

                      );

                }

                rd.SetDataSource(dataSet);

                Response.Buffer = false;

                Response.ClearContent();

                Response.ClearHeaders();

                rd.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                rd.PrintOptions.ApplyPageMargins(new PageMargins(5, 5, 5, 5));

                rd.PrintOptions.PaperSize = PaperSize.PaperA5;

                Stream stream = rd.ExportToStream(ExportFormatType.PortableDocFormat);

                stream.Seek(0, SeekOrigin.Begin);

                //return File(stream, "application/pdf", "eConsultation.pdf");
                return File(stream, "application/pdf", "RegistrationReport.pdf");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }



        //public async Task<ActionResult> PatientsRegistrationReport(DateTime? fromDate, DateTime? toDate, string documentType, byte appointmentstatus, int? clinicId)
        //{

        //    try
        //    {
        //        var endDate = ((DateTime)toDate).AddHours(23).AddMinutes(59).AddSeconds(59);

        //        ReportDocument rd = new ReportDocument();

        //        rd.Load(Path.Combine(Server.MapPath("~/Reports"), "PatientsReport.rpt"));

        //        var list = await _appointmentService.GetPatientsRegistrationReportsAsync(fromDate, endDate, appointmentstatus, clinicId);

        //        DataSet1 dataSet1 = new DataSet1();

        //        foreach (var item in list)
        //        {
        //            dataSet1.PatientsRegistrations.AddPatientsRegistrationsRow(
        //                  item.PatientName,
        //                  item.DateOfBirth.ToShortDateString(),
        //                  item.GenderDescription,
        //                  item.EmailAddress,
        //                  item.PhoneNumber,
        //                  item.IdNumber,
        //                  item.CreatedDate.ToShortDateString(),
        //                  item.AppDate.ToShortTimeString(),
        //                  item.AppointmentStatusDescription
        //          );
        //        }
        //        bool isEmpty = !list.Any();

        //        if (isEmpty)
        //        {
        //            TempData["Patient_Error"] = "No data was found between  the selected date period!";
        //            return RedirectToAction("Index", "Reports");
        //        }
        //        else
        //        {

        //            string ClinicName = "";

        //            if (clinicId.HasValue)
        //            {
        //                var clinics = await (_clinicService.GetClinicByIdAsync(clinicId.ToString()));
        //                ClinicName = clinics?.Name;
        //            }
        //            else
        //            {
        //                ClinicName = "All Clinics";
        //            }


        //            rd.SetDataSource(dataSet1);
        //            rd.SetParameterValue("ClinicName", ClinicName);
        //            rd.SetParameterValue("DateFrom", fromDate.Value.ToShortDateString());
        //            rd.SetParameterValue("DateTo", toDate.Value.ToShortDateString());

        //            Response.Buffer = false;
        //            Response.ClearContent();
        //            Response.ClearHeaders();

        //            //rd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
        //            //rd.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(5, 5, 5, 5));
        //            //rd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;

        //            if (documentType == "pdf")

        //            {
        //                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
        //                stream.Seek(0, SeekOrigin.Begin);
        //                return File(stream, "application/pdf", "Patients Registration Report From " + fromDate.Value.ToShortDateString() + " To " + toDate.Value.ToShortDateString() + ".pdf");
        //            }

        //            else
        //            {
        //                Stream stream = rd.ExportToStream(ExportFormatType.ExcelRecord);
        //                stream.Seek(0, SeekOrigin.Begin);
        //                return File(stream, "application/pdf", "Patients Registration  From " + fromDate.Value.ToShortDateString() + " To " + toDate.Value.ToShortDateString() + ".xls");
        //            }

        //        }

        //    }
        //    catch (TypeInitializationException ex)
        //    {
        //        TempData["Patient_Error"] = "File Not Found, kindly contact your administrator!";
        //        return RedirectToAction("Index", "Reports");
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["Patient_Error"] = "An error occured, kindly contact your administrator!";
        //        return RedirectToAction("Index", "Reports");
        //    }

        //}



    }
}