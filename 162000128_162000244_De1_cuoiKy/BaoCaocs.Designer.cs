namespace _162000128_162000244_De1_cuoiKy
{
    partial class BaoCaocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhanVien1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanVienDataSet = new _162000128_162000244_De1_cuoiKy.QuanLyNhanVienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyNhanVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVien1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhan_Vien1TableAdapter = new _162000128_162000244_De1_cuoiKy.QuanLyNhanVienDataSetTableAdapters.Nhan_Vien1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVien1BindingSource1
            // 
            this.nhanVien1BindingSource1.DataMember = "Nhan_Vien1";
            this.nhanVien1BindingSource1.DataSource = this.quanLyNhanVienDataSet;
            // 
            // quanLyNhanVienDataSet
            // 
            this.quanLyNhanVienDataSet.DataSetName = "QuanLyNhanVienDataSet";
            this.quanLyNhanVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanVien1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_162000128_162000244_De1_cuoiKy.BaoCao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 322);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // quanLyNhanVienDataSetBindingSource
            // 
            this.quanLyNhanVienDataSetBindingSource.DataSource = this.quanLyNhanVienDataSet;
            this.quanLyNhanVienDataSetBindingSource.Position = 0;
            // 
            // nhanVien1BindingSource
            // 
            this.nhanVien1BindingSource.DataMember = "Nhan_Vien1";
            this.nhanVien1BindingSource.DataSource = this.quanLyNhanVienDataSetBindingSource;
            // 
            // nhan_Vien1TableAdapter
            // 
            this.nhan_Vien1TableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaocs";
            this.Text = "BaoCaocs";
            this.Load += new System.EventHandler(this.BaoCaocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource quanLyNhanVienDataSetBindingSource;
        private QuanLyNhanVienDataSet quanLyNhanVienDataSet;
        private System.Windows.Forms.BindingSource nhanVien1BindingSource;
        private QuanLyNhanVienDataSetTableAdapters.Nhan_Vien1TableAdapter nhan_Vien1TableAdapter;
        private System.Windows.Forms.BindingSource nhanVien1BindingSource1;
    }
}