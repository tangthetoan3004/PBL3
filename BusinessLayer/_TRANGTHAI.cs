using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class _TRANGTHAI
    {
        public int _value { get; set; }
        public string _display { get; set; }
        public _TRANGTHAI()
        {
            
        }
        public _TRANGTHAI(int value, string display)
        {
            _value = value;
            _display = display;
        }
        public static List<_TRANGTHAI> getList()
        {
            List<_TRANGTHAI> list = new List<_TRANGTHAI>();
            _TRANGTHAI[] collect = new _TRANGTHAI[2]
            {
                new _TRANGTHAI(1, "Chưa hoàn tất"),
                new _TRANGTHAI(2, "Đã hoàn tất")
            };
            list.AddRange(collect);
            return list;
        }
    }
}
