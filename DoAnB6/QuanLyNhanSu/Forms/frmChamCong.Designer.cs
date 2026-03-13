namespace QuanLyNhanSu.Forms
{
    partial class frmChamCong
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
            panel2 = new Panel();
            dataGridView = new DataGridView();
            MaChamCong = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Ngay = new DataGridViewTextBoxColumn();
            GioVao = new DataGridViewTextBoxColumn();
            GioRa = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewComboBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            btnthoat = new Button();
            dtpGioRa = new DateTimePicker();
            btnLuu = new Button();
            label2 = new Label();
            btnHuy = new Button();
            label4 = new Label();
            btnCapNhat = new Button();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtGhiChu = new TextBox();
            cboTrangThai = new ComboBox();
            label8 = new Label();
            txtMaChamCong = new TextBox();
            label11 = new Label();
            cboMaNhanVien = new ComboBox();
            label5 = new Label();
            dtpGioVao = new DateTimePicker();
            panel1 = new Panel();
            dtpNgayLam = new DateTimePicker();
            txtHoTen = new TextBox();
            btnExport = new Button();
            btnImport = new Button();
            label3 = new Label();
            dtpChonNgay = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 212);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 392);
            panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaChamCong, MaNhanVien, HoTen, Ngay, GioVao, GioRa, TrangThai, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(755, 392);
            dataGridView.TabIndex = 0;
            // 
            // MaChamCong
            // 
            MaChamCong.DataPropertyName = "(none)Id";
            MaChamCong.HeaderText = "Mã chấm công";
            MaChamCong.MinimumWidth = 6;
            MaChamCong.Name = "MaChamCong";
            MaChamCong.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // Ngay
            // 
            Ngay.DataPropertyName = "Ngay";
            Ngay.HeaderText = "Ngày làm";
            Ngay.MinimumWidth = 6;
            Ngay.Name = "Ngay";
            Ngay.ReadOnly = true;
            // 
            // GioVao
            // 
            GioVao.DataPropertyName = "GioVao";
            GioVao.HeaderText = "Giờ vào";
            GioVao.MinimumWidth = 6;
            GioVao.Name = "GioVao";
            GioVao.ReadOnly = true;
            GioVao.Resizable = DataGridViewTriState.True;
            GioVao.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GioRa
            // 
            GioRa.DataPropertyName = "GioRa";
            GioRa.HeaderText = "Giờ ra";
            GioRa.MinimumWidth = 6;
            GioRa.Name = "GioRa";
            GioRa.ReadOnly = true;
            GioRa.Resizable = DataGridViewTriState.True;
            GioRa.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // btnthoat
            // 
            btnthoat.Anchor = AnchorStyles.Top;
            btnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnthoat.Location = new Point(625, 157);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(86, 31);
            btnthoat.TabIndex = 21;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // dtpGioRa
            // 
            dtpGioRa.Anchor = AnchorStyles.Top;
            dtpGioRa.CustomFormat = "HH:mm";
            dtpGioRa.Format = DateTimePickerFormat.Custom;
            dtpGioRa.Location = new Point(382, 111);
            dtpGioRa.Margin = new Padding(3, 4, 3, 4);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.Size = new Size(109, 27);
            dtpGioRa.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(509, 157);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(37, 71);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã nhân viên";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(393, 159);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(86, 31);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(37, 113);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ và tên";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top;
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(273, 159);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(86, 31);
            btnCapNhat.TabIndex = 18;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.MiddleRight;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(286, 71);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "Giờ vào";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(527, 26);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 12;
            label9.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(286, 113);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 10;
            label7.Text = "Giờ ra";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top;
            txtGhiChu.Location = new Point(614, 68);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(109, 27);
            txtGhiChu.TabIndex = 15;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Top;
            cboTrangThai.Location = new Point(614, 21);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(109, 28);
            cboTrangThai.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(527, 71);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 14;
            label8.Text = "Ghi chú";
            label8.Click += label8_Click;
            // 
            // txtMaChamCong
            // 
            txtMaChamCong.Anchor = AnchorStyles.Top;
            txtMaChamCong.Location = new Point(148, 17);
            txtMaChamCong.Margin = new Padding(3, 4, 3, 4);
            txtMaChamCong.Name = "txtMaChamCong";
            txtMaChamCong.Size = new Size(97, 27);
            txtMaChamCong.TabIndex = 1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(37, 29);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 0;
            label11.Text = "Mã chấm công";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.Anchor = AnchorStyles.Top;
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(148, 67);
            cboMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(97, 28);
            cboMaNhanVien.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(286, 27);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 6;
            label5.Text = "Ngày làm";
            // 
            // dtpGioVao
            // 
            dtpGioVao.Anchor = AnchorStyles.Top;
            dtpGioVao.CustomFormat = "HH:mm";
            dtpGioVao.Format = DateTimePickerFormat.Custom;
            dtpGioVao.Location = new Point(382, 68);
            dtpGioVao.Margin = new Padding(3, 4, 3, 4);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.Size = new Size(109, 27);
            dtpGioVao.TabIndex = 9;
            dtpGioVao.ValueChanged += dtpGioVao_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(dtpChonNgay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(dtpGioRa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cboTrangThai);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMaChamCong);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cboMaNhanVien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpGioVao);
            panel1.Controls.Add(dtpNgayLam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 212);
            panel1.TabIndex = 2;
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.Anchor = AnchorStyles.Top;
            dtpNgayLam.CustomFormat = "dd/MM/yyyy";
            dtpNgayLam.Format = DateTimePickerFormat.Custom;
            dtpNgayLam.Location = new Point(382, 21);
            dtpNgayLam.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.Size = new Size(109, 27);
            dtpNgayLam.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top;
            txtHoTen.Location = new Point(148, 113);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(97, 27);
            txtHoTen.TabIndex = 22;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(37, 159);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(86, 31);
            btnExport.TabIndex = 23;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(159, 159);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(86, 31);
            btnImport.TabIndex = 24;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(527, 113);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 25;
            label3.Text = "Xem tháng";
            // 
            // dtpChonNgay
            // 
            dtpChonNgay.Anchor = AnchorStyles.Top;
            dtpChonNgay.CustomFormat = "dd/MM/yyyy";
            dtpChonNgay.Format = DateTimePickerFormat.Custom;
            dtpChonNgay.Location = new Point(614, 111);
            dtpChonNgay.Margin = new Padding(3, 4, 3, 4);
            dtpChonNgay.Name = "dtpChonNgay";
            dtpChonNgay.Size = new Size(109, 27);
            dtpChonNgay.TabIndex = 26;
            // 
            // frmChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 604);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmChamCong";
            Text = "frmChamCong";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaChamCong;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn GioVao;
        private DataGridViewTextBoxColumn GioRa;
        private DataGridViewComboBoxColumn TrangThai;
        private DataGridViewTextBoxColumn GhiChu;
        private Button btnthoat;
        private DateTimePicker dtpGioRa;
        private Button btnLuu;
        private Label label2;
        private Button btnHuy;
        private Label label4;
        private Button btnCapNhat;
        private Label label6;
        private Label label9;
        private Label label7;
        private TextBox txtGhiChu;
        private ComboBox cboTrangThai;
        private Label label8;
        private TextBox txtMaChamCong;
        private Label label11;
        private ComboBox cboMaNhanVien;
        private Label label5;
        private DateTimePicker dtpGioVao;
        private Panel panel1;
        private DateTimePicker dtpNgayLam;
        private Button btnImport;
        private Button btnExport;
        private TextBox txtHoTen;
        private DateTimePicker dtpChonNgay;
        private Label label3;
    }
}