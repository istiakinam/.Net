using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqPractice
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        private void GetData()
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            GridView1.DataSource = obj.LinqTbls;
            GridView1.DataBind();
        }

        protected void BtnSelect_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            LinqTbl tbl = new LinqTbl
            {
                ID = 5,
                Name = "Thiktat",
                Age = 4,
                Contact = 000
            };
            obj.LinqTbls.InsertOnSubmit(tbl);
            obj.SubmitChanges();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext obj = new DataClasses1DataContext())
        }
    }
}