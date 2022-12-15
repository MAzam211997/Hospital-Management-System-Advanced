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
    public partial class ScheduleReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ScheduleReportViewer.ProcessingMode = ProcessingMode.Local;
                ScheduleReportViewer.InternalBorderStyle = BorderStyle.Solid;
                ScheduleReportViewer.InternalBorderStyle = BorderStyle.Solid;
                ScheduleReportViewer.ToolBarItemBorderStyle = BorderStyle.Solid;
                ScheduleReportViewer.LocalReport.ReportPath = Server.MapPath("DataSets/ScheduleReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("DataSet1", (entities.Schedules.Include(c => c.Doctor).ToList()));
                //foreach (var item in datasource.Value.ToString().ToList())
                //{

                //    var doctor = item;
                //}
                ReportParameter[] parms = new ReportParameter[1];
                //parms[0] = new ReportParameter("param_name", textbox(n - 1).text);
                //parms[1] = new ReportParameter("param_course", textbox(n).text);
                //ScheduleReportViewer.LocalReport.SetParameters(parms);
                // ScheduleReportViewer.ReportRefresh();
                ScheduleReportViewer.LocalReport.DataSources.Clear();
                //ScheduleReportViewer.LocalReport.DataSources.Add(new ReportDataSource(datasource, dataset.Tables[0]));
                //ScheduleReportViewer.LocalReport.DataSources.Add(new ReportDataSource("reportDataSource1", dataset.Tables[1]));
                //ScheduleReportViewer.LocalReport.DataSources.Add(new ReportDataSource("reportDataSource2", dataset.Tables[2]));
                //ScheduleReportViewer.LocalReport.DataSources.Add(new ReportDataSource("reportDataSource3", dataset.Tables[3]));
                //ScheduleReportViewer.LocalReport.DataSources.Add(new ReportDataSource("reportDataSource4", dataset.Tables[4]));
                ScheduleReportViewer.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}