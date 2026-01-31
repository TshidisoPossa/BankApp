using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace BillionBank_Tshidiso_
{
    //Tshidiso Possa 
    // Advance C# Program
    //Project 2 
    // 08/09/2023

    public partial class LinkForgotPassword : System.Web.UI.Page
    {
        //Establishes a Sql Connection 
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Website;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            //If the UserName and Password is empty it will display missing information 
            if (txtEmail.Text == "" ||txtcustPassword.Text == "")
            {
                Response.Write("<script> alert('Missing information'); </script>");
            }
            else
            {
                conn.Open(); //Opens the connection 
                SqlCommand cmd = new SqlCommand("Update Customer set Email = @E where custPassword = @CP", conn);
                cmd.Parameters.AddWithValue("@E", txtEmail.Text);
                cmd.Parameters.AddWithValue("@CP", txtcustPassword.Text);

                Response.Write("<script> alert('password is updated'); </script>");
                conn.Close();


            }
        
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}