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
    public partial class PerDoctorReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer_PerDoctorReport.ProcessingMode = ProcessingMode.Local;
            ReportViewer_PerDoctorReport.InternalBorderStyle = BorderStyle.Solid;
            ReportViewer_PerDoctorReport.InternalBorderStyle = BorderStyle.Solid;
            ReportViewer_PerDoctorReport.ToolBarItemBorderStyle = BorderStyle.Solid;
            ReportViewer_PerDoctorReport.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
            //DataSet dataSet = new DataSet();
            //string _strCon = ConfigurationManager.ConnectionStrings["aspnet_Hospital_Management_System_20181110095545ConnectionString"].ConnectionString;
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            //SqlConnection _con = new SqlConnection(_strCon);
            //string query = "SELECT * FROM Patients Where Id ="+ id;
            //SqlDataAdapter _adp = new SqlDataAdapter(query, _con);
            //DataTable tbl1 = new DataTable();
            //_adp.Fill(tbl1);
            //dataSet.Tables.Add(tbl1);
            int id = Convert.ToInt32(Request.QueryString["id"]);
            var entities = new ApplicationDbContext();
            ReportDataSource datasource = new ReportDataSource("Doctors", (from doctor in entities.Doctors
                                                                                   where doctor.Id.Equals(id)
                                                                                   select doctor));
            ///ReportDataSource rds = new ReportDataSource("PatientsDataSet", query);
            ReportViewer_PerDoctorReport.LocalReport.DataSources.Clear();
            ReportViewer_PerDoctorReport.LocalReport.DataSources.Add(datasource);
            ReportViewer_PerDoctorReport.LocalReport.Refresh();
        }
    }
}