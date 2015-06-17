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
    public partial class F_CAPNHATNHAHANG : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        NHAHANG oriData;
        bool isNew;
       
        public F_CAPNHATNHAHANG()
        {
            InitializeComponent();
        }

         public F_CAPNHATNHAHANG(DevExpress.XtraEditors.XtraForm parent, DIADIEM data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            
        }

      
        private void F_CAPNHATNHAHANG_Load(object sender, EventArgs e)
        {

        }
    }
}