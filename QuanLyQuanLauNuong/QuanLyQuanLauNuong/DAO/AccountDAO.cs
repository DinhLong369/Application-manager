using QuanLyQuanLauNuong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanLauNuong.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord});

            return result.Rows.Count > 0;
        }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "Select * from Account";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }

            return list;
        }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where UserName = '" + username + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool InsertAccount(string username , string showName,int type, string password)
        {
            string query = string.Format("INSERT dbo.Account (Username , ShowName, Type ,PassWord )VALUES  ( N'{0}' , N'{1}', {2} ,N'{3}')", username, showName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string showName, int type, string password)
        {
            string query = string.Format("UPDATE dbo.Account SET ShowName = N'{1}', Type = {2}, PassWord = N'{3}' WHERE UserName = N'{0}'", name, showName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
