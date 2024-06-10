using QuanLyQuanCafe.DTO;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;  //  <= debug để lấy password mã hoá tại chuỗi hasPass
                                  //  chọn dòng 30, nhấn f9 để debug => login rồi đưa chuột vào hasPass để lấy mã
                                  //  copy mã, dán vào database làm password
            }
            string query = "USP_Login @userName , @passWord"; // nhớ cách trước dấu phẩy

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, hasPass});
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] {userName, displayName, pass, newPass});
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, Type from Account");
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("insert Account ( UserName, DisplayName, Type, Password ) values ( N'{0}', N'{1}', {2}, N'{3}' )", name, displayName, type, "20720532132149213101239102231223249249135100218");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("update Account set DisplayName = N'{0}', Type = {1} where UserName = N'{2}'", displayName, type, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update Account set password = N'20720532132149213101239102231223249249135100218' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}


