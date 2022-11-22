using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox1.User
{
    public partial class Query : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            DropDownList1.DataSource = objprobal.GetProduct();
            DropDownList1.DataTextField = "Product_Name";
            DropDownList1.DataValueField = "Product_Id";

            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprobal.Product_Id = int.Parse(DropDownList1.SelectedItem.Value);
            objprobal.Productquery = TextBox2.Text;
            objprobal.login_id = Convert.ToInt32(Session["id"]);
            objprobal.Name = Convert.ToString(Session["uname"]);
            int i = objprobal.InsertQuery();
            if (i == 1)
            {
                Response.Write("<script>alert('Register success');</script>");
            }

        }

       
    }
}