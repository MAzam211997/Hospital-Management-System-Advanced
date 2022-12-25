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
    public partial class AppointmentsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerAppointmentsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerAppointmentsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerAppointmentsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerAppointmentsReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerAppointmentsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerAppointmentsReport.LocalReport.ReportPath = Server.MapPath("~/Reporting/AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from app in entities.Appointments where app.DoctorId.Equals(id)
                                                                               select app));
                ReportViewerAppointmentsReport.LocalReport.DataSources.Clear();
                ReportViewerAppointmentsReport.BorderStyle = BorderStyle.Solid;
                ReportViewerAppointmentsReport.LocalReport.DataSources.Add(datasource);
            }
        }
    }
}