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
    public partial class PerAppointmentReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerPerAppointmentReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerAppointmentReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerAppointmentReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerPerAppointmentReport.LocalReport.DataSources.Clear();
                ReportViewerPerAppointmentReport.BorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}