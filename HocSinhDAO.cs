using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mail;

namespace BT_Tuan2
{
    class HocSinhDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public DataTable DanhSachHS(string dshs)
        {
            return db.DanhSach(dshs);
        }
        public void Add(Person hs)
        {
           
            string sqlStr = String.Format("INSERT INTO HocSinh(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT) VALUES('{0}','{1}','{2}','{3}', '{4}', '{5}','{6}')", hs.Id, hs.Name, hs.Diachi, hs.Cmnd, hs.Dateofbirth, hs.Email, hs.Number);
            db.Connection(sqlStr);
        }
        public void Update(Person hs)
        {
          
            string sqlStr = String.Format("UPDATE HocSinh SET Ten = '{1}', Diachi = '{2}', Cmnd = '{3}', Ngaysinh = '{4}', Email = '{5}', SoDT = '{6}' WHERE Ma = '{0}'", hs.Id, hs.Name, hs.Diachi, hs.Cmnd, hs.Dateofbirth, hs.Email, hs.Number);
            db.Connection(sqlStr);
        }
        public void Delete(Person hs)
        {
         
            string sqlStr = String.Format("DELETE FROM HocSinh WHERE Ma = '{0}'", hs.Id);
            db.Connection(sqlStr);
        }
        public void checkEmail(string Email)
        {
            db.IsEmail(Email);
        }
        public void checkNumber(string Number)
        {
            db.IsNumbeṛ̣(Number);
        }
    }
}
