using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital_Management_System.Models;
using Microsoft.Reporting.WebForms;

namespace Hospital_Management_System.Reporting
{
    public partial class AppointmentsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                AppointmentReportViewer.ProcessingMode = ProcessingMode.Local;
                AppointmentReportViewer.InternalBorderStyle = BorderStyle.Solid;
                AppointmentReportViewer.InternalBorderStyle = BorderStyle.Solid;
                AppointmentReportViewer.ToolBarItemBorderStyle = BorderStyle.Solid;
                AppointmentReportViewer.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (entities.Appointments.Include(c => c.Doctor).Include(c => c.Patient)
                .Where(c => c.Status == true).Where(c => c.AppointmentDate >= date).ToList()));
                AppointmentReportViewer.LocalReport.DataSources.Clear();
                AppointmentReportViewer.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}