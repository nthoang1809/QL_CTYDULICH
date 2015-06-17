namespace QL_CTYDULICH
{
    partial class F_DSNHAHANG
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
            this.btnxoanh = new System.Windows.Forms.Button();
            this.btnsuanh = new System.Windows.Forms.Button();
            this.btnthemnh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxoanh
            // 
            this.btnxoanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoanh.Location = new System.Drawing.Point(193, 3);
            this.btnxoanh.Name = "btnxoanh";
            this.btnxoanh.Size = new System.Drawing.Size(75, 30);
            this.btnxoanh.TabIndex = 9;
            this.btnxoanh.Text = "Xóa";
            this.btnxoanh.UseVisualStyleBackColor = true;
            // 
            // btnsuanh
            // 
            this.btnsuanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuanh.Location = new System.Drawing.Point(97, 3);
            this.btnsuanh.Name = "btnsuanh";
            this.btnsuanh.Size = new System.Drawing.Size(75, 30);
            this.btnsuanh.TabIndex = 8;
            this.btnsuanh.Text = "Sửa";
            this.btnsuanh.UseVisualStyleBackColor = true;
            // 
            // btnthemnh
            // 
            this.btnthemnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemnh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemnh.Location = new System.Drawing.Point(3, 3);
            this.btnthemnh.Name = "btnthemnh";
            this.btnthemnh.Size = new System.Drawing.Size(75, 30);
            this.btnthemnh.TabIndex = 7;
            this.btnthemnh.Text = "Thêm";
            this.btnthemnh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 43);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthemnh);
            this.panel2.Controls.Add(this.btnsuanh);
            this.panel2.Controls.Add(this.btnxoanh);
            this.panel2.Location = new System.Drawing.Point(350, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 38);
            this.panel2.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(626, 266);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // F_DSNHAHANG
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 309);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_DSNHAHANG";
            this.Text = "DANH SÁCH NHÀ HÀNG";
            this.Load += new System.EventHandler(this.F_DSNHAHANG_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnxoanh;
        private System.Windows.Forms.Button btnsuanh;
        private System.Windows.Forms.Button btnthemnh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}