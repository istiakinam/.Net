using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PracticeForm
{
    public partial class ViewDetails : System.Web.UI.Page
    {

        public static class MyConnection
        {
            public static SqlConnection getConnection()
            {
                string con = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection myCon = new SqlConnection(con);
                return myCon;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var conn = MyConnection.getConnection();
            if(conn.State != ConnectionState.Open){
                conn.Open();
            }
            SqlCommand Scmd = new SqlCommand("spSelect", conn);
            Scmd.CommandType = CommandType.StoredProcedure;

            Scmd.Parameters.AddWithValue("@Name", Session["Name"]);
            Scmd.Parameters.AddWithValue("@Pass", Session["Password"]);

            SqlDataReader Dr = Scmd.ExecuteReader();
            GridView1.DataSource = Dr;
            GridView1.DataBind();
            
            Dr.Close();
            conn.Close();
        }
    }
}