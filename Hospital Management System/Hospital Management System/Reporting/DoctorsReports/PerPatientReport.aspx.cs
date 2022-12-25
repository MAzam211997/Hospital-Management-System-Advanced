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
    public partial class PerPatientReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerPerPatientReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerPatientReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerPatientReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerPatientReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerPerPatientReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerPatientReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerPerPatientReport.LocalReport.DataSources.Clear();
                ReportViewerPerPatientReport.BorderStyle = BorderStyle.Solid;
                ReportViewerPerPatientReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}