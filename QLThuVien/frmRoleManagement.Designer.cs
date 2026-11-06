namespace QLThuVien
{
    partial class frmRoleManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstVaiTro;
        private System.Windows.Forms.CheckedListBox chkListChucNang;
        private System.Windows.Forms.Button btnLuuPhanQuyen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblVaiTro = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblChucNang = new System.Windows.Forms.Label();
            this.lstVaiTro = new System.Windows.Forms.ListBox();
            this.chkListChucNang = new System.Windows.Forms.CheckedListBox();
            this.btnLuuPhanQuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new System.Drawing.Point(15, 15);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new System.Drawing.Size(48, 16);
            lblVaiTro.TabIndex = 0;
            lblVaiTro.Text = "Vai trò";
            // 
            // lblChucNang
            // 
            lblChucNang.AutoSize = true;
            lblChucNang.Location = new System.Drawing.Point(220, 15);
            lblChucNang.Name = "lblChucNang";
            lblChucNang.Size = new System.Drawing.Size(137, 16);
            lblChucNang.TabIndex = 1;
            lblChucNang.Text = "Chức năng được phép";
            // 
            // lstVaiTro
            // 
            this.lstVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVaiTro.DisplayMember = "TenVaiTro";
            this.lstVaiTro.FormattingEnabled = true;
            this.lstVaiTro.ItemHeight = 16;
            this.lstVaiTro.Location = new System.Drawing.Point(15, 40);
            this.lstVaiTro.Name = "lstVaiTro";
            this.lstVaiTro.Size = new System.Drawing.Size(185, 340);
            this.lstVaiTro.TabIndex = 2;
            this.lstVaiTro.SelectedIndexChanged += new System.EventHandler(this.lstVaiTro_SelectedIndexChanged);
            // 
            // chkListChucNang
            // 
            this.chkListChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListChucNang.CheckOnClick = true;
            this.chkListChucNang.DisplayMember = "TenChucNang";
            this.chkListChucNang.FormattingEnabled = true;
            this.chkListChucNang.Location = new System.Drawing.Point(220, 40);
            this.chkListChucNang.Name = "chkListChucNang";
            this.chkListChucNang.Size = new System.Drawing.Size(465, 344);
            this.chkListChucNang.TabIndex = 3;
            // 
            // btnLuuPhanQuyen
            // 
            this.btnLuuPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuPhanQuyen.Location = new System.Drawing.Point(565, 400);
            this.btnLuuPhanQuyen.Name = "btnLuuPhanQuyen";
            this.btnLuuPhanQuyen.Size = new System.Drawing.Size(120, 30);
            this.btnLuuPhanQuyen.TabIndex = 4;
            this.btnLuuPhanQuyen.Text = "Lưu phân quyền";
            this.btnLuuPhanQuyen.UseVisualStyleBackColor = true;
            this.btnLuuPhanQuyen.Click += new System.EventHandler(this.btnLuuPhanQuyen_Click);
            // 
            // frmRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(lblVaiTro);
            this.Controls.Add(lblChucNang);
            this.Controls.Add(this.lstVaiTro);
            this.Controls.Add(this.chkListChucNang);
            this.Controls.Add(this.btnLuuPhanQuyen);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmRoleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phân quyền";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
