
namespace GUI
{
    partial class GUI_GV
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
            this.gbxLichDay = new System.Windows.Forms.GroupBox();
            this.dgvLichDay = new System.Windows.Forms.DataGridView();
            this.gbxLichThi = new System.Windows.Forms.GroupBox();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.valNgoaiNgu = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.valTrinhDo = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.valEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.valSDT = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.valGioiTinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.valTen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.valMaGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.btnChamDiem = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbxLichDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).BeginInit();
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ GIẢNG VIÊN";
            // 
            // gbxLichDay
            // 
            this.gbxLichDay.BackColor = System.Drawing.Color.White;
            this.gbxLichDay.Controls.Add(this.dgvLichDay);
            this.gbxLichDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLichDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxLichDay.Location = new System.Drawing.Point(20, 100);
            this.gbxLichDay.Name = "gbxLichDay";
            this.gbxLichDay.Padding = new System.Windows.Forms.Padding(10);
            this.gbxLichDay.Size = new System.Drawing.Size(700, 330);
            this.gbxLichDay.TabIndex = 1;
            this.gbxLichDay.TabStop = false;
            this.gbxLichDay.Text = "Lịch Dạy";
            // 
            // dgvLichDay
            // 
            this.dgvLichDay.AllowUserToAddRows = false;
            this.dgvLichDay.AllowUserToDeleteRows = false;
            this.dgvLichDay.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichDay.Location = new System.Drawing.Point(10, 32);
            this.dgvLichDay.Name = "dgvLichDay";
            this.dgvLichDay.ReadOnly = true;
            this.dgvLichDay.Size = new System.Drawing.Size(680, 288);
            this.dgvLichDay.TabIndex = 0;
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
            this.gbxLichThi.Text = "Lịch Gác Thi";
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AllowUserToAddRows = false;
            this.dgvLichThi.AllowUserToDeleteRows = false;
            this.dgvLichThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichThi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichThi.Location = new System.Drawing.Point(10, 32);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.ReadOnly = true;
            this.dgvLichThi.Size = new System.Drawing.Size(680, 308);
            this.dgvLichThi.TabIndex = 0;
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.BackColor = System.Drawing.Color.White;
            this.gbxThongTin.Controls.Add(this.valNgoaiNgu);
            this.gbxThongTin.Controls.Add(this.lblNgoaiNgu);
            this.gbxThongTin.Controls.Add(this.valTrinhDo);
            this.gbxThongTin.Controls.Add(this.lblTrinhDo);
            this.gbxThongTin.Controls.Add(this.valEmail);
            this.gbxThongTin.Controls.Add(this.lblEmail);
            this.gbxThongTin.Controls.Add(this.valSDT);
            this.gbxThongTin.Controls.Add(this.lblSDT);
            this.gbxThongTin.Controls.Add(this.valGioiTinh);
            this.gbxThongTin.Controls.Add(this.lblGioiTinh);
            this.gbxThongTin.Controls.Add(this.valTen);
            this.gbxThongTin.Controls.Add(this.lblTen);
            this.gbxThongTin.Controls.Add(this.valMaGV);
            this.gbxThongTin.Controls.Add(this.lblMaGV);
            this.gbxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxThongTin.Location = new System.Drawing.Point(740, 100);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(380, 330);
            this.gbxThongTin.TabIndex = 3;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông Tin Giảng Viên";
            // 
            // valNgoaiNgu
            // 
            this.valNgoaiNgu.AutoSize = true;
            this.valNgoaiNgu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNgoaiNgu.ForeColor = System.Drawing.Color.Black;
            this.valNgoaiNgu.Location = new System.Drawing.Point(160, 280);
            this.valNgoaiNgu.Name = "valNgoaiNgu";
            this.valNgoaiNgu.Size = new System.Drawing.Size(21, 20);
            this.valNgoaiNgu.TabIndex = 0;
            this.valNgoaiNgu.Text = "...";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgoaiNgu.ForeColor = System.Drawing.Color.Gray;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(20, 280);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(111, 20);
            this.lblNgoaiNgu.TabIndex = 1;
            this.lblNgoaiNgu.Text = "Ngoại ngữ dạy:";
            // 
            // valTrinhDo
            // 
            this.valTrinhDo.AutoSize = true;
            this.valTrinhDo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTrinhDo.ForeColor = System.Drawing.Color.Black;
            this.valTrinhDo.Location = new System.Drawing.Point(160, 240);
            this.valTrinhDo.Name = "valTrinhDo";
            this.valTrinhDo.Size = new System.Drawing.Size(21, 20);
            this.valTrinhDo.TabIndex = 2;
            this.valTrinhDo.Text = "...";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrinhDo.ForeColor = System.Drawing.Color.Gray;
            this.lblTrinhDo.Location = new System.Drawing.Point(20, 240);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(66, 20);
            this.lblTrinhDo.TabIndex = 3;
            this.lblTrinhDo.Text = "Trình độ:";
            // 
            // valEmail
            // 
            this.valEmail.AutoSize = true;
            this.valEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valEmail.ForeColor = System.Drawing.Color.Black;
            this.valEmail.Location = new System.Drawing.Point(160, 200);
            this.valEmail.Name = "valEmail";
            this.valEmail.Size = new System.Drawing.Size(21, 20);
            this.valEmail.TabIndex = 4;
            this.valEmail.Text = "...";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // valSDT
            // 
            this.valSDT.AutoSize = true;
            this.valSDT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSDT.ForeColor = System.Drawing.Color.Black;
            this.valSDT.Location = new System.Drawing.Point(160, 160);
            this.valSDT.Name = "valSDT";
            this.valSDT.Size = new System.Drawing.Size(21, 20);
            this.valSDT.TabIndex = 6;
            this.valSDT.Text = "...";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Gray;
            this.lblSDT.Location = new System.Drawing.Point(20, 160);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(100, 20);
            this.lblSDT.TabIndex = 7;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // valGioiTinh
            // 
            this.valGioiTinh.AutoSize = true;
            this.valGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.valGioiTinh.Location = new System.Drawing.Point(160, 120);
            this.valGioiTinh.Name = "valGioiTinh";
            this.valGioiTinh.Size = new System.Drawing.Size(21, 20);
            this.valGioiTinh.TabIndex = 8;
            this.valGioiTinh.Text = "...";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Gray;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 120);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(68, 20);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // valTen
            // 
            this.valTen.AutoSize = true;
            this.valTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTen.ForeColor = System.Drawing.Color.Black;
            this.valTen.Location = new System.Drawing.Point(160, 80);
            this.valTen.Name = "valTen";
            this.valTen.Size = new System.Drawing.Size(21, 20);
            this.valTen.TabIndex = 10;
            this.valTen.Text = "...";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Gray;
            this.lblTen.Location = new System.Drawing.Point(20, 80);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(76, 20);
            this.lblTen.TabIndex = 11;
            this.lblTen.Text = "Họ và tên:";
            // 
            // valMaGV
            // 
            this.valMaGV.AutoSize = true;
            this.valMaGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valMaGV.ForeColor = System.Drawing.Color.Black;
            this.valMaGV.Location = new System.Drawing.Point(160, 40);
            this.valMaGV.Name = "valMaGV";
            this.valMaGV.Size = new System.Drawing.Size(21, 20);
            this.valMaGV.TabIndex = 12;
            this.valMaGV.Text = "...";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.ForeColor = System.Drawing.Color.Gray;
            this.lblMaGV.Location = new System.Drawing.Point(20, 40);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(106, 20);
            this.lblMaGV.TabIndex = 13;
            this.lblMaGV.Text = "Mã giảng viên:";
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChamDiem.FlatAppearance.BorderSize = 0;
            this.btnChamDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamDiem.ForeColor = System.Drawing.Color.White;
            this.btnChamDiem.Location = new System.Drawing.Point(740, 450);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(380, 50);
            this.btnChamDiem.TabIndex = 4;
            this.btnChamDiem.Text = "CHẤM ĐIỂM";
            this.btnChamDiem.UseVisualStyleBackColor = false;
            // 
            // GUI_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1140, 825);
            this.Controls.Add(this.btnChamDiem);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.gbxLichThi);
            this.Controls.Add(this.gbxLichDay);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ Giảng Viên";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbxLichDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxLichDay;
        private System.Windows.Forms.DataGridView dgvLichDay;
        private System.Windows.Forms.GroupBox gbxLichThi;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label valMaGV;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label valTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label valGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label valSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label valEmail;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label valTrinhDo;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label valNgoaiNgu;
        private System.Windows.Forms.Button btnChamDiem;
    }
}