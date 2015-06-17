using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CFILE : DataContext
    {
        public List<FILE> layDSFILE()
        {
            return db.FILEs.ToList();
        }

        public bool themFILE(FILE them)
        {
            db.FILEs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaFILE(FILE xoa)
        {
            db.FILEs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatFILE(FILE sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
