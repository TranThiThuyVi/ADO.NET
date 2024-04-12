using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _162000128_162000244_De1_cuoiKy
{
    public partial class DangNhap : Form
    {
        Hashtable tk = new Hashtable();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            tk.Add("vanphong", "vanphong123");
            tk.Add("congnhan", "congnhan123");
            tk.Add("quanly", "quanly123");
        }

        private void bttOK_Click(object sender, EventArgs e)
        {
            if (tk.Contains(txtUserName.Text))
            {
                if (string.Compare(tk[txtUserName.Text].ToString(), txtPassword.Text) == 0)
                {
                    new GUI_NhanVien().Show();
                    this.Hide();
                    txtPassword.Clear();
                }
                else
                    lbThongBao.Text = "Mật khẩu không đúng";
            }
            else
                lbThongBao.Text = "Tài Khoản không tồn tại";
        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
