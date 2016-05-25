using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticeForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static class MyConnection
        {
            public static SqlConnection getConnection()
            {
                string conn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection myConn = new SqlConnection(conn);
                return myConn;
            }
        }

 
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Session["Name"] = txtUsername.Text;
            Session["Password"] = txtPassword.Text;

            var con = MyConnection.getConnection();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand Scmd = new SqlCommand("spLogin", con);
            Scmd.CommandType = CommandType.StoredProcedure;

            Scmd.Parameters.AddWithValue("@username", txtUsername.Text);
            Scmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader Dr = Scmd.ExecuteReader();
            if (Dr.Read())
            {
                Response.Redirect("ViewDetails.aspx");
            }
            else
            {
                Response.Write("Invalid credential");
            }
            con.Close();

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}