using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT_Tuan2
{
    public partial class GiaoVienForm : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDAO dao = new GiaoVienDAO();
        public GiaoVienForm()
        {
            InitializeComponent();
        }
        public DataTable DanhSachGV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select*FROM GiaoVien", conn);
            DataTable dsGiaoVien = new DataTable();
            adapter.Fill(dsGiaoVien);
            return dsGiaoVien;
        }
        private void GiaoVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            gvGiaoVien.DataSource = dao.DanhSachGV("GiaoVien");
            conn.Close();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Add(gv);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            GiaoVien_Load(sender, e);
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Delete(gv);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            GiaoVien_Load(sender, e);
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Update(gv);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            GiaoVien_Load(sender, e);
        }
        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = gvGiaoVien.Rows[e.RowIndex];
                txtName.Text = Convert.ToString(row.Cells["Ten"].Value);
                txtAddress.Text = Convert.ToString(row.Cells["Diachi"].Value);
                txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
                txtCmnd.Text = Convert.ToString(row.Cells["Cmnd"].Value);
                dtpDateofbirth.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);
                txtNumber.Text = Convert.ToString(row.Cells["Sdt"].Value);
                txtId.Text = Convert.ToString(row.Cells["Ma"].Value);
            }
        }
    }
}
