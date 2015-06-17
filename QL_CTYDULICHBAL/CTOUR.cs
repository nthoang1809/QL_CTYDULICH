using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICHBAL
{
    public class TOURView
    {
        public int MATOUR { get; set; }
        public string TENTOUR { get; set; }
        public int? MANH { get; set; }
        public int? MADIADIEM { get; set; }
        public int? MAKS { get; set; }
        public string TENKS { get; set; }
        public int? THOIGIAN { get; set; }
        public bool? LOAITOUR { get; set; }
        public string GHICHU { get; set; }
        public int? MAPT { get; set; }
        public int? MATX { get; set; }
        public int? MAXE { get; set; }
        public bool? DACDIEMNH { get; set; }
        public bool? DACDIEMKS { get; set; }
        public string TENTX { get; set; }
        public string TENXE { get; set; }
        public string TENNH { get; set; }
        public int MAKH { get; set; }
        public string TENKH { get; set; }
        public string TENPT
        {
            get { return TENTX + " --- " + TENXE; }
        }
    }

    public class CTOUR : DataContext
    {
        public List<TOURView> layDSTOUR()
        {
            var data =
                (from tour in db.TOURs
                 join pt in db.PHUONGTIENs on tour.MAPT equals pt.MAPT
                 join xe in db.XEs on pt.MAXE equals xe.MAXE
                 join tx in db.TAIXEs on pt.MATX equals tx.MATX
                 join nh in db.NHAHANGs on tour.MANH equals nh.MANH
                 join ks in db.KHACHSANs on tour.MAKS equals ks.MAKS
                 //join kh in db.KHACHHANGs on tour.MAKH equals kh.MAKH
                 select new TOURView
                 {
                     MATOUR = tour.MATOUR,
                     MANH = tour.MANH,
                     MAKS = tour.MAKS,
                     MAPT = pt.MAPT,
                     MATX = pt.MATX,
                     MAXE = pt.MAXE,
                     TENTX = tx.TENTX,
                     TENXE = xe.TENXE,
                     //MAKH = kh.MAKH,
                     TENKS = ks.TENKS,
                     TENNH = nh.TENNH,
                     GHICHU = tour.GHICHU,
                     TENTOUR = tour.TENTOUR,
                     MADIADIEM = tour.MADIADIEM,
                     THOIGIAN = tour.THOIGIAN,
                     LOAITOUR = tour.LOAITOUR,
                     DACDIEMNH = nh.DACDIEMNH,
                     DACDIEMKS = ks.DACDIEMKS,
                     //TENKH = kh.TENKH,
                 }).ToList();
            return data;
            //return db.TOURs.ToList();
        }

        public TOURView layTourView(int matour)
        {
            var data =
                (from tour in db.TOURs
                 join nh in db.NHAHANGs on tour.MANH equals nh.MANH
                 join ks in db.KHACHSANs on tour.MAKS equals ks.MAKS
                 join pt in db.PHUONGTIENs on tour.MAPT equals pt.MAPT
                 join xe in db.XEs on pt.MAXE equals xe.MAXE
                 join tx in db.TAIXEs on pt.MATX equals tx.MATX
                 where tour.MATOUR == matour
                 select new TOURView
                 {
                     MATOUR = tour.MATOUR,
                     MAPT = tour.MAPT,
                     MANH = tour.MANH,
                     MAKS = tour.MAKS,
                     TENKS = ks.TENKS,
                     MAXE = pt.MAXE,
                     MATX = pt.MATX,
                     TENTX = tx.TENTX,
                     TENXE = xe.TENXE,
                     TENNH = nh.TENNH,
                     TENTOUR = tour.TENTOUR,
                 }).FirstOrDefault();
            return data;
        }

        public bool themTOUR(TOURView nv)
        {
            var tour = new TOUR();
            tour.TENTOUR = nv.TENTOUR;
            tour.MANH = nv.MANH;
            tour.MAKS = nv.MAKS;
            tour.MAPT = nv.MAPT;
            //tour.MAKH = nv.MAKH;
            tour.MADIADIEM = nv.MADIADIEM;
            tour.THOIGIAN = nv.THOIGIAN;
            tour.LOAITOUR = nv.LOAITOUR;
            tour.GHICHU = nv.GHICHU;

            db.TOURs.InsertOnSubmit(tour);
            db.SubmitChanges();
            return true;
        }

        public bool capnhatTOUR(TOURView nv)
        {
            var tour = db.TOURs.SingleOrDefault(x => x.MATOUR == nv.MATOUR);
            tour.TENTOUR = nv.TENTOUR;
            tour.MANH = nv.MANH;
            tour.MAKS = nv.MAKS;
            tour.MAPT = nv.MAPT;
            //tour.MAKH = nv.MAKH;
            tour.MADIADIEM = nv.MADIADIEM;
            tour.THOIGIAN = nv.THOIGIAN;
            tour.LOAITOUR = nv.LOAITOUR;
            tour.GHICHU = nv.GHICHU;

            DataContext.Update();
            return true;
        }

        public bool xoaTOUR(TOURView nv)
        {
            var tour = db.TOURs.SingleOrDefault(x => x.MATOUR == nv.MATOUR);
            db.TOURs.DeleteOnSubmit(tour);
            db.SubmitChanges();
            return true;
        }
    }
}
