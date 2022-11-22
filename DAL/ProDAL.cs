using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintBox1.DAL
{
    public class ProDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public ProDAL()
        {
            //calling connection string connection string should be set in web.config file
            string conn = ConfigurationManager.ConnectionStrings["complaint"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int UserInsert(BAL.ProBAL obj)
        {
            string qry = "insert into User_Tbl values('" + obj.Name + "','" + obj.Email + "','" + obj.Phone_Number + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int InsertLogin(BAL.ProBAL obj)
        {
            string qry1 = "insert into Login values('" + obj.Name + "','User','" + obj.Password + "','waiting')";
            SqlCommand cmd = new SqlCommand(qry1, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int RegProd(BAL.ProBAL obj)
        {
            string qry2 = "insert into Product values('" + obj.Product_Name + "'," + obj.Price + ")";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable UserView()
        {
            string s = "select *from Login where status='waiting'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int userApprove(BAL.ProBAL obj)
        {
            string s = "Update Login set status='Confirm' where login_id =" + obj.login_id;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable PageLogin(BAL.ProBAL obj)
        {
            string qry = "SELECT * FROM  Login WHERE Username='" + obj.Name + "' AND Password='" + obj.Password + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ProdView()

        {

            string s = "SELECT * FROM  Product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public int complaint(BAL.ProBAL obj)
        {
            string qry2 = "insert into complaint(User_Id,Product_Id,Complaint,Status,Date)values('"+ obj.login_id + "','"+ obj.Product_Id + "','" + obj.Complaint + "','Notyet',GETDATE() )";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int QueryInsert(BAL.ProBAL obj)
        {
            string qry2 = "insert into Query(Product_Id,User_Id,Query)values('" + obj.Product_Id +"','" + obj.login_id  + "','" + obj.Productquery + "')";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable GetProduct (BAL.ProBAL obj)
        {
            
            string qry = "SELECT * FROM  Product";
            SqlCommand cmd = new SqlCommand(qry , GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable Getquery(BAL.ProBAL obj)
        {

            string qry = "SELECT * FROM  Product";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Complaintview(BAL.ProBAL obj)
        {

            //string qry = "SELECT * FROM  Product";
            string qry2 = "select * from complaint where Date >= '" + obj.From + "' AND Date<='" + obj.To + "'";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }


        public int ComplaintApprove(BAL.ProBAL obj)
        {

            
            string s = "update Complaint set Status ='InProcess' where C_Id='" + obj.C_Id + "'";

            SqlCommand cmd = new SqlCommand(s, GetCon());

            
            return cmd.ExecuteNonQuery();
        }

        public DataTable Complaintinprocess(BAL.ProBAL obj)
        {

            
            string s = "update Complaint set Status ='InProcess' where C_Id='" + obj.C_Id + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public DataTable ComplaintClosed(BAL.ProBAL obj)
        {


            string s = "update Complaint set Status ='Process closed' where C_Id='" + obj.C_Id + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }




    }
}




    

