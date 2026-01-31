using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;


namespace BillionBank_Tshidiso_
{
    //Tshidiso Possa 
    // Advance C# Program
    //Project 2 
    // 08/09/2023

    public partial class LinkSignUp : System.Web.UI.Page
    {
        //SqlConnection to the Database 
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Register;Integrated Security=True");
                                            
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        
        protected void btn_LinkSignUp_Click1(object sender, EventArgs e)
        {
            conn.Open(); //Connection open 
            string ins = "INSERT INTO [Customer](UserId,custName,custPassword,custAddress,phone,Email) Values(@UserId,@custName,@custPassword,@custAddress,@phone,@Email)";
            SqlCommand cmd = new SqlCommand(ins, conn);
            cmd.Parameters.AddWithValue("@UserId", txtUserId.Text.ToString()); //The values which are connected to the database 
            cmd.Parameters.AddWithValue("@custName", txtcustName.Text.ToString());//The values which are connected to the database
            cmd.Parameters.AddWithValue("@custPassword", txtcustPassword.Text.ToString());//The values which are connected to the database
            cmd.Parameters.AddWithValue("@custAddress", txtcustAddress.Text.ToString()); //The values which are connected to the database
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.ToString());
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("LoginPage.aspx"); //Redirect to the main page which is login page 






            //This button control will allow the user to login to the user
            //if (txtcustName.Text == "" || txtUserId.Text == "" || txtcustAddress.Text == "" || txtPhone.Text == " " || txtEmail.Text == "" || txtcustPassword.Text == "") //xtForgottenPassword.Text == "")
            // {
            //Response.Write("<script> alert('Missing Information');</script>");
            // }
            //else if (btn_LinkSign.Text == "")
            //{
            // conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update Client set AccountBalance = 100";
            //cmd.ExecuteNonQuery();
            //conn.Close();

            // }
            // else
            //{
            // try
            // {
            // conn.Open();
            // SqlCommand cmd = new SqlCommand("Insert INTO Register (custName,UserId,custPassword,custAddress,Email,Phone) values (@CN,@UD,@CP,@CA,@E,@P,");



            // cmd.Parameters.AddWithValue("@CN", txtcustName.Text);
            // cmd.Parameters.AddWithValue("@UD", txtUserId.Text);
            // cmd.Parameters.AddWithValue("@CP", txtcustPassword.Text);
            // cmd.Parameters.AddWithValue("@CA", txtcustAddress.Text);
            //cmd.Parameters.AddWithValue("@E",txtEmail.Text);
            //cmd.Parameters.AddWithValue("@P",txtPhone.Text);



            //cmd.Parameters.AddWithValue("@FP", txtForgottenPassword.Text);
            //cmd.Parameters.AddWithValue("@AB", 100);
            // cmd.Parameters.AddWithValue("@DO", DateTime.Now.Date);
            //cmd.ExecuteNonQuery();
            //conn.Close();


            //Response.Redirect("LoginPage.aspx");
            //}
            //catch (Exception Ex)
            //{
            //   Response.Write(Ex.Message);

            //}


            // }



            //}

            ///protected void btn_logout_Click(object sender, EventArgs e)
            // {

            //Response.End();  // close the entire program 

            //}

            //protected void txtClientIdNumber_TextChanged(object sender, EventArgs e)
            //{

        }
    }
    
}