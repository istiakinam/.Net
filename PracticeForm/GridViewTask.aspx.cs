using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PracticeForm
{
    public partial class GridViewTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var con = MyConnection.getConnection();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand Scmd = new SqlCommand("select * from PracticeForm", con);

            SqlDataReader Dr = Scmd.ExecuteReader();
          
            GridView1.DataSource = Dr;
            GridView1.DataBind();
            
            Dr.Close();
            con.Close();
        }

        public static class MyConnection
        {
            public static SqlConnection getConnection()
            {
                string conn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection myCon = new SqlConnection(conn);
                return myCon;
            }
        }
    }
}