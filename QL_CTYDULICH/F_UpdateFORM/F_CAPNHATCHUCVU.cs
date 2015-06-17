using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_CTYDULICHDAL;
using QL_CTYDULICHBAL;
using QL_CTYDULICH.F_ListFORM;
using QL_CTYDULICH.ThuVien;

namespace QL_CTYDULICH.F_UpdateFORM
{
    public partial class F_CAPNHATCHUCVU : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        CHUCVU oriData;
        bool isNew;
        public F_CAPNHATCHUCVU()
        {
            InitializeComponent();
        }

        public F_CAPNHATCHUCVU(DevExpress.XtraEditors.XtraForm parent, CHUCVU data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new CHUCVU();
        }

        private void F_CAPNHATCHUCVU_Load(object sender, EventArgs e)
        {
            parent.Enabled = false;
            bingdingConTrols();
        }

        private void bingdingConTrols()
        {
            txtMaCV.DataBindings.Add("EditValue", oriData, "MACV");
            txtTenCV.DataBindings.Add("EditValue", oriData, "TENCV");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
          
            var kh = new CCHUCVU();
            if (!isNew)
            {
                if (string.IsNullOrEmpty(txtTenCV.Text))
                {
                    dxErrorProvider1.SetError(txtTenCV, "Vui lòng nhập Tên CHỨC VỤ");
                    return;
                }
                else

                if (MessageBox.Show("Bạn có muốn cập nhật chức vụ " + txtTenCV.Text + " ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kh.capnhatCHUCVU(oriData);
                    MessageBox.Show("Bạn đã cập nhật  chức vụ " + txtTenCV.Text + " thành công!!!");
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenCV.Text))
                {
                    dxErrorProvider1.SetError(txtTenCV, "Tên CHỨC VỤ không được rổng");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn thêm chức vụ " + txtTenCV.Text + " ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kh.themCHUCVU(oriData);
                    MessageBox.Show("Bạn đã thêm chức vụ " + txtTenCV.Text + " thành công!!!");
                    this.Close();
                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát không ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!isNew)
                {
                    var nh = new CCHUCVU();
                    nh.Refresh(oriData);
                }
                this.Close();
            }
           
        }

        private void F_CAPNHATCHUCVU_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSCHUCVU)
            {
                ((F_DSCHUCVU)parent).loadDataSource();
            }
        }
    }
}
