namespace QuanLyNhanSu.Forms
{
    partial class frmPhongBan
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
            MoTa = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            txtMoTa = new TextBox();
            btnHuyBo = new Button();
            label2 = new Label();
            btnLuu = new Button();
            txtMaPhong = new TextBox();
            btnSua = new Button();
            MaPhong = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            TenPhong = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label3 = new Label();
            btnXoa = new Button();
            label4 = new Label();
            btnThem = new Button();
            txtTenPhong = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(506, 145);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Top;
            txtMoTa.Location = new Point(118, 78);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(474, 27);
            txtMoTa.TabIndex = 5;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(414, 145);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Huỷ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(43, 23);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(321, 145);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Anchor = AnchorStyles.Top;
            txtMaPhong.Location = new Point(136, 17);
            txtMaPhong.Margin = new Padding(3, 4, 3, 4);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(114, 27);
            txtMaPhong.TabIndex = 1;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(229, 145);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "Id";
            MaPhong.HeaderText = "Mã phòng";
            MaPhong.MinimumWidth = 6;
            MaPhong.Name = "MaPhong";
            MaPhong.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 213);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 237);
            panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaPhong, TenPhong, MoTa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(657, 237);
            dataGridView.TabIndex = 0;
            // 
            // TenPhong
            // 
            TenPhong.DataPropertyName = "TenPhongBan";
            TenPhong.HeaderText = "Tên phòng";
            TenPhong.MinimumWidth = 6;
            TenPhong.Name = "TenPhong";
            TenPhong.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(txtMoTa);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtMaPhong);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenPhong);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 213);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(43, 82);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Mô tả";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(136, 145);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(321, 24);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên phòng";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = SystemColors.ControlLightLight;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(43, 145);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Anchor = AnchorStyles.Top;
            txtTenPhong.Location = new Point(414, 16);
            txtTenPhong.Margin = new Padding(3, 4, 3, 4);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(175, 27);
            txtTenPhong.TabIndex = 3;
            // 
            // frmPhongBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPhongBan";
            Text = "frmPhongBan";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn MoTa;
        private Button btnThoat;
        private TextBox txtMoTa;
        private Button btnHuyBo;
        private Label label2;
        private Button btnLuu;
        private TextBox txtMaPhong;
        private Button btnSua;
        private DataGridViewTextBoxColumn MaPhong;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenPhong;
        private Panel panel1;
        private Label label3;
        private Button btnXoa;
        private Label label4;
        private Button btnThem;
        private TextBox txtTenPhong;
    }
}