using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class XUATXU
    {
        private Entities db;
        public XUATXU()
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
        public tb_XUATXU getItem(string ten)
        {
            return db.tb_XUATXU.FirstOrDefault(p => p.TEN == ten);
        }
        public tb_XUATXU getItem(int id)
        {
            return db.tb_XUATXU.FirstOrDefault(p => p.ID == id);
        }
        public List<tb_XUATXU> getAll()
        {
            return db.tb_XUATXU.ToList();
        }
        public void add(tb_XUATXU xx)
        {
            try
            {
                db.tb_XUATXU.Add(xx);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_XUATXU xx)
        {
            tb_XUATXU _xx = db.tb_XUATXU.FirstOrDefault(p => p.ID == xx.ID);
            _xx.TEN = xx.TEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void delete(string ten) {
            tb_XUATXU xx = db.tb_XUATXU.FirstOrDefault(p => p.TEN == ten);
            if (xx != null)
            {
                xx.DISABLED = true;
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy bản ghi để xóa.");
            }
        }
    }
}
