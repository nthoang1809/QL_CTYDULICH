using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QL_CTYDULICHDAL;
using QL_CTYDULICHBAL;

namespace QL_CTYDULICH
{
    public partial class F_CAPNHATKHACHHANG : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        KHACHHANG oriData;
        bool isNew;

        public F_CAPNHATKHACHHANG()
        {
            InitializeComponent();
        }
        public F_CAPNHATKHACHHANG(DevExpress.XtraEditors.XtraForm parent, KHACHHANG data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new KHACHHANG();
        }

        private void F_CAPNHATKHACHHANG_Load(object sender, EventArgs e)
        {
            parent.Enabled = false;
            bindingControls();
        }

        private void bindingControls()
        {
            txtMaKH.DataBindings.Add("EditValue", oriData, "MAKH");
            txtTenKH.DataBindings.Add("EditValue", oriData, "TENKH");
            txtEmail.DataBindings.Add("EditValue", oriData, "EMAILKH");
            txtCMND.DataBindings.Add("EditValue", oriData, "CMNDKH");
            txtDT.DataBindings.Add("EditValue", oriData, "DTKH");
            txtDiaChi.DataBindings.Add("EditValue", oriData, "DCKH");
            dtNgaySinh.DataBindings.Add("EditValue", oriData, "NSKH", true, DataSourceUpdateMode.OnPropertyChanged);
            radGioiTinh.DataBindings.Add("EditValue", oriData, "GTKH", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnluukh_Click(object sender, EventArgs e)
        {
            var kh = new CKHACHHANG();
            if (!isNew)
            {
                if(string.IsNullOrEmpty(txtTenKH.Text))
                {
                    dxErrorProvider1.SetError(txtTenKH, "Tên khách hàng không được rỗng");
                    return;
                }

                if (string.IsNullOrEmpty(txtDT.Text))
                {
                    dxErrorProvider1.SetError(txtDT, "Số điện thoại không được rỗng");
                    return;
                }

                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    dxErrorProvider1.SetError(txtDiaChi, "Địa chỉ không được rỗng");
                    return;
                }

                if (string.IsNullOrEmpty(txtCMND.Text))
                {
                    dxErrorProvider1.SetError(txtCMND, "Chứng minh thư không được rỗng");
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    dxErrorProvider1.SetError(txtEmail, "Email không được rỗng");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn cập nhật khách hàng " + txtTenKH.Text + " ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kh.capnhatKhachHang(oriData);
                    MessageBox.Show("Bạn đã cập nhật thành công khách hàng " + txtTenKH.Text + "!!!");
                    this.Close();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    dxErrorProvider1.SetError(txtTenKH, "Tên khách hàng không được rỗng");
                    return;
                }
                else
                if (string.IsNullOrEmpty(txtDT.Text))
                {
                    dxErrorProvider1.SetError(txtDT, "Số điện thoại không được rỗng");
                    return;
                }
                else

                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    dxErrorProvider1.SetError(txtDiaChi, "Địa chỉ không được rỗng");
                    return;
                }
                else

                if (string.IsNullOrEmpty(txtCMND.Text))
                {
                    dxErrorProvider1.SetError(txtCMND, "Chứng minh thư không được rỗng");
                    return;
                }
                else

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    dxErrorProvider1.SetError(txtEmail, "Email không được rỗng");
                    return;
                }
                else
                    
                if (MessageBox.Show("Bạn có muốn thêm khách hàng " + txtTenKH.Text + " ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        kh.themKhachHang(oriData);
                        MessageBox.Show("Bạn đã thêm thành công khách hàng " + txtTenKH.Text + "!!!");
                        this.Close();
                    }
                }
            }

        private void F_CAPNHATKHACHHANG_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSKHACHHANG)
            {
                ((F_DSKHACHHANG)parent).loadDataSource();
            }
        }

        private void btnresetkh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!isNew)
                {
                    var nh = new CKHACHHANG();
                    nh.Refresh(oriData);
                }
                this.Close();
            }
        }
    }
}