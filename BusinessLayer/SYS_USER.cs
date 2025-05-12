using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_USER
    {
        private Entities db;
        public SYS_USER()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_USER getItem(int idUser)
        {
            return db.tb_SYS_USER.FirstOrDefault(x => x.IDUSER == idUser);
        }
        public tb_SYS_USER getItem(string username, string macty, string madvi)
        {
            return db.tb_SYS_USER.FirstOrDefault(x => x.USERNAME == username && x.MACTY == macty && x.MADVI == madvi);
        }
        public List<tb_SYS_USER> getAll()
        {
            return db.tb_SYS_USER.ToList();
        }
        public List<tb_SYS_USER> getUserByDVI(string macty, string madvi)
        {
            return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi).ToList();
        }
        public bool checkUserExist(string macty, string madvi, string username)
        {

            var us = db.tb_SYS_USER.FirstOrDefault(x => x.MACTY == macty && x.MADVI == madvi && x.USERNAME == username);
            if (us == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public tb_SYS_USER add(tb_SYS_USER us)
        {
            try
            {
                db.tb_SYS_USER.Add(us);
                db.SaveChanges();
                return us;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_SYS_USER update(tb_SYS_USER us)
        {
            var _us = db.tb_SYS_USER.FirstOrDefault(x => x.IDUSER == us.IDUSER);
            _us.USERNAME = us.USERNAME;
            _us.FULLNAME = us.FULLNAME;
            _us.ISGROUP = us.ISGROUP;
            _us.DISABLED = us.DISABLED;
            _us.MACTY = us.MACTY;
            _us.MADVI = us.MADVI;
            _us.PASSWD = us.PASSWD;
            _us.LAST_PWD_CHANGED = DateTime.Now;
            try
            {

                db.SaveChanges();
                return us;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
