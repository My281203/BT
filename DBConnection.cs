using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Tuan2
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable DanhSach(string str)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select*FROM " + str, conn);
            DataTable dsHocSinh = new DataTable();
            adapter.Fill(dsHocSinh);
            return dsHocSinh;
        }
        public void Connection(string sqlStr)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("That bai!" + exc);
            }
            finally
            {
                conn.Close();
            }
        }       
        public bool IsEmail(string Email)
        {
            try
            {
                MailAddress m = new MailAddress(Email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsNumbeṛ̣(string Number)
        {
            for (int i = 0; i < Number.Length; i++)
            {
                if (char.IsDigit(Number[i]) == true)
                    return true;
            }
            return false;
        }
    }
}

    

