using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_FUNC
    {
        Entities db;
        public SYS_FUNC()
        {
            try
            {
                db = Entities.CreateEntities();
            }
            catch (Exception ex)
            {
                // In thông tin lỗi nếu có
                throw new Exception("Lỗi khi kết nối tới cơ sở dữ liệu: " + ex.Message);
            }
        }
        public List<tb_SYS_FUNC> getParent()
        {
            return db.tb_SYS_FUNC.Where(p => p.ISGROUP == true && p.MENU == true).OrderByDescending(p => p.SORT).ToList();
        }
        public List<tb_SYS_FUNC> getChild(string parent)
        {
            return db.tb_SYS_FUNC.Where(p => p.ISGROUP == false && p.MENU == true && p.PARENT == parent).OrderBy(p => p.SORT).ToList();
        }
    }
}
