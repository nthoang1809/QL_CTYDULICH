using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CNHAHANG : DataContext
    {
        public List<NHAHANG> layDSNHAHANG()
        {
            return db.NHAHANGs.ToList();
        }

        public List<NHAHANG> layDSNHAHANG_DIADIEM(int madd)
        {
            return db.NHAHANGs
                .Where(x => x.MADIADIEM == madd)
                .ToList();
        }

        public bool themNHAHANG(NHAHANG them)
        {
            db.NHAHANGs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaNHAHANG(NHAHANG xoa)
        {
            db.NHAHANGs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatNHAHANG(NHAHANG sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
