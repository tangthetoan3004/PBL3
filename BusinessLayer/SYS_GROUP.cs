using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_GROUP
    {
        Entities db;
        public SYS_GROUP()
        {
            db = Entities.CreateEntities();
        }
        public void add(tb_SYS_GROUP gr)
        {
            try
            {
                db.tb_SYS_GROUP.Add(gr);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
        public tb_SYS_GROUP getGroupByMemBer(int idUser)

        {
            return db.tb_SYS_GROUP.FirstOrDefault(p => p.MEMBER == idUser);
        }
        public void delGroup(int idUser, int idGroup)
        {
            var gr = db.tb_SYS_GROUP.FirstOrDefault(x => x.MEMBER == idUser && x.GROUP == idGroup);
            if (gr != null)
            {
                try
                {
                    db.tb_SYS_GROUP.Remove(gr);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
                }
            }
        }

        public bool checkGroupExist(string macty, string madvi, string groupName)
        {
            return db.tb_SYS_USER.Any(u =>
                u.ISGROUP == true &&
                u.MACTY == macty &&
                u.MADVI == madvi &&
                u.USERNAME.Equals(groupName, StringComparison.OrdinalIgnoreCase)
            );
        }

    }
}
