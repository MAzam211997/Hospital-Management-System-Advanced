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
    public partial class OperationReport : System.Web.UI.Page
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
                ReportViewerOperationReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerOperationReport.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors
                                                                               select doctor));
                ReportViewerOperationReport.LocalReport.DataSources.Clear();
                ReportViewerOperationReport.BorderStyle = BorderStyle.Solid;
                ReportViewerOperationReport.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}