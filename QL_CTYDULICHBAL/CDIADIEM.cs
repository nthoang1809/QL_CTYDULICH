using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CDIADIEM :DataContext
    {
        public List<DIADIEM> layDSDiaDiem()
        {
            return db.DIADIEMs.ToList();
        }

        public bool themDiaDiem(DIADIEM them)
        {
            db.DIADIEMs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaDiaDiem(DIADIEM xoa)
        {
            db.DIADIEMs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatDiaDiem(DIADIEM sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
