using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillionBank_Tshidiso_
{
    //Tshidiso Possa 
    // Advance C# Program
    //Project 2 
    // 08/09/2023
    public partial class MyAccount : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_UserList_Click(object sender, EventArgs e)
        {
            Response.Redirect("PersonalInfo.aspx");
        }

        protected void btn_CheckBalance_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckBalance.aspx");
        }

        protected void btn_Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction.aspx");
        }

        protected void btn_RecentTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayAccount.aspx");

        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyAccount.aspx");
        }
    }
}