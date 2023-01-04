using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KT_HUONGGIANG.Logic;
using KT_HUONGGIANG.Dao;
namespace KT_HUONGGIANG
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            Dao.EmployeeDao e = new EmployeeDao();
            dgvDanhSach.DataSource = e.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    throw new Exception("Mã NV không được để trống ");
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Tên NV không được để trống ");

                }
                if (string.IsNullOrEmpty(txtNoisinh.Text))
                {
                    throw new Exception("Nơi sinh không được để trống ");
                }
      
                string manv = (txtMa.Text);
                string ten = txtName.Text;
                string diachi = txtNoisinh.Text;
                string donvi = cbbDonVi.Text;
                DateTime ngay = dtpNgaysinh.Value;
                Boolean gt = cbGioiTinh.Checked;
  
                Employee em = new Employee(manv,ten,ngay,gt,diachi,donvi);
                EmployeeDao nv = new EmployeeDao();
                nv.Insert(em);
                loadData();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txtMa.Text.Length == 0)
                    {
                        throw new Exception("Id Employee không hợp lệ");

                    }
                    string ma = txtMa.Text;
                    Dao.EmployeeDao dao = new EmployeeDao();
                    dao.Delete(ma);
                    loadData();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }
    }
}
