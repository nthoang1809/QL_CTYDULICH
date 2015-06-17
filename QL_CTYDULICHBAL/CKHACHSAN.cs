using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CKHACHSAN : DataContext
    {
        public List<KHACHSAN> layDSKHACHSAN()
        {
            return db.KHACHSANs.ToList();
        }

        public List<KHACHSAN> layDSKHACHSAN_DIADIEM(int madd)
        {
            return db.KHACHSANs
                .Where(x => x.MADIADIEM == madd)
                .ToList();
        }
        //public List<TOUR> layDSKHACHSAN_TOUR(int madd)
        //{
        //    return db.KHACHSANs
        //        .Where(x => x. == madd)
        //        .ToList();
        //}
        public bool themKHACHSAN(KHACHSAN them)
        {
            db.KHACHSANs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaKHACHSAN(KHACHSAN xoa)
        {
            db.KHACHSANs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatKHACHSAN(KHACHSAN sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
