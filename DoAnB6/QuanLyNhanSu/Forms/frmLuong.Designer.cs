namespace QuanLyNhanSu.Forms
{
    partial class frmLuong
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
            HeSoLuong = new DataGridViewTextBoxColumn();
            ThangNam = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            LuongCoBan = new DataGridViewTextBoxColumn();
            cboMaNhanVien = new ComboBox();
            btnImport = new Button();
            txtHeSoLuong = new TextBox();
            btnExport = new Button();
            dtpThangNam = new DateTimePicker();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThoat = new Button();
            label5 = new Label();
            btnHuyBo = new Button();
            label6 = new Label();
            btnLuu = new Button();
            txtMaLuong = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            label7 = new Label();
            btnThem = new Button();
            txtLuongCoBan = new TextBox();
            txtHoTen = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // HeSoLuong
            // 
            HeSoLuong.DataPropertyName = "HeSoLuong";
            HeSoLuong.HeaderText = "Hệ số lương";
            HeSoLuong.MinimumWidth = 6;
            HeSoLuong.Name = "HeSoLuong";
            HeSoLuong.ReadOnly = true;
            // 
            // ThangNam
            // 
            ThangNam.DataPropertyName = "ThangNam";
            ThangNam.HeaderText = "Tháng năm";
            ThangNam.MinimumWidth = 6;
            ThangNam.Name = "ThangNam";
            ThangNam.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 206);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 250);
            panel2.TabIndex = 17;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, ThangNam, LuongCoBan, HeSoLuong });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(738, 250);
            dataGridView.TabIndex = 0;
            // 
            // LuongCoBan
            // 
            LuongCoBan.DataPropertyName = "LuongCoBan";
            LuongCoBan.HeaderText = "Lương cơ bản";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            LuongCoBan.ReadOnly = true;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(120, 78);
            cboMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(115, 28);
            cboMaNhanVien.TabIndex = 20;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(631, 144);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(86, 31);
            btnImport.TabIndex = 19;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // txtHeSoLuong
            // 
            txtHeSoLuong.Anchor = AnchorStyles.Top;
            txtHeSoLuong.Location = new Point(382, 79);
            txtHeSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtHeSoLuong.Name = "txtHeSoLuong";
            txtHeSoLuong.Size = new Size(115, 27);
            txtHeSoLuong.TabIndex = 9;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(539, 144);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(86, 31);
            btnExport.TabIndex = 18;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // dtpThangNam
            // 
            dtpThangNam.Anchor = AnchorStyles.Top;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.Location = new Point(382, 133);
            dtpThangNam.Margin = new Padding(3, 4, 3, 4);
            dtpThangNam.Name = "dtpThangNam";
            dtpThangNam.Size = new Size(115, 27);
            dtpThangNam.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(cboMaNhanVien);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(txtHeSoLuong);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpThangNam);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtMaLuong);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtLuongCoBan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 206);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lương";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(17, 82);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(260, 27);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 6;
            label4.Text = "Lương cơ bản";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.BackColor = SystemColors.ButtonHighlight;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(631, 102);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(17, 144);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Họ và tên";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.BackColor = SystemColors.ButtonHighlight;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(631, 63);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "Huỷ ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(260, 82);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 8;
            label6.Text = "Hệ số lương";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.BackColor = SystemColors.ButtonHighlight;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(631, 24);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // txtMaLuong
            // 
            txtMaLuong.Anchor = AnchorStyles.Top;
            txtMaLuong.Location = new Point(120, 20);
            txtMaLuong.Margin = new Padding(3, 4, 3, 4);
            txtMaLuong.Name = "txtMaLuong";
            txtMaLuong.Size = new Size(115, 27);
            txtMaLuong.TabIndex = 1;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.BackColor = SystemColors.ButtonHighlight;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(539, 102);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.BackColor = SystemColors.ButtonHighlight;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(539, 63);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(267, 140);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 10;
            label7.Text = "Tháng năm";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = SystemColors.ButtonHighlight;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(539, 24);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Anchor = AnchorStyles.Top;
            txtLuongCoBan.Location = new Point(382, 20);
            txtLuongCoBan.Margin = new Padding(3, 4, 3, 4);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(115, 27);
            txtLuongCoBan.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top;
            txtHoTen.Location = new Point(120, 137);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(115, 27);
            txtHoTen.TabIndex = 21;
            // 
            // frmLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 456);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmLuong";
            Text = "frmLuong";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridViewTextBoxColumn HeSoLuong;
        private DataGridViewTextBoxColumn ThangNam;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MaNhanVien;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn LuongCoBan;
        private ComboBox cboMaNhanVien;
        private Button btnImport;
        private TextBox txtHeSoLuong;
        private Button btnExport;
        private DateTimePicker dtpThangNam;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThoat;
        private Label label5;
        private Button btnHuyBo;
        private Label label6;
        private Button btnLuu;
        private TextBox txtMaLuong;
        private Button btnSua;
        private Button btnXoa;
        private Label label7;
        private Button btnThem;
        private TextBox txtLuongCoBan;
        private TextBox txtHoTen;
    }
}