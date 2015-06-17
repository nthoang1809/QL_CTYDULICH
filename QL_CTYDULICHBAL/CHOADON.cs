using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;


namespace QL_CTYDULICHBAL
{
    public class HOADONView
    {
        public int MAHD { get; set; }
        public int? MATOUR { get; set; }
        public string TENTOUR { get; set; }
        public int MAKH { get; set; }
        public string TENKH { get; set; }
        public int MANV { get; set; }
        public string TENNV { get; set; }
        public int THANHTIEN { get; set; }
        public string GHICHU { get; set; }
        public int MAKS { get; set; }
        public int TONGGIATRI { get; set; }
        public int MANH { get; set; }
        public int? MAXE { get; set; }
        public int? MATX { get; set; }
        public int MAPT { get; set; }
        public string TENTX { get; set; }
        public string TENXE { get; set; }
        public string TENNH { get; set; }
        public string TENKS { get; set; }
        public int DONGIAKS { get; set; }
        public int DONGIANH { get; set; }

        public string TENPT
        {
            get { return TENTX + " --- " + TENXE; }
        }
        public int SOVE { get; set; }
        public int HOANTRA { get; set; }
    }
    public class CHOADON : DataContext
    {
        public List<HOADONView>layDSHD()
        {
            var data =
            (from hd in db.HOADONs
             join kh in db.KHACHHANGs on hd.MAKH equals kh.MAKH
             join tour in db.TOURs on hd.MATOUR equals tour.MATOUR
             join nv in db.NHANVIENs on hd.MANV equals nv.MANV
             join nh in db.NHAHANGs on hd.MANH equals nh.MANH
             join ks in db.KHACHSANs on hd.MAKS equals ks.MAKS
             join pt in db.PHUONGTIENs on hd.MAPT equals pt.MAPT
             join xe in db.XEs on pt.MAXE equals xe.MAXE
             join tx in db.TAIXEs on pt.MATX equals tx.MATX
             select new HOADONView
             {
                 MAHD = hd.MAHOADON,
                 MAKH = hd.MAKH,
                 MANV = hd.MANV,
                 MANH = hd.MANH,
                 MAKS = hd.MAKS,
                 MATOUR = hd.MATOUR,
                 GHICHU = hd.GHICHU,
                 TONGGIATRI = hd.TONGGIATRI,
                 TENKH = kh.TENKH,
                 TENNV = nv.TENNV,
                 TENNH = nh.TENNH,
                 TENKS = ks.TENKS,
                 TENTOUR = tour.TENTOUR,
                 MAPT = pt.MAPT,
                 TENTX = tx.TENTX,
                 TENXE = xe.TENXE
             }).ToList();
            return data;
        }
 
        public List<HOADON> layDSHOADON()
        {
            return db.HOADONs.ToList();
        }
        public bool themHOADON(HOADONView nv)
        {
            var hd = new HOADON();
            hd.MAKH = nv.MAKH;
            hd.MANV = nv.MANV;
            hd.MAPT = nv.MAPT;
            hd.MAKS = nv.MAKS;
            hd.MANH = nv.MANH;
            hd.SOVE = nv.SOVE;
            hd.MATOUR = nv.MATOUR ?? 0;
            hd.GHICHU = nv.GHICHU;
            hd.TONGGIATRI = nv.TONGGIATRI;
            hd.HOANTRA = nv.HOANTRA;

            db.HOADONs.InsertOnSubmit(hd);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatHOADON(HOADONView nv)
        {
            var hd = db.HOADONs.SingleOrDefault(x=>x.MAHOADON == nv.MAHD);
            hd.MAKH = nv.MAKH;
            hd.MANV = nv.MANV;
            hd.MAPT = nv.MAPT;
            hd.MAKS = nv.MAKS;
            hd.MANH = nv.MANH;
            hd.SOVE = nv.SOVE;
            hd.MATOUR = nv.MATOUR ?? 0;
            hd.GHICHU = nv.GHICHU;
            hd.TONGGIATRI = nv.TONGGIATRI;
            hd.HOANTRA = nv.HOANTRA;

            DataContext.Update();
            return true;
        }
        public bool xoaHOADON(HOADONView nv)
        {
            var hd = db.HOADONs.SingleOrDefault(x => x.MAHOADON == nv.MAHD);
            db.HOADONs.DeleteOnSubmit(hd);
            db.SubmitChanges();
            return true;
        }

    }
}
