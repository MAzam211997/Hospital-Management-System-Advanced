using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital_Management_System.Models;
using Microsoft.Reporting.WebForms;

namespace Hospital_Management_System.Reporting.PatientsReports
{
    public partial class AppointmentReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ReportViewerTestsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerTestsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerTestsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerTestsReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerTestsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerAppointmentReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerAppointmentReport.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors
                                                                               select doctor));
                ReportViewerAppointmentReport.LocalReport.DataSources.Clear();
                ReportViewerAppointmentReport.BorderStyle = BorderStyle.Solid;
                ReportViewerAppointmentReport.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}