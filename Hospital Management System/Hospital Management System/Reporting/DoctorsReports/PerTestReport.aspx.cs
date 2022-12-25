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
    public partial class PerTestReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerPerTestReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerTestReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerTestReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerTestReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerPerTestReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerTestReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerPerTestReport.LocalReport.DataSources.Clear();
                ReportViewerPerTestReport.BorderStyle = BorderStyle.Solid;
                ReportViewerPerTestReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}