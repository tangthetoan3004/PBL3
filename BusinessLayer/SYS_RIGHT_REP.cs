using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_RIGHT_REP
    {
        private Entities db;
        public SYS_RIGHT_REP()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SYS_RIGHT_REP> getlistByUser(int iduser)
        {
            SYS_GROUP sg = new SYS_GROUP();
            var gr = sg.getGroupByMemBer(iduser);
            if(gr == null)
            {
                return db.tb_SYS_RIGHT_REP.Where(p => p.IDUSER == iduser && p.USER_RIGHT == true).ToList();
            }
            else
            {
                List<tb_SYS_RIGHT_REP> lstByGroup = db.tb_SYS_RIGHT_REP.Where(p => p.IDUSER == gr.GROUP && p.USER_RIGHT == true).ToList();
                List<tb_SYS_RIGHT_REP> lstByUser = db.tb_SYS_RIGHT_REP.Where(p => p.IDUSER == iduser && p.USER_RIGHT == true).ToList();
                List<tb_SYS_RIGHT_REP> lstAll = lstByUser.Concat(lstByGroup).ToList();
                return lstAll;
            }
        }
        public void update(int idUser, int rep_code, bool right)
        {
            try
            {
                tb_SYS_RIGHT_REP sRight = db.tb_SYS_RIGHT_REP.FirstOrDefault(x => x.IDUSER == idUser && x.REP_CODE == rep_code);

                if (sRight != null)
                {
                    sRight.USER_RIGHT = right;
                }
                else
                {
                    sRight = new tb_SYS_RIGHT_REP
                    {
                        IDUSER = idUser,
                        REP_CODE = rep_code,
                        USER_RIGHT = right
                    };
                    db.tb_SYS_RIGHT_REP.Add(sRight);
                }

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật quyền: " + ex.Message);
            }
        }

    }
}
