using Hospital_Management_System.Models;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_System.Reporting
{
    public partial class MedicalTestReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ReportViewer_MedicalTestReport.ProcessingMode = ProcessingMode.Local;
            ReportViewer_MedicalTestReport.InternalBorderStyle = BorderStyle.Solid;
            ReportViewer_MedicalTestReport.InternalBorderStyle = BorderStyle.Solid;
            ReportViewer_MedicalTestReport.ToolBarItemBorderStyle = BorderStyle.Solid;
            ReportViewer_MedicalTestReport.LocalReport.ReportPath = Server.MapPath("DataSets/MedicalTestReport.rdlc");
            var entities = new ApplicationDbContext();
            ReportDataSource datasource = new ReportDataSource("MedicalTestDataSet", (from test in entities.MedicalTest
                                                                                   select test));
            ReportViewer_MedicalTestReport.LocalReport.DataSources.Clear();
            ReportViewer_MedicalTestReport.LocalReport.DataSources.Add(datasource);
        }
    }
}