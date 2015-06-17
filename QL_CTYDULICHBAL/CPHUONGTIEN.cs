using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class PHUONGTIENView
    {
        public int? MAPT { get; set; }
        public int? MATX { get; set; }
        public int? MAXE { get; set; }
        public string TENTX { get; set; }
        public string TENXE { get; set; }
        public int DONGIAPT { get; set; }
        public int DONGIAXE { get; set; }
        public int DONGIATX { get; set; }
        public bool RANH { get; set; }
        public string GHICHU { get; set; }

        public string TENPT
        {
            get { return TENTX + " --- " + TENXE; }
        }
    }


    public class CPHUONGTIEN : DataContext
    {
        public List<PHUONGTIEN> layDSPHUONGTIEN()
        {
            return db.PHUONGTIENs.ToList();
        }

        public List<PHUONGTIENView> layDSPHUONGTIENView()
        {
            var data =
                (from phuongtien in db.PHUONGTIENs
                 join tx in db.TAIXEs on phuongtien.MATX equals tx.MATX
                 join xe in db.XEs on phuongtien.MAXE equals xe.MAXE
                 where phuongtien.RANH == true
                 select new PHUONGTIENView
                 {
                     TENXE = xe.TENXE,
                     TENTX = tx.TENTX,
                     MATX = tx.MATX,
                     MAXE = xe.MAXE,
                     MAPT = phuongtien.MAPT,
                     RANH = phuongtien.RANH,
                     DONGIAPT = phuongtien.DONGIAPT,
                     DONGIATX = tx.DONGIATX,
                     DONGIAXE = xe.DONGIAXE,
                     GHICHU = phuongtien.GHICHU,
                 }).ToList();
            return data;
            //return db.PHUONGTIENs.ToList();
        }
        public List<PHUONGTIENView> layDSPHUONGTIENAll()
        {
            var data =
                (from phuongtien in db.PHUONGTIENs
                 join tx in db.TAIXEs on phuongtien.MATX equals tx.MATX
                 join xe in db.XEs on phuongtien.MAXE equals xe.MAXE
                 select new PHUONGTIENView
                 {
                     MATX = phuongtien.MATX,
                     TENTX = tx.TENTX,
                     MAXE = phuongtien.MAXE,
                     TENXE = xe.TENXE,
                     MAPT = phuongtien.MAPT,
                     DONGIATX = tx.DONGIATX,
                     DONGIAXE = xe.DONGIAXE,
                     DONGIAPT = phuongtien.DONGIAPT,
                     RANH = phuongtien.RANH,
                     GHICHU = phuongtien.GHICHU,
                 }).ToList();
            return data;
            //return db.PHUONGTIENs.ToList();
        }
        

        public bool themPHUONGTIEN(PHUONGTIENView pt)
        {
            var phuongtien = new PHUONGTIEN();
            phuongtien.MATX = pt.MATX;
            phuongtien.MAXE = pt.MAXE;
            phuongtien.GHICHU = pt.GHICHU;
            phuongtien.RANH = pt.RANH;
            phuongtien.DONGIAPT = tinhDONGIAPT(pt);
            db.PHUONGTIENs.InsertOnSubmit(phuongtien);
            db.SubmitChanges();
            return true;
        }

        public bool xoaPHUONGTIEN(PHUONGTIENView pt)
        {
            var phuongtien = db.PHUONGTIENs.SingleOrDefault(x => x.MAPT == pt.MAPT);
            
            db.PHUONGTIENs.DeleteOnSubmit(phuongtien);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatPHUONGTIEN(PHUONGTIENView pt)
        {
            var phuongtien = db.PHUONGTIENs.SingleOrDefault(x => x.MAPT == pt.MAPT);
            phuongtien.MATX = pt.MATX;
            phuongtien.MAXE = pt.MAXE;
            phuongtien.DONGIAPT = tinhDONGIAPT(pt);
            phuongtien.GHICHU = pt.GHICHU;
            phuongtien.RANH = pt.RANH;

            DataContext.Update();
            return true;
        }    

        public int tinhDONGIAPT(PHUONGTIENView pt)
        {
            return pt.DONGIATX + pt.DONGIAXE;
        }
    }
}
