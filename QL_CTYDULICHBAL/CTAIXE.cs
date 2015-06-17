using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CTAIXE : DataContext
    {
        public List<TAIXE> layDSTAIXE()
        {
            return db.TAIXEs.ToList();
        }

        public bool themTAIXE(TAIXE them)
        {
            db.TAIXEs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaTAIXE(TAIXE xoa)
        {
            db.TAIXEs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatTAIXE(TAIXE sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
