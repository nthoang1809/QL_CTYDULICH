using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CKHUYENMAI : DataContext
    {
        public List<KHUYENMAI> layDSKHUYENMAI()
        {
            return db.KHUYENMAIs.ToList();
        }

        public bool themKHUYENMAI(KHUYENMAI nv)
        {
            db.KHUYENMAIs.InsertOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatKHUYENMAI(KHUYENMAI nv)
        {
            DataContext.Update();
            return true;
        }

        public bool xoaKHUYENMAI(KHUYENMAI xoa)
        {
            db.KHUYENMAIs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }
    }
}
