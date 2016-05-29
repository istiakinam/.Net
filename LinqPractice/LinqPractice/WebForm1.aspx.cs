using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqPractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            //GridView1.DataSource = obj.LinqTbls;
            GridView1.DataSource = from emp in obj.LinqTbls
                                 where emp.Age > 15
                                 orderby emp.Name ascending
                                 select emp;
            
            GridView1.DataBind();
        }
    }
}