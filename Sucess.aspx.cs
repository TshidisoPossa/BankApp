using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace BillionBank_Tshidiso_
{
    public partial class Sucess : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Success_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");

        }
    }
}