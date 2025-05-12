using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUNGTU_CT
    {
        private Entities db;
        public CHUNGTU_CT()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_CHUNGTU_CT> getAll()
        {
            return db.tb_CHUNGTU_CT.ToList();
        }
        public List<tb_CHUNGTU_CT> getByKhoa(Guid _khoa)
        {
            return db.tb_CHUNGTU_CT.Where(p => p.KHOA == _khoa).ToList();
        }
        public List<obj_CHUNGTU_CT> getListByKhoaFull(Guid khoa)
        {
            var lst = db.tb_CHUNGTU_CT.Where(x => x.KHOA == khoa).ToList();
            List<obj_CHUNGTU_CT> lsct = new List<obj_CHUNGTU_CT>();
            obj_CHUNGTU_CT obj;
            foreach(var i in lst)
            {
                obj = new obj_CHUNGTU_CT();
                obj.KHOACT = i.KHOACT;
                obj.KHOA = i.KHOA;
                obj.BARCODE = i.BARCODE;
                var h = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == i.BARCODE);
                obj.TENHH = h.TENHH;
                obj.DVT = h.DVT;
                obj.SOLUONGCT = i.SOLUONGCT;
                obj.DONGIA = i.DONGIA;
                obj.CHIETKHAU = i.CHIETKHAU;
                obj.THANHTIEN = i.THANHTIEN;
                obj.STT = i.STT;
                obj.NGAY = i.NGAY;
                lsct.Add(obj);
            }
            return lsct;
        }
        public tb_CHUNGTU_CT add(tb_CHUNGTU_CT ct)
        {
            try
            {
                db.tb_CHUNGTU_CT.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tb_CHUNGTU_CT update(tb_CHUNGTU_CT ct)
        {
            tb_CHUNGTU_CT _ct = db.tb_CHUNGTU_CT.FirstOrDefault(x => x.KHOACT == ct.KHOACT);
            if(_ct != null)
            {
                _ct.KHOA = ct.KHOA;
                _ct.BARCODE = ct.BARCODE;
                _ct.SOLUONGCT = ct.SOLUONGCT;
                _ct.DONGIA = ct.DONGIA;
                _ct.CHIETKHAU = ct.CHIETKHAU;
                _ct.THANHTIEN = ct.THANHTIEN;
                _ct.NGAY = ct.NGAY;
            }
            try
            {
                db.SaveChanges();
                return _ct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void deleteAll(Guid khoa)
        {
            List<tb_CHUNGTU_CT> lsct = db.tb_CHUNGTU_CT.Where(x => x.KHOA == khoa).ToList();
            try
            {
                if (lsct != null)
                {
                    foreach (var i in lsct)
                    {
                        db.tb_CHUNGTU_CT.Remove(i);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
