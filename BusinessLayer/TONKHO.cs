using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TONKHO
    {
        Entities db;
        public TONKHO()
        {
            db = Entities.CreateEntities();
        }
        public bool TinhTon(string madvi, DateTime ngay)
        {
            try
            {
                db.TINH_TONKHO_DONVI(ngay, madvi);
                return true;
            }
            catch  (Exception ex) 
            { 
                
                return false;
                throw new Exception("Lỗi: " + ex.Message);
            }
            
        }
        public List<obj_TONKHO> getTonKhoCty(string macty, int nam, int ky)
        {
            var tk = db.tb_TONKHO.Where(x => x.MACTY == macty && x.NAM == nam && x.KY == ky).ToList();
            List<obj_TONKHO> lstTk = new List<obj_TONKHO>();
            obj_TONKHO jtk;
            foreach (var item in tk)
            {
                jtk = new obj_TONKHO();
                jtk.BARCODE = item.BARCODE;
                var hh = db.tb_HANGHOA.FirstOrDefault(h => h.BARCODE == item.BARCODE);
                jtk.TENHH = hh.TENHH;
                jtk.DVT = hh.DVT;
                jtk.LG_DAU = item.LG_DAU;
                jtk.LG_NHAPMUA = item.LG_NHAPMUA;
                jtk.LG_NHAPNB = item.LG_NHAPNB;
                jtk.LG_XUATNB = item.LG_XUATNB;
                jtk.LG_XUATSI = item.LG_XUATSI;
                jtk.LG_BANLE = item.LG_BANLE;
                jtk.LG_CUOI = item.LG_CUOI;
                jtk.TRIGIA = item.TRIGIA;
                jtk.TIEN_CUOI = item.TIEN_CUOI;
                jtk.MACTY = item.MACTY;
                jtk.MADV = item.MADV;
                jtk.NAMKY = item.NAMKY;
                jtk.NAM = item.NAM;
                jtk.KY = item.KY;
                lstTk.Add(jtk);
            }
            return lstTk;
        }
        public List<obj_TONKHO> getTonKhoDvi(string macty,string madvi, int nam, int ky)
        {
            var tk = db.tb_TONKHO.Where(x => x.MACTY == macty && x.MADV == madvi && x.NAM == nam && x.KY == ky).ToList();
            List<obj_TONKHO> lstTk = new List<obj_TONKHO>();
            obj_TONKHO jtk;
            foreach (var item in tk)
            {
                jtk = new obj_TONKHO();
                jtk.BARCODE = item.BARCODE;
                var hh = db.tb_HANGHOA.FirstOrDefault(h => h.BARCODE == item.BARCODE);
                jtk.TENHH = hh.TENHH;
                jtk.DVT = hh.DVT;
                jtk.LG_DAU = item.LG_DAU;
                jtk.LG_NHAPMUA = item.LG_NHAPMUA;
                jtk.LG_NHAPNB = item.LG_NHAPNB;
                jtk.LG_XUATNB = item.LG_XUATNB;
                jtk.LG_XUATSI = item.LG_XUATSI;
                jtk.LG_BANLE = item.LG_BANLE;
                jtk.LG_CUOI = item.LG_CUOI;
                jtk.TRIGIA = item.TRIGIA;
                jtk.TIEN_CUOI = item.TIEN_CUOI;
                jtk.MACTY = item.MACTY;
                jtk.MADV = item.MADV;
                jtk.NAMKY = item.NAMKY;
                jtk.NAM = item.NAM;
                jtk.KY = item.KY;
                lstTk.Add(jtk);
            }
            return lstTk;
        }
    }
}
