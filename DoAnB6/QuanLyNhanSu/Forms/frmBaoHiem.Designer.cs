namespace QuanLyNhanSu.Forms
{
    partial class frmBaoHiem
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
            panel2 = new Panel();
            dgvBaoHiem = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            LoaiBH = new DataGridViewTextBoxColumn();
            MucDong = new DataGridViewTextBoxColumn();
            MaBH = new DataGridViewTextBoxColumn();
            TyLeTrich = new DataGridViewTextBoxColumn();
            btnHuyBo = new Button();
            btnLuu = new Button();
            label4 = new Label();
            btnSua = new Button();
            txtMaBaoHiem = new TextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            label2 = new Label();
            btnThem = new Button();
            txtTenBaoHiem = new TextBox();
            txtLoaiBH = new TextBox();
            panel1 = new Panel();
            btnExcel = new Button();
            label3 = new Label();
            numMucDong = new NumericUpDown();
            cboNhanVien = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoHiem).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMucDong).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBaoHiem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 450);
            panel2.TabIndex = 2;
            // 
            // dgvBaoHiem
            // 
            dgvBaoHiem.AllowUserToAddRows = false;
            dgvBaoHiem.AllowUserToDeleteRows = false;
            dgvBaoHiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoHiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoHiem.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, LoaiBH, MucDong });
            dgvBaoHiem.Dock = DockStyle.Fill;
            dgvBaoHiem.Location = new Point(0, 0);
            dgvBaoHiem.Margin = new Padding(3, 4, 3, 4);
            dgvBaoHiem.MultiSelect = false;
            dgvBaoHiem.Name = "dgvBaoHiem";
            dgvBaoHiem.ReadOnly = true;
            dgvBaoHiem.RowHeadersWidth = 51;
            dgvBaoHiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoHiem.Size = new Size(430, 450);
            dgvBaoHiem.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "TenNV";
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // LoaiBH
            // 
            LoaiBH.DataPropertyName = "LoaiBH";
            LoaiBH.HeaderText = "Loại bảo hiểm";
            LoaiBH.MinimumWidth = 6;
            LoaiBH.Name = "LoaiBH";
            LoaiBH.ReadOnly = true;
            // 
            // MucDong
            // 
            MucDong.DataPropertyName = "MucDong";
            MucDong.HeaderText = "Số tiền đóng";
            MucDong.MinimumWidth = 6;
            MucDong.Name = "MucDong";
            MucDong.ReadOnly = true;
            // 
            // MaBH
            // 
            MaBH.DataPropertyName = "Id";
            MaBH.HeaderText = "Mã bảo hiểm";
            MaBH.MinimumWidth = 6;
            MaBH.Name = "MaBH";
            MaBH.ReadOnly = true;
            MaBH.Width = 125;
            // 
            // TyLeTrich
            // 
            TyLeTrich.DataPropertyName = "TyLeTrich";
            TyLeTrich.HeaderText = "Tỷ lệ trích";
            TyLeTrich.MinimumWidth = 6;
            TyLeTrich.Name = "TyLeTrich";
            TyLeTrich.ReadOnly = true;
            TyLeTrich.Width = 125;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(197, 352);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 31);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Huỷ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(197, 294);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 31);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(20, 63);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã bảo hiểm";
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(70, 406);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 31);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // txtMaBaoHiem
            // 
            txtMaBaoHiem.Anchor = AnchorStyles.Top;
            txtMaBaoHiem.BackColor = SystemColors.ButtonHighlight;
            txtMaBaoHiem.Location = new Point(153, 56);
            txtMaBaoHiem.Margin = new Padding(3, 4, 3, 4);
            txtMaBaoHiem.Name = "txtMaBaoHiem";
            txtMaBaoHiem.ReadOnly = true;
            txtMaBaoHiem.Size = new Size(150, 27);
            txtMaBaoHiem.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(70, 352);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 31);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.BackColor = SystemColors.ControlLightLight;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(197, 406);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 31);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(20, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên bảo hiểm";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(70, 294);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenBaoHiem
            // 
            txtTenBaoHiem.Anchor = AnchorStyles.Top;
            txtTenBaoHiem.Location = new Point(153, 106);
            txtTenBaoHiem.Margin = new Padding(3, 4, 3, 4);
            txtTenBaoHiem.Name = "txtTenBaoHiem";
            txtTenBaoHiem.Size = new Size(149, 27);
            txtTenBaoHiem.TabIndex = 3;
            // 
            // txtLoaiBH
            // 
            txtLoaiBH.Anchor = AnchorStyles.Top;
            txtLoaiBH.Location = new Point(153, 157);
            txtLoaiBH.Margin = new Padding(3, 4, 3, 4);
            txtLoaiBH.Name = "txtLoaiBH";
            txtLoaiBH.Size = new Size(149, 27);
            txtLoaiBH.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numMucDong);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLoaiBH);
            panel1.Controls.Add(txtTenBaoHiem);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtMaBaoHiem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnHuyBo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(430, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 450);
            panel1.TabIndex = 3;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Top;
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(196, 245);
            btnExcel.Margin = new Padding(3, 4, 3, 4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(106, 31);
            btnExcel.TabIndex = 17;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(20, 209);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 16;
            label3.Text = "Mức đóng (VNĐ)";
            // 
            // numMucDong
            // 
            numMucDong.Location = new Point(153, 202);
            numMucDong.Name = "numMucDong";
            numMucDong.Size = new Size(150, 27);
            numMucDong.TabIndex = 15;
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(153, 12);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(149, 28);
            cboNhanVien.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(22, 160);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "Loại bảo hiểm";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Nhân viên";
            // 
            // frmBaoHiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmBaoHiem";
            Text = "frmBaoHiem";
            Load += frmBaoHiem_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoHiem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMucDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvBaoHiem;
        private DataGridViewTextBoxColumn MaBH;
        private DataGridViewTextBoxColumn TyLeTrich;
        private Button btnHuyBo;
        private Button btnLuu;
        private Label label4;
        private Button btnSua;
        private TextBox txtMaBaoHiem;
        private Button btnXoa;
        private Button btnThoat;
        private Label label2;
        private Button btnThem;
        private TextBox txtTenBaoHiem;
        private TextBox txtLoaiBH;
        private Panel panel1;
        private TextBox t;
        private Label label1;
        private Label label5;
        private NumericUpDown numMucDong;
        private ComboBox cboNhanVien;
        private Label label3;
        private Button btnExcel;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn LoaiBH;
        private DataGridViewTextBoxColumn MucDong;
    }
}