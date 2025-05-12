using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HANGHOA
    {
        private Entities db;
        public HANGHOA()
        {
            db = Entities.CreateEntities();
        }
        NHACUNGCAP _ncc = new NHACUNGCAP();
        public tb_HANGHOA getItem(string barcode)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == barcode);
        }
        public obj_HANGHOA getItemFull(string barcode)
        {
            var obj = db.tb_HANGHOA.Where(x => x.BARCODE == barcode).FirstOrDefault();
            obj_HANGHOA hh;
            hh = new obj_HANGHOA();
            hh.BARCODE = barcode;
            hh.TENHH = obj.TENHH;
            hh.TENTAT = obj.TENTAT;
            hh.IDNHOM = obj.IDNHOM;
            var n = db.tb_NHOMHH.FirstOrDefault(x=>x.IDNHOM == obj.IDNHOM);
            hh.TENNHOM = n.TENNHOM;
            hh.MANCC = obj.MANCC;
            var c = db.tb_NHACUNGCAP.FirstOrDefault(x => x.MANCC == obj.MANCC);
            hh.TENNCC = c.TENNCC;
            hh.MAXX = obj.MAXX;
            var xx = db.tb_XUATXU.FirstOrDefault(x => x.ID == obj.MAXX);
            hh.TENXX = xx.TEN;
            hh.DVT = obj.DVT;
            hh.DONGIA = obj.DONGIA;
            hh.MOTA = obj.MOTA;
            return hh;
        }

        public tb_HANGHOA getItemByTen(string tenhh)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.TENHH == tenhh);
        }
        public List<tb_HANGHOA> getList()
        {
            return db.tb_HANGHOA.ToList();
        }
        public List<tb_HANGHOA> getListbyNhom(int idnhom)
        {
            return db.tb_HANGHOA.Where(p => p.IDNHOM == idnhom).OrderBy(p => p.CREATED_DATE).ToList();
        }
        public List<tb_HANGHOA> getListByKeyword(string keyword)
        {
            return db.tb_HANGHOA.Where(p => p.TENHH.Contains(keyword) || p.BARCODE.Contains(keyword)).OrderBy(p => p.CREATED_DATE).ToList();
        }
        public bool checkExist(string barcode)
        {
            return db.tb_HANGHOA.Any(x => x.BARCODE == barcode);
        }
        public tb_HANGHOA add(tb_HANGHOA hh)
        {
            db.tb_HANGHOA.Add(hh);
            try
            {
                db.SaveChanges();
                return hh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding item: " + ex.Message);
            }
        }
        public void update(tb_HANGHOA hh)
        {
            tb_HANGHOA _hh= db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == hh.BARCODE);
            if (_hh != null)
            {
                _hh.TENHH= hh.TENHH;
                _hh.TENTAT = hh.TENTAT;
                _hh.DVT = hh.DVT;
                _hh.DONGIA = hh.DONGIA;
                _hh.MANCC = hh.MANCC;
                _hh.MAXX = hh.MAXX;
                _hh.MOTA = hh.MOTA;
                _hh.IDNHOM = hh.IDNHOM;
                _hh.DISABLE = hh.DISABLE;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating item: " + ex.Message);
                }
            }
        }
        public void delete(string barcode)
        {
            tb_HANGHOA _hh = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == barcode);
            if (_hh != null)
            {
                _hh.DISABLE = true;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting item: " + ex.Message);
                }
            }
        }
    }
}
