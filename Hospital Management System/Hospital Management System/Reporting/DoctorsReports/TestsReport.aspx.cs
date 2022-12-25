using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital_Management_System.Models;
using Microsoft.Reporting.WebForms;

namespace Hospital_Management_System.Reporting.DoctorsReports
{
    public partial class TestsReport : System.Web.UI.Page
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
                ReportViewerTestsReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerTestsReport.LocalReport.DataSources.Clear();
                ReportViewerTestsReport.BorderStyle = BorderStyle.Solid;
                ReportViewerTestsReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}