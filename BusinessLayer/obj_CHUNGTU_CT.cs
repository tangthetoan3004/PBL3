using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class obj_CHUNGTU_CT
    {
        public System.Guid KHOACT { get; set; }
        public Nullable<System.Guid> KHOA { get; set; }
        public string BARCODE { get; set; }
        public string TENHH { get; set; }
        public string DVT { get; set; }
        public Nullable<int> SOLUONGCT { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<int> CHIETKHAU { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
    }
}
