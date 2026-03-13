namespace QuanLyNhanSu.Forms
{
    partial class frmNhanVien
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
            components = new System.ComponentModel.Container();
            NgayVaoLam = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            btnTim = new Button();
            txtCCCD = new TextBox();
            btnImport = new Button();
            picHinhAnh = new PictureBox();
            btnXuat = new Button();
            label2 = new Label();
            btnDoiAnh = new Button();
            label4 = new Label();
            txtPath = new TextBox();
            NgaySinh = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnThoat = new Button();
            label3 = new Label();
            btnHuyBo = new Button();
            CMND = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            label9 = new Label();
            bindingSource1 = new BindingSource(components);
            btnLuu = new Button();
            label6 = new Label();
            btnSua = new Button();
            label7 = new Label();
            btnXoa = new Button();
            label10 = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            PhongBan = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            btnThem = new Button();
            label8 = new Label();
            cboChucVu = new ComboBox();
            txtMaNV = new TextBox();
            cboPhongBan = new ComboBox();
            txtTim = new TextBox();
            dtpNgayVaoLam = new DateTimePicker();
            label11 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            panel1 = new Panel();
            txtGioiTinh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NgayVaoLam
            // 
            NgayVaoLam.DataPropertyName = "NgayVaoLam";
            NgayVaoLam.HeaderText = "Ngày vào làm";
            NgayVaoLam.MinimumWidth = 6;
            NgayVaoLam.Name = "NgayVaoLam";
            NgayVaoLam.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top;
            btnTim.BackColor = SystemColors.ControlLight;
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(674, 125);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(89, 31);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm kiếm";
            btnTim.TextAlign = ContentAlignment.MiddleRight;
            btnTim.UseVisualStyleBackColor = false;
            // 
            // txtCCCD
            // 
            txtCCCD.Anchor = AnchorStyles.Top;
            txtCCCD.Location = new Point(524, 126);
            txtCCCD.Margin = new Padding(3, 4, 3, 4);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(114, 27);
            txtCCCD.TabIndex = 13;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top;
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.Location = new Point(761, 217);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(69, 31);
            btnImport.TabIndex = 31;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top;
            picHinhAnh.BackColor = SystemColors.HighlightText;
            picHinhAnh.Location = new Point(34, 33);
            picHinhAnh.Margin = new Padding(3, 4, 3, 4);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(114, 137);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 1;
            picHinhAnh.TabStop = false;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(686, 217);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(69, 31);
            btnXuat.TabIndex = 30;
            btnXuat.Text = "Export";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(183, 33);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "MaNV";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top;
            btnDoiAnh.Location = new Point(34, 217);
            btnDoiAnh.Margin = new Padding(3, 4, 3, 4);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(114, 31);
            btnDoiAnh.TabIndex = 23;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(183, 81);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Họ tên";
            // 
            // txtPath
            // 
            txtPath.Anchor = AnchorStyles.Top;
            txtPath.Location = new Point(34, 178);
            txtPath.Margin = new Padding(3, 4, 3, 4);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(114, 27);
            txtPath.TabIndex = 22;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "SoDienThoai";
            DienThoai.HeaderText = "Số điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(416, 33);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Giới tính";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.BackColor = SystemColors.ButtonHighlight;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(614, 217);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 31);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.UseWaitCursor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(183, 185);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 6;
            label3.Text = "SĐT";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(542, 217);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(65, 31);
            btnHuyBo.TabIndex = 28;
            btnHuyBo.Text = "Huỷ ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // CMND
            // 
            CMND.DataPropertyName = "CMND";
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.ReadOnly = true;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "Id";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(674, 33);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 16;
            label9.Text = "Phòng ban";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(470, 217);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(65, 31);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(416, 81);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày sinh";
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(398, 217);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(65, 31);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(183, 130);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 4;
            label7.Text = "Địa chỉ";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(326, 217);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(65, 31);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xoá";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(674, 81);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 18;
            label10.Text = "Chức vụ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 272);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 263);
            panel2.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTen, DiaChi, DienThoai, NgaySinh, GioiTinh, CMND, NgayVaoLam, PhongBan, ChucVu, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(957, 263);
            dataGridView.TabIndex = 0;
            // 
            // PhongBan
            // 
            PhongBan.DataPropertyName = "PhongBan";
            PhongBan.HeaderText = "Phòng ban";
            PhongBan.MinimumWidth = 6;
            PhongBan.Name = "PhongBan";
            PhongBan.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = SystemColors.ButtonHighlight;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(254, 217);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(65, 31);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(416, 178);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 14;
            label8.Text = "Ngày vào làm";
            // 
            // cboChucVu
            // 
            cboChucVu.Anchor = AnchorStyles.Top;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(787, 77);
            cboChucVu.Margin = new Padding(3, 4, 3, 4);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(114, 28);
            cboChucVu.TabIndex = 19;
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Top;
            txtMaNV.Location = new Point(254, 29);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(114, 27);
            txtMaNV.TabIndex = 1;
            // 
            // cboPhongBan
            // 
            cboPhongBan.Anchor = AnchorStyles.Top;
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(787, 29);
            cboPhongBan.Margin = new Padding(3, 4, 3, 4);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(114, 28);
            cboPhongBan.TabIndex = 17;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Top;
            txtTim.Location = new Point(787, 125);
            txtTim.Margin = new Padding(3, 4, 3, 4);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(114, 27);
            txtTim.TabIndex = 21;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Anchor = AnchorStyles.Top;
            dtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            dtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtpNgayVaoLam.Location = new Point(524, 174);
            dtpNgayVaoLam.Margin = new Padding(3, 4, 3, 4);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(114, 27);
            dtpNgayVaoLam.TabIndex = 15;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(416, 130);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 12;
            label11.Text = "CCCD";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(524, 77);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(114, 27);
            dtpNgaySinh.TabIndex = 11;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top;
            txtHoTen.Location = new Point(254, 77);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(114, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Anchor = AnchorStyles.Top;
            txtDienThoai.Location = new Point(254, 174);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(114, 27);
            txtDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.Location = new Point(254, 126);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(114, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(picHinhAnh);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDoiAnh);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPath);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cboChucVu);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(cboPhongBan);
            panel1.Controls.Add(txtTim);
            panel1.Controls.Add(dtpNgayVaoLam);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtDienThoai);
            panel1.Controls.Add(txtGioiTinh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 272);
            panel1.TabIndex = 3;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Anchor = AnchorStyles.Top;
            txtGioiTinh.Location = new Point(524, 29);
            txtGioiTinh.Margin = new Padding(3, 4, 3, 4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(114, 27);
            txtGioiTinh.TabIndex = 9;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 535);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn NgayVaoLam;
        private DataGridViewTextBoxColumn GioiTinh;
        private Button btnTim;
        private TextBox txtCCCD;
        private Button btnImport;
        private PictureBox picHinhAnh;
        private Button btnXuat;
        private Label label2;
        private Button btnDoiAnh;
        private Label label4;
        private TextBox txtPath;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn HoTen;
        private Label label5;
        private Button btnThoat;
        private Label label3;
        private Button btnHuyBo;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn MaNV;
        private Label label9;
        private BindingSource bindingSource1;
        private Button btnLuu;
        private Label label6;
        private Button btnSua;
        private Label label7;
        private Button btnXoa;
        private Label label10;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn PhongBan;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewImageColumn HinhAnh;
        private Button btnThem;
        private Label label8;
        private ComboBox cboChucVu;
        private TextBox txtMaNV;
        private ComboBox cboPhongBan;
        private TextBox txtTim;
        private DateTimePicker dtpNgayVaoLam;
        private Label label11;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Panel panel1;
        private TextBox txtGioiTinh;
    }
}