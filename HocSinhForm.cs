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
    public partial class HocSinhForm : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO dao = new HocSinhDAO();
        public HocSinhForm()
        {
            InitializeComponent();
        }        
        private void HocSinh_Load(object sender, EventArgs e)
        {
            conn.Open();
            gvHocSinh.DataSource = dao.DanhSachHS("HocSinh");
            conn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Add(hs);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            HocSinh_Load(sender, e);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Update(hs);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            HocSinh_Load(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDateofbirth.Value.Date, txtEmail.Text, txtNumber.Text);
            dao.Delete(hs);
            dao.checkEmail(txtEmail.Text);
            dao.checkNumber(txtNumber.Text);
            HocSinh_Load(sender, e);
        }
        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            GiaoVienForm gv = new GiaoVienForm();
            gv.ShowDialog();
        }
        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = gvHocSinh.Rows[e.RowIndex];
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
