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
    public partial class TestReport : System.Web.UI.Page
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
                ReportViewerTestReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerTestReport.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors
                                                                               select doctor));
                ReportViewerTestReport.LocalReport.DataSources.Clear();
                ReportViewerTestReport.BorderStyle = BorderStyle.Solid;
                ReportViewerTestReport.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}