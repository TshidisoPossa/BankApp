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
    //Tshidiso Possa 
    // Advance C# Program
    //Project 2 
    // 08/09/2023
    public partial class DisplayAccount : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Purchase;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e, string connectionString)
        {
           using(SqlConnection sqlConn = new SqlConnection(connectionString))
           {
                

           }





        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyAccount.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}