namespace QuanLyNhanSu.Forms
{
    partial class frmTaiKhoan
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
            label1 = new Label();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            btnThoat = new Button();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            HoTen = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnHuyBo = new Button();
            label3 = new Label();
            btnLuu = new Button();
            label4 = new Label();
            btnSua = new Button();
            label5 = new Label();
            btnXoa = new Button();
            label6 = new Label();
            btnThem = new Button();
            txtMaTaiKhoan = new TextBox();
            txtGhiChu = new TextBox();
            label7 = new Label();
            txtTenDangNhap = new TextBox();
            txtHoTen = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.Anchor = AnchorStyles.Top;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(140, 154);
            cboQuyenHan.Margin = new Padding(3, 4, 3, 4);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(159, 28);
            cboQuyenHan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top;
            txtMatKhau.Location = new Point(449, 89);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(159, 27);
            txtMatKhau.TabIndex = 9;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.BackColor = SystemColors.ControlLightLight;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(840, 161);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 224);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 226);
            panel2.TabIndex = 17;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoTen, TenDangNhap, MatKhau, QuyenHan, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(965, 226);
            dataGridView.TabIndex = 0;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(32, 35);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã tài khoản";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(840, 97);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Huỷ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(350, 37);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Họ và tên";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(840, 32);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(25, 89);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên đăng nhập";
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(694, 162);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(350, 154);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Ghi chú";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(694, 97);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(350, 93);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(694, 32);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Anchor = AnchorStyles.Top;
            txtMaTaiKhoan.Location = new Point(140, 28);
            txtMaTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(159, 27);
            txtMaTaiKhoan.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top;
            txtGhiChu.Location = new Point(449, 154);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(159, 27);
            txtGhiChu.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(25, 157);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Quyền hạn";
            label7.Click += label7_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Top;
            txtTenDangNhap.Location = new Point(140, 86);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(159, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top;
            txtHoTen.Location = new Point(449, 28);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(159, 27);
            txtHoTen.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(cboQuyenHan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtMaTaiKhoan);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(txtHoTen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 224);
            panel1.TabIndex = 16;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmTaiKhoan";
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private Button btnThoat;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn GhiChu;
        private Label label2;
        private Button btnHuyBo;
        private Label label3;
        private Button btnLuu;
        private Label label4;
        private Button btnSua;
        private Label label5;
        private Button btnXoa;
        private Label label6;
        private Button btnThem;
        private TextBox txtMaTaiKhoan;
        private TextBox txtGhiChu;
        private Label label7;
        private TextBox txtTenDangNhap;
        private TextBox txtHoTen;
        private Panel panel1;
    }
}