using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class SETTOUR : PHUONGTIENView
    {
        public int MATOUR { get; set; }
        public string TENTOUR { get; set; }
        public string TENNH { get; set; }
        public string TENKS { get; set; }
        public int MAKH { get; set; }
        public string TENKH { get; set; }
        public int THOIGIAN { get; set; }
        public bool?LOAITOUR { get; set; }
        public int MANV { get; set; }
        public string TENNV { get; set; }
        public int MANH { get; set; }
       
        //public int? MATX { get; set; }
        //public int? MAXE { get; set; }
        public int MAKS { get; set; }
        public int MAHD { get; set; }
        public int TONGGIATRI { get; set; }
        //public string GHICHU { get; set; }
        //public string TENXE { get; set; }
        //public string TENTX { get; set; }
    }
    public class CSETTOUR : DataContext
    {
        public List<SETTOUR> layDSSETTOUR()
        {
            var data = (from hd in db.HOADONs
                        join tour in db.TOURs on hd.MAKH equals tour.MATOUR
                        join kh in db.KHACHHANGs on hd.MAKH equals kh.MAKH
                        join pt in db.PHUONGTIENs on hd.MAPT equals pt.MAPT
                        join ks in db.KHACHSANs on hd.MAKS equals ks.MAKS
                        join nh in db.NHAHANGs on hd.MANH equals nh.MANH
                        join tx in db.TAIXEs on pt.MATX equals tx.MATX
                        join xe in db.XEs on pt.MAXE equals xe.MAXE
                        select new SETTOUR
                        {
                            MAHD = hd.MAHOADON,
                            MATOUR = hd.MATOUR,
                            TENKS = ks.TENKS,
                            TENNH = nh.TENNH,
                            TENKH = kh.TENKH,
                            MAKH = kh.MAKH,
                            MAPT = pt.MAPT,
                            TENTX = tx.TENTX,
                            TENXE=xe.TENXE,
                            MATX = tx.MATX,
                            MAXE = xe.MAXE,
                            MAKS = hd.MAKS,
                            TONGGIATRI = hd.TONGGIATRI,
                            GHICHU = hd.GHICHU,
                        }).ToList();
            return data;
        }

        public bool themSETTOUR(SETTOUR nv)
        {
            var tour = new HOADON();
            tour.MATOUR = nv.MATOUR;
            tour.MANH = nv.MANH;
            tour.MAKS = nv.MAKS;
            //tour.MAPT = nv.MAPT;
            tour.MAKH = nv.MAKH;
            tour.MAHOADON = nv.MAHD;
            tour.TONGGIATRI = nv.TONGGIATRI;
            tour.GHICHU = nv.GHICHU;
            db.HOADONs.InsertOnSubmit(tour);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatSETTOUR(SETTOUR nv)
        {
            var tour = db.TOURs.SingleOrDefault(x => x.MATOUR == nv.MATOUR);
            tour.TENTOUR = nv.TENTOUR;
            tour.MANH = nv.MANH;
            tour.MAKS = nv.MAKS;
            tour.MAPT = nv.MAPT;
            tour.MAKH = nv.MAKH;
            tour.LOAITOUR = nv.LOAITOUR;
            tour.THOIGIAN = nv.THOIGIAN;
            tour.GHICHU = nv.GHICHU;

            DataContext.Update();
            return true;
        }

        public bool xoaSETTOUR(SETTOUR nv)
        {
            var tour = db.TOURs.SingleOrDefault(x => x.MATOUR == nv.MATOUR);
            db.TOURs.DeleteOnSubmit(tour);
            db.SubmitChanges();
            return true;
        }
    }
}
