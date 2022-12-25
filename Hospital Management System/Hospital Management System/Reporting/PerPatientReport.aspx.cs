using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_System.Reporting
{
    public partial class PerPatientReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer_PerPatientReport.ProcessingMode = ProcessingMode.Local;
                ReportViewer_PerPatientReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewer_PerPatientReport.InternalBorderStyle = BorderStyle.Solid;
                ReportViewer_PerPatientReport.ToolBarItemBorderStyle = BorderStyle.Solid;
                ReportViewer_PerPatientReport.LocalReport.ReportPath = Server.MapPath("DataSets/MedicalTestReport.rdlc");
                DataSet dataSet = new DataSet();
                string _strCon = ConfigurationManager.ConnectionStrings["aspnet_Hospital_Management_System_20181110095545ConnectionString"].ConnectionString;

                SqlConnection _con = new SqlConnection(_strCon);
                string query = "SELECT * FROM OperationTheatres INNER JOIN Appointments ON  Appointments.Id = OperationTheatres.AppointmentId ";
                SqlDataAdapter _adp = new SqlDataAdapter(query, _con);
                DataTable tbl1 = new DataTable();
                _adp.Fill(tbl1);
                dataSet.Tables.Add(tbl1);

                ReportDataSource rds = new ReportDataSource("MedicalTestDataSet", query);
                ReportViewer_PerPatientReport.LocalReport.DataSources.Clear();
                ReportViewer_PerPatientReport.LocalReport.DataSources.Add(rds);
                ReportViewer_PerPatientReport.LocalReport.Refresh();

            }
        }
    }
}