using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGTY
    {
        private Entities db;
        public CONGTY()
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

        public tb_CONGTY getItem(string macty)
        {
            return db.tb_CONGTY.FirstOrDefault(x => x.MACTY == macty);
        }
        public List<tb_CONGTY> getAll()
        {
            return db.tb_CONGTY.OrderBy(p => p.DISABLED).ToList();
        }
        public void add(tb_CONGTY cty)
        {

            try
            {
                db.tb_CONGTY.Add(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_CONGTY cty)
        {
            tb_CONGTY _cty = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == cty.MACTY);
            _cty.TENCTY = cty.TENCTY;
            _cty.DIENTHOAI = cty.DIENTHOAI;
            _cty.FAX = cty.FAX;
            _cty.EMAIL = cty.EMAIL;
            _cty.DIACHI = cty.DIACHI;
            _cty.DISABLED = cty.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public void delete(string macty)
        {
            tb_CONGTY cty = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == macty);
            cty.DISABLED = true;
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
