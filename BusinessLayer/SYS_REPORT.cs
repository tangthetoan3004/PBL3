using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_REPORT
    {
        private Entities db;
        public SYS_REPORT()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_REPORT getItem(int id)
        {
            return db.tb_SYS_REPORT.FirstOrDefault(x => x.REP_CODE == id);
        }
        public List<tb_SYS_REPORT> getList()
        {
            return db.tb_SYS_REPORT.ToList();
        }
        public List<tb_SYS_REPORT> getListByRight(List<tb_SYS_RIGHT_REP> lst)
        {
            List<int> rep = lst.Select(p => p.REP_CODE).ToList();
            return db.tb_SYS_REPORT.Where(p => rep.Contains(p.REP_CODE)).OrderBy(p => p.REP_CODE).ToList();
        }
    }
}
