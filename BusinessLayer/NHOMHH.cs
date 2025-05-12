using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHOMHH
    {
        private Entities db;
        public NHOMHH()
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
        public tb_NHOMHH getItem(string tennhom)
        {
            return db.tb_NHOMHH.FirstOrDefault(p => p.TENNHOM == tennhom);
        }
        public tb_NHOMHH getItem(int idnhom)
        {
            return db.tb_NHOMHH.FirstOrDefault(p => p.IDNHOM == idnhom);
        }
        public List<tb_NHOMHH> getAll()
        {
            return db.tb_NHOMHH.ToList();
        }
        public void add(tb_NHOMHH nhh)
        {

            try
            {
                db.tb_NHOMHH.Add(nhh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_NHOMHH nhh)
        {
            tb_NHOMHH _nhh = db.tb_NHOMHH.FirstOrDefault(p => p.IDNHOM == nhh.IDNHOM);
            _nhh.TENNHOM = nhh.TENNHOM;
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
            tb_NHOMHH nhh = db.tb_NHOMHH.FirstOrDefault(p => p.TENNHOM == ten);
            try
            {
                nhh.DISABLED = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
    }
}
