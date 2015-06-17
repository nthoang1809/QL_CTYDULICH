namespace QL_CTYDULICH.F_UpdateFORM
{
    partial class F_DATTOUR
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboNV = new DevExpress.XtraEditors.LookUpEdit();
            this.cboTour = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKH = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMAHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboKS = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNH = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.cboPT = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(435, 412);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 52;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(354, 412);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 30);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(175, 53);
            this.cboNV.Name = "cboNV";
            this.cboNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANV", "Name11", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNV", "NHÂN VIÊN")});
            this.cboNV.Size = new System.Drawing.Size(337, 20);
            this.cboNV.TabIndex = 50;
            // 
            // cboTour
            // 
            this.cboTour.Location = new System.Drawing.Point(147, 136);
            this.cboTour.Name = "cboTour";
            this.cboTour.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTour.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MATOUR", "Name9", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENTOUR", "TOUR")});
            this.cboTour.Properties.NullText = "Vui lòng chọn tên Tour";
            this.cboTour.Size = new System.Drawing.Size(364, 20);
            this.cboTour.TabIndex = 48;
            this.cboTour.EditValueChanged += new System.EventHandler(this.cboTour_EditValueChanged);
            // 
            // cboKH
            // 
            this.cboKH.Location = new System.Drawing.Point(147, 95);
            this.cboKH.Name = "cboKH";
            this.cboKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKH", "Name7", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKH", "KHÁCH HÀNG")});
            this.cboKH.Size = new System.Drawing.Size(364, 20);
            this.cboKH.TabIndex = 47;
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(147, 12);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMAHD.Properties.Appearance.Options.UseBackColor = true;
            this.txtMAHD.Properties.ReadOnly = true;
            this.txtMAHD.Size = new System.Drawing.Size(361, 20);
            this.txtMAHD.TabIndex = 46;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(17, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(152, 14);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "Nhân Viên Lập Hóa Đơn :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(17, 293);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 14);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Tổng Tiền :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(17, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 14);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Mã Hóa Đơn :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 137);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 14);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Tên Tour Đăng Ký :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(17, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 14);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = " Khách Hàng :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(16, 327);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 14);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "Ghi Chú :";
            // 
            // cboKS
            // 
            this.cboKS.Location = new System.Drawing.Point(147, 218);
            this.cboKS.Name = "cboKS";
            this.cboKS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKS.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKS", "Name9", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKS", "KHÁCH SẠN")});
            this.cboKS.Size = new System.Drawing.Size(365, 20);
            this.cboKS.TabIndex = 63;
            this.cboKS.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cboKS_Closed);
            // 
            // cboNH
            // 
            this.cboNH.Location = new System.Drawing.Point(147, 177);
            this.cboNH.Name = "cboNH";
            this.cboNH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANH", "Name7", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNH", "NHÀ HÀNG")});
            this.cboNH.Size = new System.Drawing.Size(364, 20);
            this.cboNH.TabIndex = 62;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(17, 219);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 14);
            this.labelControl9.TabIndex = 61;
            this.labelControl9.Text = "Khách Sạn :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(17, 178);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 14);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Nhà Hàng :";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(147, 292);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(361, 20);
            this.txtThanhTien.TabIndex = 65;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(146, 327);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(361, 79);
            this.txtGhiChu.TabIndex = 58;
            // 
            // cboPT
            // 
            this.cboPT.Location = new System.Drawing.Point(146, 255);
            this.cboPT.Name = "cboPT";
            this.cboPT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAPT", "Name9", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENPT", "PHƯƠNG TIỆN")});
            this.cboPT.Size = new System.Drawing.Size(365, 20);
            this.cboPT.TabIndex = 67;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(17, 256);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(86, 14);
            this.labelControl11.TabIndex = 66;
            this.labelControl11.Text = "Phương Tiện :";
            // 
            // F_DATTOUR
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 453);
            this.Controls.Add(this.cboPT);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.cboKS);
            this.Controls.Add(this.cboNH);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.cboKH);
            this.Controls.Add(this.txtMAHD);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhiChu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_DATTOUR";
            this.Text = "ĐẶT TOUR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_DATTOUR_FormClosed);
            this.Load += new System.EventHandler(this.F_DATTOUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraEditors.LookUpEdit cboNV;
        private DevExpress.XtraEditors.LookUpEdit cboTour;
        private DevExpress.XtraEditors.LookUpEdit cboKH;
        private DevExpress.XtraEditors.TextEdit txtMAHD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboKS;
        private DevExpress.XtraEditors.LookUpEdit cboNH;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LookUpEdit cboPT;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}