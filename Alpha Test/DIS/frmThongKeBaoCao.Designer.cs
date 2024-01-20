
namespace DIS
{
    partial class frmThongKeBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemNhap = new System.Windows.Forms.TextBox();
            this.dgvThongKeNhap = new System.Windows.Forms.DataGridView();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTongDoanhThuNhap = new System.Windows.Forms.Button();
            this.txtTongDoanhThuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiemNhap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemXuat = new System.Windows.Forms.TextBox();
            this.dgvThongKeXuat = new System.Windows.Forms.DataGridView();
            this.MaHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTongDoanhThuXuat = new System.Windows.Forms.Button();
            this.txtTongDoanhThuXuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiemXuat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê - Báo Cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiemNhap);
            this.groupBox1.Controls.Add(this.dgvThongKeNhap);
            this.groupBox1.Controls.Add(this.btnTongDoanhThuNhap);
            this.groupBox1.Controls.Add(this.txtTongDoanhThuNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTimKiemNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Thống kê Hóa Đơn Nhập";
            // 
            // txtTimKiemNhap
            // 
            this.txtTimKiemNhap.Location = new System.Drawing.Point(97, 24);
            this.txtTimKiemNhap.Name = "txtTimKiemNhap";
            this.txtTimKiemNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiemNhap.TabIndex = 22;
            // 
            // dgvThongKeNhap
            // 
            this.dgvThongKeNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDN,
            this.NgayNhap,
            this.NgayNhan,
            this.MaNV,
            this.MaKho,
            this.TrangThai,
            this.TongTien});
            this.dgvThongKeNhap.Location = new System.Drawing.Point(9, 93);
            this.dgvThongKeNhap.Name = "dgvThongKeNhap";
            this.dgvThongKeNhap.Size = new System.Drawing.Size(476, 298);
            this.dgvThongKeNhap.TabIndex = 21;
            // 
            // MaHDN
            // 
            this.MaHDN.DataPropertyName = "MaHDN";
            this.MaHDN.HeaderText = "Mã hóa đơn nhập";
            this.MaHDN.Name = "MaHDN";
            this.MaHDN.Width = 120;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // NgayNhan
            // 
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày nhận";
            this.NgayNhan.Name = "NgayNhan";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.HeaderText = "Mã kho";
            this.MaKho.Name = "MaKho";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // btnTongDoanhThuNhap
            // 
            this.btnTongDoanhThuNhap.Location = new System.Drawing.Point(304, 57);
            this.btnTongDoanhThuNhap.Name = "btnTongDoanhThuNhap";
            this.btnTongDoanhThuNhap.Size = new System.Drawing.Size(75, 20);
            this.btnTongDoanhThuNhap.TabIndex = 9;
            this.btnTongDoanhThuNhap.Text = "&Tổng";
            this.btnTongDoanhThuNhap.UseVisualStyleBackColor = true;
            this.btnTongDoanhThuNhap.Click += new System.EventHandler(this.btnTongDoanhThuNhap_Click);
            // 
            // txtTongDoanhThuNhap
            // 
            this.txtTongDoanhThuNhap.Location = new System.Drawing.Point(97, 57);
            this.txtTongDoanhThuNhap.Name = "txtTongDoanhThuNhap";
            this.txtTongDoanhThuNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTongDoanhThuNhap.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng doanh thu: ";
            // 
            // btnTimKiemNhap
            // 
            this.btnTimKiemNhap.Location = new System.Drawing.Point(304, 26);
            this.btnTimKiemNhap.Name = "btnTimKiemNhap";
            this.btnTimKiemNhap.Size = new System.Drawing.Size(75, 20);
            this.btnTimKiemNhap.TabIndex = 6;
            this.btnTimKiemNhap.Text = "&Tìm Kiếm ";
            this.btnTimKiemNhap.UseVisualStyleBackColor = true;
            this.btnTimKiemNhap.Click += new System.EventHandler(this.btnTimKiemNhap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiemXuat);
            this.groupBox2.Controls.Add(this.dgvThongKeXuat);
            this.groupBox2.Controls.Add(this.btnTongDoanhThuXuat);
            this.groupBox2.Controls.Add(this.txtTongDoanhThuXuat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTimKiemXuat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(514, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 401);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Thống kê Hóa Đơn Xuất";
            // 
            // txtTimKiemXuat
            // 
            this.txtTimKiemXuat.Location = new System.Drawing.Point(106, 26);
            this.txtTimKiemXuat.Name = "txtTimKiemXuat";
            this.txtTimKiemXuat.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiemXuat.TabIndex = 53;
            // 
            // dgvThongKeXuat
            // 
            this.dgvThongKeXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDX,
            this.NgayXuat,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvThongKeXuat.Location = new System.Drawing.Point(17, 93);
            this.dgvThongKeXuat.Name = "dgvThongKeXuat";
            this.dgvThongKeXuat.Size = new System.Drawing.Size(473, 298);
            this.dgvThongKeXuat.TabIndex = 52;
            // 
            // MaHDX
            // 
            this.MaHDX.DataPropertyName = "MaHDX";
            this.MaHDX.HeaderText = "Mã hóa đơn xuất";
            this.MaHDX.Name = "MaHDX";
            this.MaHDX.Width = 120;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NgayNhan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ngày nhận";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKho";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn4.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnTongDoanhThuXuat
            // 
            this.btnTongDoanhThuXuat.Location = new System.Drawing.Point(312, 53);
            this.btnTongDoanhThuXuat.Name = "btnTongDoanhThuXuat";
            this.btnTongDoanhThuXuat.Size = new System.Drawing.Size(75, 20);
            this.btnTongDoanhThuXuat.TabIndex = 10;
            this.btnTongDoanhThuXuat.Text = "&Tổng";
            this.btnTongDoanhThuXuat.UseVisualStyleBackColor = true;
            this.btnTongDoanhThuXuat.Click += new System.EventHandler(this.btnTongDoanhThuXuat_Click);
            // 
            // txtTongDoanhThuXuat
            // 
            this.txtTongDoanhThuXuat.Location = new System.Drawing.Point(106, 54);
            this.txtTongDoanhThuXuat.Name = "txtTongDoanhThuXuat";
            this.txtTongDoanhThuXuat.Size = new System.Drawing.Size(200, 20);
            this.txtTongDoanhThuXuat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng doanh thu: ";
            // 
            // btnTimKiemXuat
            // 
            this.btnTimKiemXuat.Location = new System.Drawing.Point(312, 24);
            this.btnTimKiemXuat.Name = "btnTimKiemXuat";
            this.btnTimKiemXuat.Size = new System.Drawing.Size(75, 20);
            this.btnTimKiemXuat.TabIndex = 7;
            this.btnTimKiemXuat.Text = "&Tìm Kiếm ";
            this.btnTimKiemXuat.UseVisualStyleBackColor = true;
            this.btnTimKiemXuat.Click += new System.EventHandler(this.btnTimKiemXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tìm kiếm: ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(916, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 38);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKeBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê - Báo Cáo";
            this.Load += new System.EventHandler(this.frmThongKeBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiemNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongDoanhThuNhap;
        private System.Windows.Forms.TextBox txtTongDoanhThuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTongDoanhThuXuat;
        private System.Windows.Forms.TextBox txtTongDoanhThuXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongKeXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvThongKeNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.TextBox txtTimKiemNhap;
        private System.Windows.Forms.TextBox txtTimKiemXuat;
    }
}