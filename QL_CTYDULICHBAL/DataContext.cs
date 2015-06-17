using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public abstract class DataContext
    {
        protected static QL_CTYDULICHDataContext db = new QL_CTYDULICHDataContext();

        public static void Update()
        {
            db.SubmitChanges();
        }

        public void Refresh(object obj)
        {
            db.Refresh(RefreshMode.OverwriteCurrentValues, obj);
        }
    }
}
