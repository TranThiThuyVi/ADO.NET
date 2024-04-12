using System;
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
    public partial class BaoCaocs : Form
    {
        public BaoCaocs()
        {
            InitializeComponent();
        }

        private void BaoCaocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanVienDataSet.Nhan_Vien1' table. You can move, or remove it, as needed.
            this.nhan_Vien1TableAdapter.Fill(this.quanLyNhanVienDataSet.Nhan_Vien1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
