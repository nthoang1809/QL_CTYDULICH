using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_CTYDULICH
{
    public partial class F_LOGIN : DevExpress.XtraEditors.XtraForm
    {
        
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void F_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txttaikhoan.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Thông Báo", "Đăng nhập thất bại");

            }
            else
            {
                this.Hide();
                QL_CTYDULICH fmain = new QL_CTYDULICH();
                fmain.Owner = this;
                fmain.Show();
                
           }
        }

       
    }
}