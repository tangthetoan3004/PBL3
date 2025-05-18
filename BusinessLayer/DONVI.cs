using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVI
    {
        private Entities db;
        public DONVI()
        {
            db = Entities.CreateEntities();
        }
        public tb_DONVI getItem(string madvi)
        {
            return db.tb_DONVI.FirstOrDefault(p => p.MADV == madvi);
        }
        public List<tb_DONVI> getAll()
        {
            return db.tb_DONVI.ToList();
        }
        public List<tb_DONVI> getAllExcept(string macty,string madvi)
        {
            return db.tb_DONVI.Where(p => p.MACTY == macty && p.MADV != madvi).ToList();
        }
        public List<tb_DONVI> getAll(string macty)
        {
            return db.tb_DONVI.Where(p => p.MACTY == macty).ToList();
        }
        public List<tb_DONVI> getAllbyKho(string macty)
        {
            return db.tb_DONVI.Where(p => p.MACTY == macty && p.KHO == true).ToList();
        }
        public List<tb_DONVI> getDonViByCty(string macty, bool kho)
        {
            return db.tb_DONVI.Where(p => p.MACTY == macty && p.KHO == kho).ToList();
        }
        public void add(tb_DONVI dvi)
        {
            try
            {
                db.tb_DONVI.Add(dvi);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void update(tb_DONVI dvi)
        {
            tb_DONVI _dvi = db.tb_DONVI.FirstOrDefault(p => p.MADV == dvi.MADV);
            _dvi.MACTY = dvi.MACTY;
            _dvi.TENDVI = dvi.TENDVI;
            _dvi.DIENTHOAI = dvi.DIENTHOAI;
            _dvi.FAX = dvi.FAX;
            _dvi.EMAIL = dvi.EMAIL;
            _dvi.DIACHI = dvi.DIACHI;
            _dvi.DISABLED = dvi.DISABLED;
            _dvi.KHO = dvi.KHO;
            _dvi.KYHIEU = dvi.KYHIEU;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void delete(string madvi)
        {
            tb_DONVI _dvi = db.tb_DONVI.FirstOrDefault(p => p.MADV == madvi);
            _dvi.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
    }
}
