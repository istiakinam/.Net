using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace PracticeForm
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(args.Value.Length > 6)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = txtName.Text;
                string password = txtPassword.Text;
                string gender = rbtLstGender.SelectedValue;
                string dob = txtDOB.Text;
                string email = txtEmail.Text;
                string contact = txtContact.Text;

                SqlConnection conn = new SqlConnection(@"Data Source = ISTIAK-LPT\SQLEXPRESS; trusted_connection = true; initial catalog = myPractice");
                conn.Open();

                SqlCommand scmd = new SqlCommand("spQuery", conn);
                scmd.CommandType = CommandType.StoredProcedure;

                scmd.Parameters.AddWithValue("@name", name);
                scmd.Parameters["@name"].Direction = ParameterDirection.Input;

                scmd.Parameters.AddWithValue("@password", password);
                scmd.Parameters["@password"].Direction = ParameterDirection.Input;

                scmd.Parameters.AddWithValue("@gender", gender);
                scmd.Parameters["@gender"].Direction = ParameterDirection.Input;

                scmd.Parameters.AddWithValue("@dob", dob);
                scmd.Parameters["@dob"].Direction = ParameterDirection.Input;

                scmd.Parameters.AddWithValue("@email", email);
                scmd.Parameters["@email"].Direction = ParameterDirection.Input;

                scmd.Parameters.AddWithValue("@contact", contact);
                scmd.Parameters["@contact"].Direction = ParameterDirection.Input;

                scmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("Data inserted");
            }
            else
            {
                Response.Write("Data failed to insert");
            }
        }
    }
}