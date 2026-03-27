
namespace GUI
{
    partial class GUI_DKKH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaKH_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.valTongHocPhi = new System.Windows.Forms.Label();
            this.lblTongHocPhi = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnQuaLai = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.gbxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
            this.pnlHeader.Controls.Add(this.btnQuaLai);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1140, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ KHÓA HỌC";
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.BackColor = System.Drawing.Color.White;
            this.gbxDanhSach.Controls.Add(this.dgvKhoaHoc);
            this.gbxDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxDanhSach.Location = new System.Drawing.Point(20, 100);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.gbxDanhSach.Size = new System.Drawing.Size(540, 600);
            this.gbxDanhSach.TabIndex = 1;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh Sách Khóa Học Mở Đăng Ký";
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.AllowUserToAddRows = false;
            this.dgvKhoaHoc.AllowUserToDeleteRows = false;
            this.dgvKhoaHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoaHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhoaHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhoaHoc.ColumnHeadersHeight = 40;
            this.dgvKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colMaKH,
            this.colTenKH,
            this.colHocPhi});
            this.dgvKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoaHoc.EnableHeadersVisualStyles = false;
            this.dgvKhoaHoc.Location = new System.Drawing.Point(10, 32);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.RowHeadersVisible = false;
            this.dgvKhoaHoc.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhoaHoc.RowTemplate.Height = 35;
            this.dgvKhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(520, 558);
            this.dgvKhoaHoc.TabIndex = 0;
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "Chọn";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 60;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            this.colMaKH.Width = 90;
            // 
            // colTenKH
            // 
            this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKH.HeaderText = "Tên Khóa Học";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colHocPhi
            // 
            this.colHocPhi.HeaderText = "Học Phí";
            this.colHocPhi.Name = "colHocPhi";
            this.colHocPhi.ReadOnly = true;
            this.colHocPhi.Width = 120;
            // 
            // gbxChiTiet
            // 
            this.gbxChiTiet.BackColor = System.Drawing.Color.White;
            this.gbxChiTiet.Controls.Add(this.dgvChiTiet);
            this.gbxChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbxChiTiet.Location = new System.Drawing.Point(580, 100);
            this.gbxChiTiet.Name = "gbxChiTiet";
            this.gbxChiTiet.Padding = new System.Windows.Forms.Padding(10);
            this.gbxChiTiet.Size = new System.Drawing.Size(540, 600);
            this.gbxChiTiet.TabIndex = 2;
            this.gbxChiTiet.TabStop = false;
            this.gbxChiTiet.Text = "Chi Tiết Khóa Học Đang Chọn";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTiet.ColumnHeadersHeight = 40;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH_CT,
            this.colLichHoc,
            this.colGiangVien,
            this.colPhongHoc});
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 32);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTiet.RowTemplate.Height = 35;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(520, 558);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // colMaKH_CT
            // 
            this.colMaKH_CT.HeaderText = "Mã KH";
            this.colMaKH_CT.Name = "colMaKH_CT";
            this.colMaKH_CT.ReadOnly = true;
            this.colMaKH_CT.Width = 90;
            // 
            // colLichHoc
            // 
            this.colLichHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLichHoc.HeaderText = "Lịch Học";
            this.colLichHoc.Name = "colLichHoc";
            this.colLichHoc.ReadOnly = true;
            // 
            // colGiangVien
            // 
            this.colGiangVien.HeaderText = "Giảng Viên";
            this.colGiangVien.Name = "colGiangVien";
            this.colGiangVien.ReadOnly = true;
            this.colGiangVien.Width = 140;
            // 
            // colPhongHoc
            // 
            this.colPhongHoc.HeaderText = "Phòng";
            this.colPhongHoc.Name = "colPhongHoc";
            this.colPhongHoc.ReadOnly = true;
            this.colPhongHoc.Width = 80;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.valTongHocPhi);
            this.pnlFooter.Controls.Add(this.lblTongHocPhi);
            this.pnlFooter.Controls.Add(this.btnDangKy);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 725);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1140, 100);
            this.pnlFooter.TabIndex = 3;
            // 
            // valTongHocPhi
            // 
            this.valTongHocPhi.AutoSize = true;
            this.valTongHocPhi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTongHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.valTongHocPhi.Location = new System.Drawing.Point(210, 30);
            this.valTongHocPhi.Name = "valTongHocPhi";
            this.valTongHocPhi.Size = new System.Drawing.Size(99, 37);
            this.valTongHocPhi.TabIndex = 2;
            this.valTongHocPhi.Text = "0 VNĐ";
            // 
            // lblTongHocPhi
            // 
            this.lblTongHocPhi.AutoSize = true;
            this.lblTongHocPhi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHocPhi.ForeColor = System.Drawing.Color.Black;
            this.lblTongHocPhi.Location = new System.Drawing.Point(20, 34);
            this.lblTongHocPhi.Name = "lblTongHocPhi";
            this.lblTongHocPhi.Size = new System.Drawing.Size(180, 30);
            this.lblTongHocPhi.TabIndex = 1;
            this.lblTongHocPhi.Text = "TỔNG HỌC PHÍ:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(740, 20);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(380, 60);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "XÁC NHẬN ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnQuaLai
            // 
            this.btnQuaLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuaLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnQuaLai.FlatAppearance.BorderSize = 0;
            this.btnQuaLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaLai.ForeColor = System.Drawing.Color.White;
            this.btnQuaLai.Location = new System.Drawing.Point(1008, 12);
            this.btnQuaLai.Name = "btnQuaLai";
            this.btnQuaLai.Size = new System.Drawing.Size(120, 40);
            this.btnQuaLai.TabIndex = 5;
            this.btnQuaLai.Text = "Quay lại";
            this.btnQuaLai.UseVisualStyleBackColor = false;
            // 
            // GUI_DKKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1140, 825);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.gbxChiTiet);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_DKKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Khóa Học";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.gbxChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocPhi;
        private System.Windows.Forms.GroupBox gbxChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongHoc;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label valTongHocPhi;
        private System.Windows.Forms.Label lblTongHocPhi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnQuaLai;
    }
}