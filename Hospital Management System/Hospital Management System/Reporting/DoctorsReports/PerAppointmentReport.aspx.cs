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
                ReportViewerPerAppointmentReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerPerAppointmentReport.LocalReport.ReportPath = Server.MapPath("~/Reporting/AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from app in entities.Appointments where app.Id.Equals(id)
                                                                                           select app));
                ReportViewerPerAppointmentReport.LocalReport.DataSources.Clear();
                ReportViewerPerAppointmentReport.BorderStyle = BorderStyle.Solid;
                ReportViewerPerAppointmentReport.LocalReport.DataSources.Add(datasource);

            }

        }
    }
}