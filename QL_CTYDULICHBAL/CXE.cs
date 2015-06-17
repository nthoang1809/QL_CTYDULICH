using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CXE : DataContext
    {
        public XE layXEView(int maxe)
        {
            return db.XEs.SingleOrDefault(xe => xe.MAXE == maxe);
        }

        public List<XE> layDSXE()
        {
            return db.XEs.ToList();
        }

        public bool themXE(XE them)
        {
            db.XEs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaXE(XE xoa)
        {
            db.XEs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatXE(XE sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
