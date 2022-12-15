using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital_Management_System.Models;
using Microsoft.Reporting.WebForms;
using System.Data.Entity;

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
                dynamic datasource = entities.Appointments.Include(c => c.Doctor).Include(c => c.Patient)
                .Where(c => c.Status == true).ToList();
                //foreach (var item in datasource.Value.ToString().ToList())
                //{

                //    var doctor = item;
                //}
                ReportParameter[] parms = new ReportParameter[1];
                //parms[0] = new ReportParameter("param_name", textbox(n - 1).text);
                //parms[1] = new ReportParameter("param_course", textbox(n).text);
                //AppointmentReportViewer.LocalReport.SetParameters(parms);
               // AppointmentReportViewer.ReportRefresh();
                AppointmentReportViewer.LocalReport.DataSources.Clear();
                AppointmentReportViewer.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}