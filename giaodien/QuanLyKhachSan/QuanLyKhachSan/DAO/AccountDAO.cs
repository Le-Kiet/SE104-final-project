using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.DAO
{
    public class AccountDAO
    {
        public static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string Username, string password)
        {
            string query = "select * from dbo.TAIKHOAN where Username= '"+Username+ "' and password = '"+ password+"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
