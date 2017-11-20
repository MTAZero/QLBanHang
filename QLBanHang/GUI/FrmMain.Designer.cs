namespace QLBanHang.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDangXuat = new System.Windows.Forms.LinkLabel();
            this.txtDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.txtTTNhanVien = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnQLKho = new System.Windows.Forms.Button();
            this.btnQLNXB = new System.Windows.Forms.Button();
            this.btnQuanLySACH = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 683);
            this.panel1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(223, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1133, 654);
            this.panelMain.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDangXuat);
            this.panel2.Controls.Add(this.txtDoiMatKhau);
            this.panel2.Controls.Add(this.txtTTNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 27);
            this.panel2.TabIndex = 1;
            // 
            // txtDangXuat
            // 
            this.txtDangXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDangXuat.Location = new System.Drawing.Point(677, 0);
            this.txtDangXuat.Name = "txtDangXuat";
            this.txtDangXuat.Size = new System.Drawing.Size(70, 23);
            this.txtDangXuat.TabIndex = 2;
            this.txtDangXuat.TabStop = true;
            this.txtDangXuat.Text = "Đăng xuất";
            this.txtDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtDangXuat_LinkClicked);
            // 
            // txtDoiMatKhau
            // 
            this.txtDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDoiMatKhau.Location = new System.Drawing.Point(747, 0);
            this.txtDoiMatKhau.Name = "txtDoiMatKhau";
            this.txtDoiMatKhau.Size = new System.Drawing.Size(70, 23);
            this.txtDoiMatKhau.TabIndex = 1;
            this.txtDoiMatKhau.TabStop = true;
            this.txtDoiMatKhau.Text = "Đổi mật khẩu";
            this.txtDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtDoiMatKhau_LinkClicked);
            // 
            // txtTTNhanVien
            // 
            this.txtTTNhanVien.BackColor = System.Drawing.Color.White;
            this.txtTTNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTNhanVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTTNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTTNhanVien.Location = new System.Drawing.Point(817, 0);
            this.txtTTNhanVien.Name = "txtTTNhanVien";
            this.txtTTNhanVien.Size = new System.Drawing.Size(312, 23);
            this.txtTTNhanVien.TabIndex = 0;
            this.txtTTNhanVien.Text = "Phạm Thị Quỳnh - Nhân viên";
            this.txtTTNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMenu.Controls.Add(this.btnTheLoai);
            this.PanelMenu.Controls.Add(this.btnQLKho);
            this.PanelMenu.Controls.Add(this.btnQLNXB);
            this.PanelMenu.Controls.Add(this.btnQuanLySACH);
            this.PanelMenu.Controls.Add(this.btnNhapHang);
            this.PanelMenu.Controls.Add(this.btnXuatHang);
            this.PanelMenu.Controls.Add(this.btnQLNhanVien);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(223, 681);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.BackColor = System.Drawing.Color.White;
            this.btnTheLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheLoai.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTheLoai.FlatAppearance.BorderSize = 2;
            this.btnTheLoai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTheLoai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.ForeColor = System.Drawing.Color.Black;
            this.btnTheLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.Image")));
            this.btnTheLoai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTheLoai.Location = new System.Drawing.Point(2, 285);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(213, 88);
            this.btnTheLoai.TabIndex = 8;
            this.btnTheLoai.Text = "DANH MỤC THỂ LOẠI";
            this.btnTheLoai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTheLoai.UseVisualStyleBackColor = false;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnQLKho
            // 
            this.btnQLKho.BackColor = System.Drawing.Color.White;
            this.btnQLKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKho.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQLKho.FlatAppearance.BorderSize = 2;
            this.btnQLKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQLKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.ForeColor = System.Drawing.Color.Black;
            this.btnQLKho.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKho.Image")));
            this.btnQLKho.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLKho.Location = new System.Drawing.Point(2, 567);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Size = new System.Drawing.Size(213, 88);
            this.btnQLKho.TabIndex = 4;
            this.btnQLKho.Text = "KHO";
            this.btnQLKho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLKho.UseVisualStyleBackColor = false;
            this.btnQLKho.Click += new System.EventHandler(this.btnQLKho_Click);
            // 
            // btnQLNXB
            // 
            this.btnQLNXB.BackColor = System.Drawing.Color.White;
            this.btnQLNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLNXB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQLNXB.FlatAppearance.BorderSize = 2;
            this.btnQLNXB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLNXB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQLNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNXB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNXB.ForeColor = System.Drawing.Color.Black;
            this.btnQLNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNXB.Image")));
            this.btnQLNXB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLNXB.Location = new System.Drawing.Point(2, 191);
            this.btnQLNXB.Name = "btnQLNXB";
            this.btnQLNXB.Size = new System.Drawing.Size(213, 88);
            this.btnQLNXB.TabIndex = 3;
            this.btnQLNXB.Text = "DANH MỤC NXB";
            this.btnQLNXB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNXB.UseVisualStyleBackColor = false;
            this.btnQLNXB.Click += new System.EventHandler(this.btnQLSACH_Click);
            // 
            // btnQuanLySACH
            // 
            this.btnQuanLySACH.BackColor = System.Drawing.Color.White;
            this.btnQuanLySACH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLySACH.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLySACH.FlatAppearance.BorderSize = 2;
            this.btnQuanLySACH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLySACH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLySACH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySACH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySACH.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLySACH.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLySACH.Image")));
            this.btnQuanLySACH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLySACH.Location = new System.Drawing.Point(2, 97);
            this.btnQuanLySACH.Name = "btnQuanLySACH";
            this.btnQuanLySACH.Size = new System.Drawing.Size(213, 88);
            this.btnQuanLySACH.TabIndex = 6;
            this.btnQuanLySACH.Text = "DANH MỤC SÁCH";
            this.btnQuanLySACH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLySACH.UseVisualStyleBackColor = false;
            this.btnQuanLySACH.Click += new System.EventHandler(this.btnQuanLySACH_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhapHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhapHang.FlatAppearance.BorderSize = 2;
            this.btnNhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhapHang.Location = new System.Drawing.Point(2, 379);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(213, 88);
            this.btnNhapHang.TabIndex = 5;
            this.btnNhapHang.Text = "NHẬP SÁCH";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnXuatHang.BackColor = System.Drawing.Color.White;
            this.btnXuatHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXuatHang.FlatAppearance.BorderSize = 2;
            this.btnXuatHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXuatHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHang.ForeColor = System.Drawing.Color.Black;
            this.btnXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHang.Image")));
            this.btnXuatHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatHang.Location = new System.Drawing.Point(2, 473);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(213, 88);
            this.btnXuatHang.TabIndex = 7;
            this.btnXuatHang.Text = "BÁN SÁCH";
            this.btnXuatHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatHang.UseVisualStyleBackColor = false;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.White;
            this.btnQLNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 2;
            this.btnQLNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLNhanVien.Location = new System.Drawing.Point(2, 3);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(213, 88);
            this.btnQLNhanVien.TabIndex = 2;
            this.btnQLNhanVien.Text = "NHÂN VIÊN";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 683);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTTNhanVien;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Button btnQuanLySACH;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnQLKho;
        private System.Windows.Forms.Button btnQLNXB;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.LinkLabel txtDoiMatKhau;
        private System.Windows.Forms.LinkLabel txtDangXuat;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Panel panelMain;
    }
}

