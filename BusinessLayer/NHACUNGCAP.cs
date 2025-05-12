using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHACUNGCAP
    {
        private Entities db;
        public NHACUNGCAP()
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
        public tb_NHACUNGCAP getItem(string mancc)
        {
            return db.tb_NHACUNGCAP.FirstOrDefault(p => p.MANCC == mancc);
        }
        public List<tb_NHACUNGCAP> getAll()
        {
            return db.tb_NHACUNGCAP.OrderBy(p => p.DISABLED).ToList();
        }
        public void add(tb_NHACUNGCAP ncc)
        {

            try
            {
                db.tb_NHACUNGCAP.Add(ncc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_NHACUNGCAP ncc)
        {
            tb_NHACUNGCAP _ncc = db.tb_NHACUNGCAP.FirstOrDefault(p => p.MANCC == ncc.MANCC);
            _ncc.TENNCC = ncc.TENNCC;
            _ncc.DIENTHOAI = ncc.DIENTHOAI;
            _ncc.FAX = ncc.FAX;
            _ncc.EMAIL = ncc.EMAIL;
            _ncc.DIACHI = ncc.DIACHI;
            _ncc.DISABLED = ncc.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void delete(string mancc)
        {
            tb_NHACUNGCAP ncc = db.tb_NHACUNGCAP.FirstOrDefault(p => p.MANCC == mancc);
            ncc.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
    }
}
