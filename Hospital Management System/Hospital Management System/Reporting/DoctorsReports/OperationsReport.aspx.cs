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
    public partial class OperationsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewerOperationsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerOperationsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerOperationsReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewerOperationsReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewerOperationsReport.ProcessingMode = ProcessingMode.Local;
                ReportViewerOperationsReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                                           select doctor));
                ReportViewerOperationsReport.LocalReport.DataSources.Clear();
                ReportViewerOperationsReport.BorderStyle = BorderStyle.Solid;
                ReportViewerOperationsReport.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}