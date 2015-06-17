using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using QL_CTYDULICHDAL;


namespace QL_CTYDULICHBAL
{

    public class CKHACHHANG : DataContext
    {
        public List<KHACHHANG> layDSKhachHang()
        {
            return db.KHACHHANGs.ToList();
        }

        public bool themKhachHang(KHACHHANG kh)
        {
            db.KHACHHANGs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return true;
        }

        public bool xoaKhachHang(KHACHHANG kh)
        {
            db.KHACHHANGs.DeleteOnSubmit(kh);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatKhachHang(KHACHHANG kh)
        {
            DataContext.Update();
            return true;
        }
    }
}