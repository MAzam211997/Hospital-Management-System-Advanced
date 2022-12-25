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
    public partial class AppointmentReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors
                                                                               select doctor));
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.BorderStyle = BorderStyle.Solid;
                ReportViewer1.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}