using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class CCHUCVU : DataContext
    {
        public List<CHUCVU> layDSChucVu()
        {
            return db.CHUCVUs.ToList();
        }

        public bool themCHUCVU(CHUCVU them)
        {
            db.CHUCVUs.InsertOnSubmit(them);
            db.SubmitChanges();
            return true;
        }

        public bool xoaCHUCVU(CHUCVU xoa)
        {
            db.CHUCVUs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatCHUCVU(CHUCVU sua)
        {
            DataContext.Update();
            return true;
        }
    }
}
