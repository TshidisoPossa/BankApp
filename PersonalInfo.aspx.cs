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
    public partial class PersonalInformation : System.Web.UI.Page
    {
        // Connecting the Sql Data base 
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VNDHNQF4\SQLEXPRESS01;Initial Catalog=Website;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Display_Click(object sender, EventArgs e)
        {
            //This button allows the user to display information 

            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand(); // Creating a Sql Command
            //cmd.CommandType = CommandType.Text;  //returns the type of Command object
            //cmd.CommandText = "Select * FROM Client"; // Select from the Client Table 
            //DataTable dt = new DataTable();
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter sd = new SqlDataAdapter(cmd);

            //sd.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            //conn.Close();


        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            //This button helps the user delete their Information 

            if (txtClientIDNumber.Text == "" || txtClientName.Text == "" || txtClientPassword.Text == "" || txtClientAdress.Text == "" || txtClientEmail.Text == "" || txtclientPhoneNumber.Text == "" || txtQuestion.Text == "")
            {
                Response.Write("<script> alert('Missing Information'); </script>");

            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete * from Client where ClientName = " + txtClientName.Text + "";
                    cmd.ExecuteNonQuery();
                    Response.Write("<script> alert('Account deleted successfully'); </script>");
                    conn.Close();

                }
                catch (Exception Ex)
                {
                    Response.Write(Ex.Message);

                }
                int key = 0;

                if (key == 0)
                {
                    Response.Write("<script> alert('Account deleted successfully'); <script>");
                }
                else
                {
                    Response.Write("<script> alert('Missing information'); </script>");

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from the Client where ClientIDNumber = @CuKey", conn);
                        cmd.Parameters.AddWithValue("@Cukey", key);
                        cmd.ExecuteNonQuery();
                        Response.Write("<script> alert('Account Deleted'); </script>");

                        conn.Close();
                        Reset();
                    }
                    catch (Exception Ex)
                    {
                        Response.Write(Ex.Message);

                    }

                }




            }
        
              
        }

        protected void btn_ResetData_Click(object sender, EventArgs e)
        {
            //If the user wants to reset the data in the personal information

            Reset();
        }
        private void Reset() //This method helps the reset button
        {
            txtClientName.Text = "";
            txtClientIDNumber.Text = "";
            txtClientAdress.Text = "";
            txtClientEmail.Text = "";
            txtClientPassword.Text = "";
            txtclientPhoneNumber.Text = "";

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //This method submits the information to the Database

            if (txtClientIDNumber.Text == "" || txtClientName.Text == "" || txtClientPassword.Text == "" || txtClientAdress.Text == "" || txtClientEmail.Text == "" || txtclientPhoneNumber.Text == "" || txtQuestion.Text == "")
            {
                Response.Write("<script> alert('Missing information'); </script>");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Client(ClientIDNumber,ClientName,ClientPassword,ClientAddress,ClientEmail,clientPhoneNumber,Questions)values (@ID,@UN,@UP,@UA,@UE,@PN,@QS)", conn);
                    cmd.Parameters.AddWithValue("@ID", txtClientIDNumber.Text);
                    cmd.Parameters.AddWithValue("@UN", txtClientName.Text);
                    cmd.Parameters.AddWithValue("@UP", txtClientPassword.Text);
                    cmd.Parameters.AddWithValue("@UA", txtClientAdress.Text);
                    cmd.Parameters.AddWithValue("@UE", txtClientEmail.Text);
                    cmd.Parameters.AddWithValue("@PN", txtclientPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@QS", txtQuestion.Text);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script> alert('Account Created'); </script>");

                    conn.Close();
                    Reset();


                }
                catch(Exception Ex)
                {
                    Response.Write(Ex.Message);

                }



            }
        
        

        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            // this button helps the user edit their information
            if (txtClientIDNumber.Text == "" || txtClientName.Text == "" || txtClientPassword.Text == "" || txtClientAdress.Text == "" || txtClientEmail.Text == "" || txtclientPhoneNumber.Text == "" || txtQuestion.Text == "")
            {
                Response.Write("<script>alert('Missing Inforamtion'); </script>");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Client Set ClientName = @UN,clientPasswod = @UP,clientAddress = @UA,clientEmail = @UE,ClientPhoneNumber = @UPN where ClientIDNumber = @ID", conn);
                cmd.Parameters.AddWithValue("@UN", txtClientName.Text);
                cmd.Parameters.AddWithValue("@UP", txtClientPassword.Text);
                cmd.Parameters.AddWithValue("@UA", txtClientAdress.Text);
                cmd.Parameters.AddWithValue("@UE", txtClientEmail.Text);
                cmd.Parameters.AddWithValue("@UPN", txtclientPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@ID", txtClientIDNumber.Text);
                //cmd.ExecuteNonQuery();

                Response.Write("<script> alert('Information is updated Successfully');</script>");
                conn.Close();
            }
        
        
        
        
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This control displays information from the user input 
            txtClientIDNumber.Text = GridView1.SelectedRow.Cells[1].Text;
            txtClientName.Text = GridView1.SelectedRow.Cells[2].Text;
            txtClientPassword.Text = GridView1.SelectedRow.Cells[3].Text;
            txtClientAdress.Text = GridView1.SelectedRow.Cells[4].Text;
            txtclientPhoneNumber.Text = GridView1.SelectedRow.Cells[5].Text;
            txtClientEmail.Text = GridView1.SelectedRow.Cells[6].Text;    
            txtQuestion.Text = GridView1.SelectedRow.Cells[7].Text;

            int key = 0;

            if (txtClientIDNumber.Text == " ")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

            }

        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {

            Response.Redirect("MyAccount.aspx");
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}