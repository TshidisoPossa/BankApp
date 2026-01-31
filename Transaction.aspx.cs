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
    public partial class Transaction : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Purchase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void CheckBalnce1()
        {
            //This method helps the user to check their account balance
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Client where ClientIDNumber = " + txtFrom.Text + "", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                LblAmount.Text = "$100" + dr["AccountBalance"].ToString();


            }
            conn.Close();
        }
        protected void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "")
            {
                Response.Redirect("Enter Source Account");
            }
            else
            {
                CheckBalnce1();
            }
            if(LblAmount.Text == "Amount")
            {
                Response.Redirect("Account not found");
            }

        }
        private void checkBalance()
        {
            //This button allows the user to check their balance 

            conn.Open();
            DataSet ds = new DataSet();
            //SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dba = new SqlDataAdapter("Select * from Client where ClientIDNumber = " + txtBalance.Text + "",conn);
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dba.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                LblBalance.Text = "$100" + dr["AccountBalance"].ToString();

            }

            conn.Close();
        }

        protected void Btn_Check_Click(object sender, EventArgs e)
        {
            if (txtBalance.Text == "")
            {
                Response.Write("Enter account Number");

            }
            else
            {
                checkBalance();


            }
            if (LblBalance.Text == "Your Balance")
            {
                Response.Write("Account Not Found");

            }
        
        }
        private void CheckBalance2()
        {
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Client where ClientIDNumber = " + txtTo.Text + "", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Response.Write("Account Found");
            }

            conn.Close();
        }

        protected void btn_Enter2_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                Response.Write("Enter Destination Account:");
            }
            else
            {
                CheckBalance2();
            }
            if (LblAmount.Text == "Amount")
            {

            }
        
        
        }
        private void Transfer()
        {
            //This method is used to inpliment a transfer from 1 account to another chosen account 
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"Insert into Transactions(transAmount,transDate,SourceAccount,destinationAccount) Values(@TA,@TD,@TSA,@TDA)";

                cmd.Parameters.AddWithValue("@TA", TxtAmount.Text);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TSA", txtFrom.Text);
                cmd.Parameters.AddWithValue("@TDA", txtTo.Text);

                Response.Write("<script>alert('Money transfered'); </script>");
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);

            }



        }

        protected void btn_Transfer_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "" || txtFrom.Text == "" || TxtAmount.Text == "")
            {
                Response.Write("Missing Information");

            }
            else
            {
                Transfer();

            }


        }
        
        protected void Btn_Reset_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "";
            txtBalance.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";


        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyAccount.aspx");
        }

        protected void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}


