namespace QL_CTYDULICH.F_UpdateFORM
{
    partial class F_CAPNHATPHUONGTIEN
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPT = new DevExpress.XtraEditors.TextEdit();
            this.cboTenXe = new DevExpress.XtraEditors.LookUpEdit();
            this.rdoRanh = new DevExpress.XtraEditors.RadioGroup();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboTenTaiXe = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoRanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Phương Tiện :";
            this.labelControl1.Visible = false;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(126, 9);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(64, 20);
            this.txtMaPT.TabIndex = 1;
            this.txtMaPT.Visible = false;
            // 
            // cboTenXe
            // 
            this.cboTenXe.Location = new System.Drawing.Point(126, 9);
            this.cboTenXe.Name = "cboTenXe";
            this.cboTenXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenXe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAXE", "MAXE", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENXE", "Tên Xe")});
            this.cboTenXe.Properties.DropDownRows = 3;
            this.cboTenXe.Properties.NullText = "Vui lòng chọn Tên Xe";
            this.cboTenXe.Size = new System.Drawing.Size(164, 20);
            this.cboTenXe.TabIndex = 2;
            this.cboTenXe.EditValueChanged += new System.EventHandler(this.cboTenXe_EditValueChanged);
            // 
            // rdoRanh
            // 
            this.rdoRanh.Location = new System.Drawing.Point(125, 130);
            this.rdoRanh.Name = "rdoRanh";
            this.rdoRanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdoRanh.Properties.Appearance.Options.UseFont = true;
            this.rdoRanh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Có"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Không")});
            this.rdoRanh.Size = new System.Drawing.Size(165, 22);
            this.rdoRanh.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(358, 12);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGhiChu.Size = new System.Drawing.Size(158, 96);
            this.txtGhiChu.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên Xe :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(12, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên Tài Xế :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(296, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ghi Chú :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(12, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Đơn Giá :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(12, 133);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Rảnh :";
            // 
            // cboTenTaiXe
            // 
            this.cboTenTaiXe.Location = new System.Drawing.Point(126, 47);
            this.cboTenTaiXe.Name = "cboTenTaiXe";
            this.cboTenTaiXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenTaiXe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MATX", "MATX", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENTX", "Tài Xế")});
            this.cboTenTaiXe.Properties.DropDownRows = 3;
            this.cboTenTaiXe.Properties.NullText = "Vui lòng chọn tên Tài Xế";
            this.cboTenTaiXe.Size = new System.Drawing.Size(164, 20);
            this.cboTenTaiXe.TabIndex = 10;
            this.cboTenTaiXe.EditValueChanged += new System.EventHandler(this.cboTenTaiXe_EditValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(358, 122);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 30);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(439, 122);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(125, 86);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDonGia.Properties.Appearance.Options.UseBackColor = true;
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(165, 20);
            this.txtDonGia.TabIndex = 51;
            // 
            // F_CAPNHATPHUONGTIEN
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 165);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboTenTaiXe);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.rdoRanh);
            this.Controls.Add(this.cboTenXe);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CAPNHATPHUONGTIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT PHƯƠNG TIỆN";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_CAPNHATPHUONGTIEN_FormClosed);
            this.Load += new System.EventHandler(this.F_CAPNHATPHUONGTIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoRanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaPT;
        private DevExpress.XtraEditors.LookUpEdit cboTenXe;
        private DevExpress.XtraEditors.RadioGroup rdoRanh;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cboTenTaiXe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
    }
}