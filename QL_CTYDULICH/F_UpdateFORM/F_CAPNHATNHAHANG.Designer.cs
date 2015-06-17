namespace QL_CTYDULICH.F_UpdateFORM
{
    partial class F_CAPNHATNHAHANG
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
            this.components = new System.ComponentModel.Container();
            this.txtTenNH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.cboDiaDiem = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmanh = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnluunv = new System.Windows.Forms.Button();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChiNH = new DevExpress.XtraEditors.MemoEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNH
            // 
            this.txtTenNH.Location = new System.Drawing.Point(109, 9);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(227, 20);
            this.txtTenNH.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(347, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 14);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Ghi Chú :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(12, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Đơn Giá :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(12, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 14);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Địa Điểm :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 14);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Nhà Hàng :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(408, 12);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGhiChu.Size = new System.Drawing.Size(203, 96);
            this.txtGhiChu.TabIndex = 4;
            // 
            // cboDiaDiem
            // 
            this.cboDiaDiem.Location = new System.Drawing.Point(109, 47);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDiaDiem.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MADIADIEM", "Địa Điểm", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENDIADIEM", "Tên Địa Điểm")});
            this.cboDiaDiem.Properties.DropDownRows = 3;
            this.cboDiaDiem.Properties.NullText = "Vui lòng chọn địa điểm";
            this.cboDiaDiem.Size = new System.Drawing.Size(227, 20);
            this.cboDiaDiem.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Mã NH:";
            this.labelControl1.Visible = false;
            // 
            // txtmanh
            // 
            this.txtmanh.Location = new System.Drawing.Point(109, 10);
            this.txtmanh.Name = "txtmanh";
            this.txtmanh.Size = new System.Drawing.Size(58, 20);
            this.txtmanh.TabIndex = 10;
            this.txtmanh.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(534, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnluunv
            // 
            this.btnluunv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluunv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluunv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluunv.Location = new System.Drawing.Point(454, 160);
            this.btnluunv.Name = "btnluunv";
            this.btnluunv.Size = new System.Drawing.Size(73, 30);
            this.btnluunv.TabIndex = 5;
            this.btnluunv.Text = "Lưu";
            this.btnluunv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluunv.UseVisualStyleBackColor = true;
            this.btnluunv.Click += new System.EventHandler(this.btnluunv_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Location = new System.Drawing.Point(287, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 14);
            this.labelControl7.TabIndex = 70;
            this.labelControl7.Text = "(/Bữa)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(109, 84);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(408, 122);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Sang Trọng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Bình Thường")});
            this.radioGroup1.Size = new System.Drawing.Size(173, 29);
            this.radioGroup1.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(12, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "Địa chỉ :";
            // 
            // txtDiaChiNH
            // 
            this.txtDiaChiNH.Location = new System.Drawing.Point(109, 121);
            this.txtDiaChiNH.Name = "txtDiaChiNH";
            this.txtDiaChiNH.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiaChiNH.Size = new System.Drawing.Size(227, 62);
            this.txtDiaChiNH.TabIndex = 73;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // F_CAPNHATNHAHANG
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 202);
            this.Controls.Add(this.txtDiaChiNH);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnluunv);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cboDiaDiem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmanh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CAPNHATNHAHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT NHÀ HÀNG";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_CAPNHATNHAHANG_FormClosed);
            this.Load += new System.EventHandler(this.F_CAPNHATNHAHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenNH;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LookUpEdit cboDiaDiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmanh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnluunv;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtDiaChiNH;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}