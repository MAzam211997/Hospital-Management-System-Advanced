using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Reporting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //private ApplicationDbContext db;
        //public DoctorsReport()
        //{
        //    db = new ApplicationDbContext();
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
            var entities = new ApplicationDbContext();
            ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors.Take(10)
                                                                           select doctor));
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }
    }
}