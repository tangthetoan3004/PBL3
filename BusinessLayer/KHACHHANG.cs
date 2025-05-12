using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHACHHANG
    {
        private Entities db;
        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_KHACHHANG> getList()
        {
            return db.tb_KHACHHANG.ToList();
        }
    }
}
