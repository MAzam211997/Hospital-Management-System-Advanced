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
    public partial class PatientsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerPatientsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPatientsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPatientsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPatientsReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerPatientsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPatientsReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerPatientsReport.LocalReport.DataSources.Clear();
                ReportViewerPatientsReport.BorderStyle = BorderStyle.Solid;
                ReportViewerPatientsReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}