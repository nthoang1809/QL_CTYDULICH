namespace QL_CTYDULICH.F_UpdateFORM
{
    partial class F_CAPNHATTOUR
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
            this.txtMaTour = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboDiaDiem = new DevExpress.XtraEditors.LookUpEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTour = new DevExpress.XtraEditors.TextEdit();
            this.cboNhaHang = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhachSan = new DevExpress.XtraEditors.LookUpEdit();
            this.cboPhuongTien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.radLoaiTour = new DevExpress.XtraEditors.RadioGroup();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhachSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhuongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLoaiTour.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(105, 8);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(66, 20);
            this.txtMaTour.TabIndex = 0;
            this.txtMaTour.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(27, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Tour :";
            this.labelControl1.Visible = false;
            // 
            // cboDiaDiem
            // 
            this.cboDiaDiem.Location = new System.Drawing.Point(105, 56);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDiaDiem.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MADIADIEM", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENDIADIEM", "Địa Điểm", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANH", "Name14", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKS", "Name15", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboDiaDiem.Properties.DropDownRows = 3;
            this.cboDiaDiem.Properties.NullText = "Vui lòng chọn địa điểm";
            this.cboDiaDiem.Size = new System.Drawing.Size(138, 20);
            this.cboDiaDiem.TabIndex = 2;
            this.cboDiaDiem.EditValueChanged += new System.EventHandler(this.cboDiaDiem_EditValueChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(420, 114);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(217, 80);
            this.txtGhiChu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(27, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên Tour :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(27, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Địa Điểm :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(27, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nhà Hàng :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(328, 106);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ghi Chú :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(328, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Loại Tour :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(329, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 14);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Thời Gian :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(8, 215);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Phương Tiện :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(22, 160);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 14);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Khách Sạn :";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(105, 8);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(217, 20);
            this.txtTenTour.TabIndex = 12;
            // 
            // cboNhaHang
            // 
            this.cboNhaHang.Location = new System.Drawing.Point(105, 104);
            this.cboNhaHang.Name = "cboNhaHang";
            this.cboNhaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhaHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANH", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNH", "Nhà Hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DACDIEMNH", "Đặc Điểm")});
            this.cboNhaHang.Properties.DropDownRows = 3;
            this.cboNhaHang.Properties.NullText = "";
            this.cboNhaHang.Size = new System.Drawing.Size(138, 20);
            this.cboNhaHang.TabIndex = 13;
            // 
            // cboKhachSan
            // 
            this.cboKhachSan.Location = new System.Drawing.Point(105, 158);
            this.cboKhachSan.Name = "cboKhachSan";
            this.cboKhachSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhachSan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKS", "Name3", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKS", "Tên Khách Sạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DACDIEMKS", "Đặc Điểm")});
            this.cboKhachSan.Properties.DropDownRows = 3;
            this.cboKhachSan.Properties.NullText = "";
            this.cboKhachSan.Size = new System.Drawing.Size(138, 20);
            this.cboKhachSan.TabIndex = 14;
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.Location = new System.Drawing.Point(105, 213);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhuongTien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENTX", "Tài Xế"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENXE", "Xe")});
            this.cboPhuongTien.Properties.DropDownRows = 5;
            this.cboPhuongTien.Properties.NullText = "";
            this.cboPhuongTien.Size = new System.Drawing.Size(217, 20);
            this.cboPhuongTien.TabIndex = 15;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(420, 9);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(102, 20);
            this.txtThoiGian.TabIndex = 16;
            // 
            // radLoaiTour
            // 
            this.radLoaiTour.Location = new System.Drawing.Point(420, 58);
            this.radLoaiTour.Name = "radLoaiTour";
            this.radLoaiTour.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLoaiTour.Properties.Appearance.Options.UseFont = true;
            this.radLoaiTour.Properties.Columns = 2;
            this.radLoaiTour.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Cao Cấp"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Bình Thường")});
            this.radLoaiTour.Size = new System.Drawing.Size(192, 24);
            this.radLoaiTour.TabIndex = 17;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(559, 216);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 52;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(478, 216);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 30);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // F_CAPNHATTOUR
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 258);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.radLoaiTour);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.cboPhuongTien);
            this.Controls.Add(this.cboKhachSan);
            this.Controls.Add(this.cboNhaHang);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cboDiaDiem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMaTour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CAPNHATTOUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT TOUR";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_CAPNHATTOUR_FormClosed);
            this.Load += new System.EventHandler(this.F_CAPNHATTOUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhachSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhuongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLoaiTour.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaTour;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboDiaDiem;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTenTour;
        private DevExpress.XtraEditors.LookUpEdit cboNhaHang;
        private DevExpress.XtraEditors.LookUpEdit cboKhachSan;
        private DevExpress.XtraEditors.LookUpEdit cboPhuongTien;
        private DevExpress.XtraEditors.TextEdit txtThoiGian;
        private DevExpress.XtraEditors.RadioGroup radLoaiTour;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
    }
}