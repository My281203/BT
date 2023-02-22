using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace BT_Tuan2
{
    class GiaoVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public DataTable DanhSachGV(string dbgv)
        {       
                return db.DanhSach(dbgv);
        }
        public void Add(Person gv)
        {
                conn.Open();
                string sqlStr = String.Format("INSERT INTO GiaoVien(Ma, Ten, Diachi, Cmnd, Ngaysinh, Email, SoDT) VALUES('{0}','{1}','{2}','{3}', '{4}', '{5}','{6}')", gv.Id, gv.Name, gv.Diachi, gv.Cmnd, gv.Dateofbirth, gv.Email, gv.Number);
                db.Connection(sqlStr);
        }
        public void Update(Person gv)
        {           
                conn.Open();
                string sqlStr = String.Format("UPDATE GiaoVien SET Ten = '{1}', Diachi = '{2}', Cmnd = '{3}', Ngaysinh = '{4}', Email = '{5}', SoDT = '{6}' WHERE Ma = '{0}'", gv.Id, gv.Name, gv.Diachi, gv.Cmnd, gv.Dateofbirth, gv.Email, gv.Number);
                db.Connection(sqlStr);
        }
        public void Delete(Person gv)
        {           
                conn.Open();
                string sqlStr = String.Format("DELETE FROM GiaoVien WHERE Ma = '{0}'", gv.Id);
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
