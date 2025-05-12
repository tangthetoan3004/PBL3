using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SYS_SEQUENCE
    {
        private Entities db;
        public SYS_SEQUENCE()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_SEQUENCE getItem(string seqname)
        {
            return db.tb_SYS_SEQUENCE.FirstOrDefault(x => x.SEQNAME == seqname);
        }
        public void add(tb_SYS_SEQUENCE seqname)
        {
            try
            {
                db.tb_SYS_SEQUENCE.Add(seqname);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(tb_SYS_SEQUENCE seqname)
        {
            var _seq = db.tb_SYS_SEQUENCE.FirstOrDefault(x => x.SEQNAME == seqname.SEQNAME);
            try
            {
                _seq.SEQVALUE = seqname.SEQVALUE + 1;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
