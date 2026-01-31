using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Text;
using System.Drawing;

namespace BillionBank_Tshidiso_
{
    //Tshidiso Possa 
    // Advance C# Program
    //Project 2 
    // 08/09/2023
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Register;Integrated Security=True");
                        
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        
        protected void btn_LoginPage(object sender, EventArgs e)
        {
            // This button controls will allow the user to login into the system 
            string check = "SELECT count(*) from Customer where Email = '" + txtEmail.Text + "' and custPassword = '" + txtcustPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(check,con);  //Initilizes an Sql Command which will add the input in the database 
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();

            if (temp == 1)
            { 
                //This will Redirect to the bank Admin Page 
                Response.Redirect("BankAdmin.aspx");

            }

            else
            {    //If the users enter the wrong password it will print this statement below 
                Label5.Text = "Your Email or Password is wrong "; 
            }

        }

        protected void LinkSignUp_Click(object sender, EventArgs e)
        {
            //Response.Redirect("LinkSignUp.aspx");
        }

        protected void LinkForgotPassword_Click(object sender, EventArgs e)
        {
            //This button will redirect to the forget
            Response.Redirect("LinkForgotPassword.aspx");

        }

        protected void txtClientIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}