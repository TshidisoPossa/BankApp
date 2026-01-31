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
    public partial class CheckBalance : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void checkBalance()
        {
            //This method is to Help the user check the balance 
            conn.Open();
            DataSet ds = new DataSet();  // It will retrieve data from the database
            SqlDataAdapter dba = new SqlDataAdapter("Select * from Client where ClientIDNumber = " + txtAccount.Text + " ", conn);
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dba.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                LblBalance.Text = "$100" + dr["AccountBalance"].ToString();

            }

            conn.Close();
        }
        protected void btn_Check_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                Response.Write("Enter your Account Number");
            }
            else
            {
                checkBalance();
                if (LblBalance.Text == "Your Balnce")
                {
                    Response.Write("Account not found");

                }

                

            }
 
        }

        protected void btn_Reset_Click(object sender, EventArgs e)
        {

            txtAccount.Text = "";
        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {

            Response.Redirect("MyAccount.aspx");
        }
    }
}