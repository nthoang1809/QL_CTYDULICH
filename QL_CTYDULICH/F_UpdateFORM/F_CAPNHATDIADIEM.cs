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

namespace QL_CTYDULICH.F_UpdateFORM
{
    public partial class F_CAPNHATDIADIEM : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        DIADIEM oriData;
        bool isNew;
        public F_CAPNHATDIADIEM()
        {
            InitializeComponent();
        }
        public F_CAPNHATDIADIEM(DevExpress.XtraEditors.XtraForm parent, DIADIEM data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new DIADIEM();
        }
        private void F_CAPNHATDIADIEM_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
        }
        private void bingdingConTrols()
        {
            txtMaDD.DataBindings.Add("EditValue", oriData, "MADIADIEM");
            txtTenDD.DataBindings.Add("EditValue", oriData, "TENDIADIEM");
            numericQuangDuong.DataBindings.Add("Value", oriData, "QUANGDUONG", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiDung.DataBindings.Add("EditValue", oriData, "NOIDUNG");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CDIADIEM();
            if (!isNew)
            {
                if (numericQuangDuong.Value == 0)
                {
                    MessageBox.Show("Quảng đường không được bằng 0");
                    return;
                }

                if (string.IsNullOrEmpty(txtTenDD.Text))
                {
                    dxErrorProvider1.SetError(txtTenDD, "Tên địa điểm không được rổng");
                    return;
                }

                if(string.IsNullOrEmpty(txtNoiDung.Text))
                {
                    dxErrorProvider1.SetError(txtNoiDung, "Nội dung không được rổng");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn cập nhật chức vụ " + txtTenDD.Text + " ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    kh.capnhatDiaDiem(oriData);
                    MessageBox.Show("Bạn đã cập nhật địa điểm " + txtTenDD.Text +" thành công");
                    this.Close();

            }
            else
            {
                if (numericQuangDuong.Value == 0)
                {
                    MessageBox.Show("Quảng đường không được bằng 0");
                    return;
                }

                if (string.IsNullOrEmpty(txtTenDD.Text))
                {
                    dxErrorProvider1.SetError(txtTenDD, "Tên địa điểm không được rổng");
                    return;
                }

                if (string.IsNullOrEmpty(txtNoiDung.Text))
                {
                    dxErrorProvider1.SetError(txtNoiDung, "Nội dung không được rổng");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn cập nhật chức vụ " + txtTenDD.Text + " ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     kh.themDiaDiem(oriData);
                     MessageBox.Show("Bạn đã thêm địa điểm " + txtTenDD.Text + " thành công");
                     this.Close();
            }

        
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            this.Close();
        }

        private void F_CAPNHATDIADIEM_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSDIADIEM)
            {
                ((F_DSDIADIEM)parent).loadDaTaSource();
            }
        }
    }
}
