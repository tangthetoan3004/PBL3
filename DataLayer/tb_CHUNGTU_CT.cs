//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_CHUNGTU_CT
    {
        public System.Guid KHOACT { get; set; }
        public Nullable<System.Guid> KHOA { get; set; }
        public Nullable<int> STT { get; set; }
        public string BARCODE { get; set; }
        public Nullable<int> SOLUONGCT { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<int> CHIETKHAU { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
    
        public virtual tb_CHUNGTU tb_CHUNGTU { get; set; }
        public virtual tb_HANGHOA tb_HANGHOA { get; set; }
    }
}
