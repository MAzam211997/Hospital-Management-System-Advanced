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
    public partial class PatientsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.InternalBorderStyle = BorderStyle.Solid;
                ReportViewer1.InternalBorderStyle = BorderStyle.Solid;
                ReportViewer1.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("DataSets/PatientsReport.rdlc");
                var entities = new ApplicationDbContext();
                ReportDataSource datasource = new ReportDataSource("PatientsDataSet", (from patients in entities.Patients
                                                                               select patients));
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);

            }
        }
    }
}