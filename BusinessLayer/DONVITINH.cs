using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DONVITINH
    {
        private Entities db;
        public DONVITINH()
        {
            try
            {
                db = Entities.CreateEntities();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kết nối tới cơ sở dữ liệu: " + ex.Message);
            }
        }
        public tb_DVT getItem(string ten)
        {
            return db.tb_DVT.FirstOrDefault(p => p.TEN == ten);
        }
        public tb_DVT getItem(int id)
        {
            return db.tb_DVT.FirstOrDefault(p  => p.ID == id);
        }
        public List<tb_DVT> getAll()
        {
            return db.tb_DVT.ToList();
        }
        public void add(tb_DVT dvt)
        {

            try
            {
                db.tb_DVT.Add(dvt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_DVT dvt) {
            tb_DVT _dvt = db.tb_DVT.FirstOrDefault(p => p.ID == dvt.ID);
            _dvt.TEN = dvt.TEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void delete(string ten)
        {
            tb_DVT dvt = db.tb_DVT.FirstOrDefault(p => p.TEN == ten);
            try
            {
                db.tb_DVT.Remove(dvt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
    }
}
