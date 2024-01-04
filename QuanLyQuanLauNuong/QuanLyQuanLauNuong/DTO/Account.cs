using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanLauNuong.DTO
{
    public class Account
    {
        private string userName;
        private string passWord;
        private string showName;
        private int type;

        public Account(string userName, string showName, int type, string passWord = null)
        {
            UserName = userName;
            PassWord = passWord;
            ShowName = showName;
            Type = type;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.ShowName = row["ShowName"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["PassWord"].ToString();
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string ShowName { get => showName; set => showName = value; }
        public int Type { get => type; set => type = value; }
    }
}
