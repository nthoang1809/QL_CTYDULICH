using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QL_CTYDULICH.F_ListFORM;
using QL_CTYDULICH.F_UpdateFORM;

namespace QL_CTYDULICH
{
    public partial class QL_CTYDULICH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QL_CTYDULICH()
        {
            InitializeComponent();
        }

        private void QL_CTYDULICH_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //ribbon.Enabled = false;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            repositoryItemTextEdit1.NullText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
      private Form KiemTraFormTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }
      private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSKHACHHANG));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSKHACHHANG fTrangChu = new F_DSKHACHHANG();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSCHUCVU));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSCHUCVU fTrangChu = new F_DSCHUCVU();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSNHANVIEN));
      
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSNHANVIEN fTrangChu = new F_DSNHANVIEN();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSTOUR));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSTOUR fTrangChu = new F_DSTOUR();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSKHACHHANG));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSKHACHHANG fTrangChu = new F_DSKHACHHANG();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

        //Quản lý File còn trống
      private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
      {

      }

      private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSDIADIEM));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSDIADIEM fTrangChu = new F_DSDIADIEM();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSNHAHANG));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSNHAHANG fTrangChu = new F_DSNHAHANG();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSKHACHSAN));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSKHACHSAN fTrangChu = new F_DSKHACHSAN();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSXE));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSXE fTrangChu = new F_DSXE();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSTAIXE));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSTAIXE fTrangChu = new F_DSTAIXE();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void QL_CTYDULICH_FormClosed(object sender, FormClosedEventArgs e)
      {
        
      }

      private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
      {
          F_LOGIN frm = new F_LOGIN();
          frm.Show();
      }

      private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSPHUONGTIEN));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSPHUONGTIEN fTrangChu = new F_DSPHUONGTIEN();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSDATTOUR));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSDATTOUR fTrangChu = new F_DSDATTOUR();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }

      private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
      {
          Form f = KiemTraFormTonTai(typeof(F_DSDATTOUR));
          if (f != null)
          {
              f.Activate();
          }
          else
          {
              F_DSDATTOUR fTrangChu = new F_DSDATTOUR();
              fTrangChu.MdiParent = this;
              fTrangChu.Show();
          }  
      }
    }
}