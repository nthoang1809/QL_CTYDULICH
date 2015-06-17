namespace QL_CTYDULICH
{
    partial class F_DSNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DSNHANVIEN));
            this.btnthemnv = new System.Windows.Forms.Button();
            this.btnsuanv = new System.Windows.Forms.Button();
            this.btnxoanv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditCHUCVUNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCMNDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGT = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageGT = new DevExpress.Utils.ImageCollection(this.components);
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhanChuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colUrlHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCHUCVUNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthemnv
            // 
            this.btnthemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemnv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemnv.Location = new System.Drawing.Point(6, 3);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(75, 30);
            this.btnthemnv.TabIndex = 1;
            this.btnthemnv.Text = "Thêm";
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // btnsuanv
            // 
            this.btnsuanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuanv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuanv.Location = new System.Drawing.Point(87, 3);
            this.btnsuanv.Name = "btnsuanv";
            this.btnsuanv.Size = new System.Drawing.Size(75, 30);
            this.btnsuanv.TabIndex = 2;
            this.btnsuanv.Text = "Sửa";
            this.btnsuanv.UseVisualStyleBackColor = true;
            this.btnsuanv.Click += new System.EventHandler(this.btnsuanv_Click);
            // 
            // btnxoanv
            // 
            this.btnxoanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoanv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoanv.Location = new System.Drawing.Point(168, 3);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(75, 30);
            this.btnxoanv.TabIndex = 3;
            this.btnxoanv.Text = "Xóa";
            this.btnxoanv.UseVisualStyleBackColor = true;
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 37);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthemnv);
            this.panel2.Controls.Add(this.btnxoanv);
            this.panel2.Controls.Add(this.btnsuanv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(677, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 37);
            this.panel2.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditCHUCVUNV,
            this.cboGT,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gridControl1.Size = new System.Drawing.Size(923, 397);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENNV,
            this.colMANV,
            this.colCMNDNV,
            this.conNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colDienThoai,
            this.colEmail,
            this.colNgayNhanChuc,
            this.colUrlHinh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập Để Tìm Kiếm (Lưu ý : Chuỗi ký tự được nhập trong dấu \"...\")";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTENNV
            // 
            this.colTENNV.Caption = "Tên Nhân Viên";
            this.colTENNV.ColumnEdit = this.repositoryItemTextEdit4;
            this.colTENNV.FieldName = "TENNV";
            this.colTENNV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTENNV.Name = "colTENNV";
            this.colTENNV.Visible = true;
            this.colTENNV.VisibleIndex = 0;
            this.colTENNV.Width = 200;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colMANV.AppearanceCell.Options.UseForeColor = true;
            this.colMANV.AppearanceCell.Options.UseTextOptions = true;
            this.colMANV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMANV.Caption = "Chức Vụ";
            this.colMANV.ColumnEdit = this.LookUpEditCHUCVUNV;
            this.colMANV.FieldName = "MACV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 100;
            // 
            // LookUpEditCHUCVUNV
            // 
            this.LookUpEditCHUCVUNV.AutoHeight = false;
            this.LookUpEditCHUCVUNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditCHUCVUNV.Name = "LookUpEditCHUCVUNV";
            // 
            // colCMNDNV
            // 
            this.colCMNDNV.AppearanceCell.Options.UseTextOptions = true;
            this.colCMNDNV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCMNDNV.Caption = "Chứng Minh Thư";
            this.colCMNDNV.FieldName = "CMNDNV";
            this.colCMNDNV.Name = "colCMNDNV";
            this.colCMNDNV.Visible = true;
            this.colCMNDNV.VisibleIndex = 2;
            this.colCMNDNV.Width = 140;
            // 
            // conNgaySinh
            // 
            this.conNgaySinh.AppearanceCell.Options.UseTextOptions = true;
            this.conNgaySinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.conNgaySinh.Caption = "Ngày Sinh";
            this.conNgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.conNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.conNgaySinh.FieldName = "NGAYSINHNV";
            this.conNgaySinh.Name = "conNgaySinh";
            this.conNgaySinh.Visible = true;
            this.conNgaySinh.VisibleIndex = 3;
            this.conNgaySinh.Width = 110;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.ColumnEdit = this.cboGT;
            this.colGioiTinh.FieldName = "GIOITINHNV";
            this.colGioiTinh.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            this.colGioiTinh.Width = 70;
            // 
            // cboGT
            // 
            this.cboGT.AutoHeight = false;
            this.cboGT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGT.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboGT.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 1)});
            this.cboGT.LargeImages = this.imageGT;
            this.cboGT.Name = "cboGT";
            // 
            // imageGT
            // 
            this.imageGT.ImageSize = new System.Drawing.Size(32, 32);
            this.imageGT.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageGT.ImageStream")));
            this.imageGT.Images.SetKeyName(0, "user-men-2-512.png");
            this.imageGT.Images.SetKeyName(1, "654854-user-women-512.png");
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DIACHINV";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 260;
            // 
            // colDienThoai
            // 
            this.colDienThoai.AppearanceCell.Options.UseTextOptions = true;
            this.colDienThoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.ColumnEdit = this.repositoryItemTextEdit2;
            this.colDienThoai.FieldName = "DIENTHOAINV";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 6;
            this.colDienThoai.Width = 110;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d\\d\\d";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "EMAILNV";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            this.colEmail.Width = 190;
            // 
            // colNgayNhanChuc
            // 
            this.colNgayNhanChuc.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayNhanChuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayNhanChuc.Caption = "Ngày Nhận Chức";
            this.colNgayNhanChuc.ColumnEdit = this.repositoryItemTextEdit3;
            this.colNgayNhanChuc.FieldName = "NGAYNHANCHUC";
            this.colNgayNhanChuc.Name = "colNgayNhanChuc";
            this.colNgayNhanChuc.Visible = true;
            this.colNgayNhanChuc.VisibleIndex = 8;
            this.colNgayNhanChuc.Width = 140;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // colUrlHinh
            // 
            this.colUrlHinh.Caption = "Ảnh Nhân Viên";
            this.colUrlHinh.FieldName = "URLHINHNV";
            this.colUrlHinh.Name = "colUrlHinh";
            this.colUrlHinh.Visible = true;
            this.colUrlHinh.VisibleIndex = 9;
            this.colUrlHinh.Width = 150;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // F_DSNHANVIEN
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 434);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_DSNHANVIEN";
            this.Text = "DANH SÁCH NHÂN VIÊN";
            this.Load += new System.EventHandler(this.F_DSNHANVIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCHUCVUNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.Button btnsuanv;
        private System.Windows.Forms.Button btnxoanv;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colCMNDNV;
        private DevExpress.XtraGrid.Columns.GridColumn conNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhanChuc;
        private DevExpress.XtraGrid.Columns.GridColumn colUrlHinh;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditCHUCVUNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cboGT;
        private DevExpress.Utils.ImageCollection imageGT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
    }
}