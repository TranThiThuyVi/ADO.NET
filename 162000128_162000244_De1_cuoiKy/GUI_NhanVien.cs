using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace _162000128_162000244_De1_cuoiKy
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        private void Add_Item_cbGioiTinh()
        {
            cbGioiTinh.Items.Add("--- Chọn giới tính ---");
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Khác");
            cbGioiTinh.SelectedIndex = 0;
        }
        private void Add_Item_cbTrinhDo()
        {
            cbTrinhDo.Items.Add("--- Chọn trình độ ---");
            cbTrinhDo.Items.Add("12/12");
            cbTrinhDo.Items.Add("Trung cấp nghề");
            cbTrinhDo.Items.Add("Cao đẳng");
            cbTrinhDo.Items.Add("Đại học");
            cbTrinhDo.SelectedIndex = 0;
        }
        private void Add_Item_cbLoaiNV()
        {
            cbLoaiNV.Items.Add("--- Chọn loại nhân viên ---");
            cbLoaiNV.Items.Add("Quản lý");
            cbLoaiNV.Items.Add("Văn phòng");
            cbLoaiNV.Items.Add("Công nhân");
            cbLoaiNV.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && dtBirth.Text != "" && cbGioiTinh.Text != "" && cbTrinhDo.Text != "" && txtLuong.Text != "" && cbLoaiNV.Text != "")

            {
                DTO_NhanVien tv = new DTO_NhanVien(0, txtName.Text, dtBirth.Text, cbGioiTinh.Text, cbTrinhDo.Text, txtLuong.Text, cbLoaiNV.Text);

                if (busNV.themNhanVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvNV.DataSource = busNV.getNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                if (txtName.Text != "" && dtBirth.Text != "" && cbGioiTinh.Text != "" && cbTrinhDo.Text != "" && txtLuong.Text != "" && cbLoaiNV.Text != "")
                {
                    DataGridViewRow row = dgvNV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    DTO_NhanVien tv = new DTO_NhanVien(ID, txtName.Text, dtBirth.Text, cbGioiTinh.Text, cbTrinhDo.Text, txtLuong.Text, cbLoaiNV.Text);

                    if (busNV.suaNhanVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvNV.DataSource = busNV.getNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNV.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                if (busNV.xoaNhanVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNV.DataSource = busNV.getNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            Add_Item_cbLoaiNV();
            Add_Item_cbTrinhDo();
            Add_Item_cbGioiTinh();
            dgvNV.DataSource = busNV.getNhanVien();
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvNV.SelectedRows[0];

            // Chuyển giá trị lên form
            txtName.Text = row.Cells[1].Value.ToString();
            dtBirth.Text = row.Cells[2].Value.ToString();
            cbGioiTinh.Text = row.Cells[3].Value.ToString();
            cbTrinhDo.Text = row.Cells[4].Value.ToString();
            txtLuong.Text = row.Cells[5].Value.ToString();
            cbLoaiNV.Text = row.Cells[6].Value.ToString();
        }

        private void bttbC_Click(object sender, EventArgs e)
        {
            new BaoCaocs().Show();
        }
    }
}
