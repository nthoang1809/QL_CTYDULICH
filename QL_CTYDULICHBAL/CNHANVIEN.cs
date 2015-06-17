using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CNHANVIEN : DataContext
    {
        public List<NHANVIEN> layDSNhanVien()
        {
            return db.NHANVIENs.ToList();
        }
        public bool themNhanVien(NHANVIEN nv)
        {
            db.NHANVIENs.InsertOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }
        public bool capnhatNhanVien(NHANVIEN nv)
        {
            DataContext.Update();
            return true;
        }
        public bool xoaNhanVien(NHANVIEN manv)
        {
            db.NHANVIENs.DeleteOnSubmit(manv);
            db.SubmitChanges();
            return true;
        }
    }
}
