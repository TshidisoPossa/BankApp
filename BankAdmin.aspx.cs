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
    public partial class BankAdmin : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Website;Integrated Security=True ");
        protected void Page_Load(object sender, EventArgs e)
        {
             conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Client set AccountBalance = 100";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void btn_NewUserAccount_Click(object sender, EventArgs e)
        {

            Response.Redirect("PersonalInfo.aspx");
        }

        protected void btn_UserAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyAccount.aspx");
        }
    }
}