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
                ScriptManagerAppointmentsReport.ProcessingMode = ProcessingMode.Local;
                ScriptManagerAppointmentsReport.InternalBorderStyle = BorderStyle.Solid;
                ScriptManagerAppointmentsReport.InternalBorderStyle = BorderStyle.Solid;
                ScriptManagerAppointmentsReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ScriptManagerAppointmentsReport.ProcessingMode = ProcessingMode.Local;
                ScriptManagerAppointmentsReport.LocalReport.ReportPath = Server.MapPath("AppointmentsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("AppointmentsDataSet", (from doctor in entities.Doctors
                                                                               select doctor));
                ScriptManagerAppointmentsReport.LocalReport.DataSources.Clear();
                ScriptManagerAppointmentsReport.BorderStyle = BorderStyle.Solid;
                ScriptManagerAppointmentsReport.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}