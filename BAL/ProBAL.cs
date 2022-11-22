using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintBox1.BAL
{
    public class ProBAL
    {
        DAL.ProDAL objprodal = new DAL.ProDAL();

        private string _Name;
        private string _PhoneNo;
        private string _Email;
        private string _password;
        private string _ProName;
        private string _price;
        private int _login;
        private int _ProductId;
        private string _Complaint;
        private string _query;
        private string _To;
        private string _From;
        private string _C_Id;
        
        
        

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Phone_Number
        {
            get
            {
                return _PhoneNo;
            }
            set
            {
                _PhoneNo = value;
            }

        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }

        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }

        }
        public string Product_Name
        {
            get
            {
                return _ProName;
            }
            set
            {
                _ProName = value;
            }

        }
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }

        }
        public int login_id
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }

        }

        public int Product_Id
        {
            get
            {
                return _ProductId;
            }
            set
            {
                _ProductId = value;
            }
        }

        public String Complaint
        {
            get
            {
                return _Complaint;
            }
            set
            {
                _Complaint = value;
            }
        }

        public String Productquery
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }

        public String To
        {
            get
            {
                return _To;
            }
            set
            {
                _To = value;
            }
        }

        public String From
        {
            get
            {
                return _From;
            }
            set
            {
                _From = value;
            }
        }

        public String C_Id
        {
            get
            {
                return _C_Id;
            }
            set
            {
                _C_Id = value;
            }
        }





        public int InsertStudent()
        {
            return objprodal.UserInsert(this);
        }
        public int LoginInsert()
        {
            return objprodal.InsertLogin(this);
        }
        public int ProductReg()
        {
            return objprodal.RegProd(this);
        }
        public DataTable viewUser()
        {
            return objprodal.UserView();
        }
        public int approveUser()
        {
            return objprodal.userApprove(this);
        }

        public DataTable LoginPage()
        {
            return objprodal.PageLogin(this);
        }

        public DataTable viewProd()
        {
            return objprodal.ProdView();
        }

        public int InsertComplaint()
        {
            return objprodal.complaint (this);
        }

        public int InsertQuery()
        {
            return objprodal.QueryInsert(this);
        }

        public DataTable GetProduct ()
        {
            return objprodal.GetProduct(this);
        }

        public DataTable Getquery ()
        {
            return objprodal.Getquery (this);
        }

        public DataTable ComplaintView()
        {
            return objprodal.Complaintview(this);
        }

        public int approvecomplaint()
        {
            return objprodal.ComplaintApprove(this);
        }

        public DataTable inprocesscomplaint()
        {
            return objprodal.Complaintinprocess(this);
        }

        public DataTable processcompleted()
        {
            return objprodal.ComplaintClosed(this);
        }




    }
}
