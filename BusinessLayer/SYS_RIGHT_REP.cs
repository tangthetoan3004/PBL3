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
        /*   public void update(int idUser, int rep_code, bool right)
           {
               tb_SYS_RIGHT_REP sRight = db.tb_SYS_RIGHT_REP.FirstOrDefault(x => x.IDUSER == idUser && x.REP_CODE == rep_code);
               try
               {
                   sRight.USER_RIGHT = right;
                   db.SaveChanges();

               }
               catch (Exception ex)
               {
                   throw new Exception("Lỗi: " + ex.Message);
               }
           }*/
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
