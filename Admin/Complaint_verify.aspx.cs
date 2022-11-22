using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox1.Admin
{

    public partial class Complaint_verify : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            objprobal.From = TextBox1.Text;
            objprobal.To = TextBox2.Text;
            GridView1.DataSource = objprobal.ComplaintView();
            GridView1.DataBind();
        }

       

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprobal.C_Id=id.ToString();
            int i = objprobal.approvecomplaint();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprobal.ComplaintView();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprobal.C_Id = id.ToString();
            int i = objprobal.approvecomplaint();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprobal.ComplaintView();
            GridView1.DataBind();
        }
    }
}