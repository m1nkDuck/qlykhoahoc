
namespace GUI
{
    partial class GUI_HV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxLichHoc = new System.Windows.Forms.GroupBox();
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.gbxLichThi = new System.Windows.Forms.GroupBox();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.valdiachi = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.valSDT = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.valNgaySinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.valGioiTinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.valTen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.valMaHV = new System.Windows.Forms.Label();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbxLichHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.gbxLichThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.gbxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Controls.Add(this.btnDangXuat);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1140, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(1000, 20);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 40);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ HỌC VIÊN";
            // 
            // gbxLichHoc
            // 
            this.gbxLichHoc.BackColor = System.Drawing.Color.White;
            this.gbxLichHoc.Controls.Add(this.dgvLichHoc);
            this.gbxLichHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLichHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxLichHoc.Location = new System.Drawing.Point(20, 100);
            this.gbxLichHoc.Name = "gbxLichHoc";
            this.gbxLichHoc.Padding = new System.Windows.Forms.Padding(10);
            this.gbxLichHoc.Size = new System.Drawing.Size(700, 330);
            this.gbxLichHoc.TabIndex = 1;
            this.gbxLichHoc.TabStop = false;
            this.gbxLichHoc.Text = "Lịch Học";
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            this.dgvLichHoc.AllowUserToDeleteRows = false;
            this.dgvLichHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.Location = new System.Drawing.Point(10, 37);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.ReadOnly = true;
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.Size = new System.Drawing.Size(680, 283);
            this.dgvLichHoc.TabIndex = 0;
            // 
            // gbxLichThi
            // 
            this.gbxLichThi.BackColor = System.Drawing.Color.White;
            this.gbxLichThi.Controls.Add(this.dgvLichThi);
            this.gbxLichThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLichThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxLichThi.Location = new System.Drawing.Point(20, 450);
            this.gbxLichThi.Name = "gbxLichThi";
            this.gbxLichThi.Padding = new System.Windows.Forms.Padding(10);
            this.gbxLichThi.Size = new System.Drawing.Size(700, 350);
            this.gbxLichThi.TabIndex = 2;
            this.gbxLichThi.TabStop = false;
            this.gbxLichThi.Text = "Lịch Thi";
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AllowUserToAddRows = false;
            this.dgvLichThi.AllowUserToDeleteRows = false;
            this.dgvLichThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichThi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichThi.Location = new System.Drawing.Point(10, 37);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.ReadOnly = true;
            this.dgvLichThi.RowHeadersWidth = 51;
            this.dgvLichThi.Size = new System.Drawing.Size(680, 303);
            this.dgvLichThi.TabIndex = 0;
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.BackColor = System.Drawing.Color.White;
            this.gbxThongTin.Controls.Add(this.valdiachi);
            this.gbxThongTin.Controls.Add(this.lbldiachi);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Controls.Add(this.valEmail);
            this.gbxThongTin.Controls.Add(this.lblEmail);
            this.gbxThongTin.Controls.Add(this.valSDT);
            this.gbxThongTin.Controls.Add(this.lblSDT);
            this.gbxThongTin.Controls.Add(this.valNgaySinh);
            this.gbxThongTin.Controls.Add(this.lblNgaySinh);
            this.gbxThongTin.Controls.Add(this.valGioiTinh);
            this.gbxThongTin.Controls.Add(this.lblGioiTinh);
            this.gbxThongTin.Controls.Add(this.valTen);
            this.gbxThongTin.Controls.Add(this.lblTen);
            this.gbxThongTin.Controls.Add(this.valMaHV);
            this.gbxThongTin.Controls.Add(this.lblMaHV);
            this.gbxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxThongTin.Location = new System.Drawing.Point(740, 100);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(380, 330);
            this.gbxThongTin.TabIndex = 3;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông Tin Học Viên";
            this.gbxThongTin.Enter += new System.EventHandler(this.gbxThongTin_Enter);
            // 
            // valdiachi
            // 
            this.valdiachi.AutoSize = true;
            this.valdiachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valdiachi.ForeColor = System.Drawing.Color.Black;
            this.valdiachi.Location = new System.Drawing.Point(140, 213);
            this.valdiachi.Name = "valdiachi";
            this.valdiachi.Size = new System.Drawing.Size(27, 25);
            this.valdiachi.TabIndex = 14;
            this.valdiachi.Text = "...";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.Gray;
            this.lbldiachi.Location = new System.Drawing.Point(20, 213);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(70, 25);
            this.lbldiachi.TabIndex = 13;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 12;
            // 
            // valEmail
            // 
            this.valEmail.AutoSize = true;
            this.valEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valEmail.ForeColor = System.Drawing.Color.Black;
            this.valEmail.Location = new System.Drawing.Point(140, 279);
            this.valEmail.Name = "valEmail";
            this.valEmail.Size = new System.Drawing.Size(27, 25);
            this.valEmail.TabIndex = 0;
            this.valEmail.Text = "...";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(29, 279);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // valSDT
            // 
            this.valSDT.AutoSize = true;
            this.valSDT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSDT.ForeColor = System.Drawing.Color.Black;
            this.valSDT.Location = new System.Drawing.Point(140, 254);
            this.valSDT.Name = "valSDT";
            this.valSDT.Size = new System.Drawing.Size(27, 25);
            this.valSDT.TabIndex = 2;
            this.valSDT.Text = "...";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Gray;
            this.lblSDT.Location = new System.Drawing.Point(6, 254);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(127, 25);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // valNgaySinh
            // 
            this.valNgaySinh.AutoSize = true;
            this.valNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.valNgaySinh.Location = new System.Drawing.Point(140, 170);
            this.valNgaySinh.Name = "valNgaySinh";
            this.valNgaySinh.Size = new System.Drawing.Size(27, 25);
            this.valNgaySinh.TabIndex = 4;
            this.valNgaySinh.Text = "...";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Gray;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 170);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 25);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // valGioiTinh
            // 
            this.valGioiTinh.AutoSize = true;
            this.valGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.valGioiTinh.Location = new System.Drawing.Point(140, 130);
            this.valGioiTinh.Name = "valGioiTinh";
            this.valGioiTinh.Size = new System.Drawing.Size(27, 25);
            this.valGioiTinh.TabIndex = 6;
            this.valGioiTinh.Text = "...";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Gray;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 130);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(88, 25);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // valTen
            // 
            this.valTen.AutoSize = true;
            this.valTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTen.ForeColor = System.Drawing.Color.Black;
            this.valTen.Location = new System.Drawing.Point(140, 90);
            this.valTen.Name = "valTen";
            this.valTen.Size = new System.Drawing.Size(27, 25);
            this.valTen.TabIndex = 8;
            this.valTen.Text = "...";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Gray;
            this.lblTen.Location = new System.Drawing.Point(20, 90);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(96, 25);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Họ và tên:";
            // 
            // valMaHV
            // 
            this.valMaHV.AutoSize = true;
            this.valMaHV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMaHV.ForeColor = System.Drawing.Color.Black;
            this.valMaHV.Location = new System.Drawing.Point(140, 50);
            this.valMaHV.Name = "valMaHV";
            this.valMaHV.Size = new System.Drawing.Size(27, 25);
            this.valMaHV.TabIndex = 10;
            this.valMaHV.Text = "...";
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHV.ForeColor = System.Drawing.Color.Gray;
            this.lblMaHV.Location = new System.Drawing.Point(20, 50);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(119, 25);
            this.lblMaHV.TabIndex = 11;
            this.lblMaHV.Text = "Mã học viên:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(740, 450);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(380, 50);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(740, 520);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(380, 50);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "TRA CỨU KẾT QUẢ HỌC TẬP";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // GUI_HV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1140, 825);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.gbxLichThi);
            this.Controls.Add(this.gbxLichHoc);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_HV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ Học Viên";
            this.Load += new System.EventHandler(this.GUI_HV_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbxLichHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.gbxLichThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox gbxLichHoc;
        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.GroupBox gbxLichThi;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.Label valMaHV;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label valTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label valGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label valNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label valSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label valEmail;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label valdiachi;
    }
}