using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUNGTU
    {
        private Entities db;
        public CHUNGTU()
        {
            db = Entities.CreateEntities();
        }
        public tb_CHUNGTU getItem(Guid khoa)
        {
            return db.tb_CHUNGTU.FirstOrDefault(p => p.KHOA == khoa);
        }
        public List<tb_CHUNGTU> getAll()
        {
            return db.tb_CHUNGTU.ToList();
        }
        public List<tb_CHUNGTU> getList(int n,DateTime tungay,DateTime denngay, string madvi)
        {
            return db.tb_CHUNGTU.Where(x => x.NGAY >= tungay && x.NGAY <= denngay && x.MADVI == madvi && x.LCT == n).ToList();
        }
        public List<tb_CHUNGTU> getPhieuNhap(int n, DateTime tungay, DateTime denngay, string madvi)
        {
            return db.tb_CHUNGTU.Where(x => x.NGAY >= tungay && x.NGAY <= denngay && x.MADVI2 == madvi && x.LCT == n && x.TRANGTHAI == 2).ToList();
        }
        public tb_CHUNGTU add(tb_CHUNGTU ct)
        {
            db.tb_CHUNGTU.Add(ct);
            db.SaveChanges();
            return ct;
        }
        public tb_CHUNGTU update(tb_CHUNGTU ct)
        {
            tb_CHUNGTU _ct = db.tb_CHUNGTU.FirstOrDefault(p => p.KHOA == ct.KHOA);
            _ct.SCT = ct.SCT;
            _ct.SCT2 = ct.SCT2;
            _ct.NGAY = ct.NGAY;
            _ct.LCT = ct.LCT;
            _ct.NGAY2 = ct.NGAY2;
            _ct.SOLUONG = ct.SOLUONG;
            _ct.CHIETKHAU = ct.CHIETKHAU;
            _ct.TONGTIEN = ct.TONGTIEN;
            _ct.GHICHU = ct.GHICHU;
            _ct.MACTY = ct.MACTY;
            _ct.MADVI2 = ct.MADVI2;
            _ct.MADVI = ct.MADVI;
            _ct.TRANGTHAI = ct.TRANGTHAI;
            _ct.CREATED_DATE = ct.CREATED_DATE;
            _ct.CREATED_BY = ct.CREATED_BY;
            _ct.UPDATED_DATE = ct.UPDATED_DATE;
            _ct.UPDATED_BY = ct.UPDATED_BY;
            _ct.DELETED_DATE = ct.DELETED_DATE;
            _ct.DELETED_BY = ct.DELETED_BY;
            db.SaveChanges();
            return _ct;
        }
        public void delete(Guid khoa, int deletedBy)
        {
            tb_CHUNGTU _ct = db.tb_CHUNGTU.FirstOrDefault(p => p.KHOA == khoa);
            if (_ct != null)
            {
                _ct.DELETED_BY = deletedBy;
                _ct.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            else
            {
                throw new Exception($"Không tìm thấy phiếu với KHOA: {khoa}");
            }
        }
    }
}
