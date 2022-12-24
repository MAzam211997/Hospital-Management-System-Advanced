using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_System.Reporting
{
    public partial class PerPatientReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsr = new DataSet();
            _con = new SqlConnection(_strCon);

            _adp = new SqlDataAdapter("Select * from tbl_cad", _con);
            DataTable tbl1 = new DataTable();
            tbl1.TableName = "TableNameForReport";
            _adp.Fill(tbl1);

            _adp = new SqlDataAdapter("Select * from OtherTable", _con);
            DataTable tbl2 = new DataTable();
            tbl2.TableName = "AnotherTableNameForReport";
            _adp.Fill(tbl2);

            dsr.Tables.Add(tbl1);
            dsr.Tables.Add(tbl2);
        }
    }
}