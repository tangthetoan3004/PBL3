using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace STOCK
{
    public class myFunctions
    {
        public static string _macty;
        public static string _madvi;
        public static string _srv = "LAPTOP-KJ2T5301\\SQLEXPRESS01";
        public static string _us;
        public static string _pw;
        public static string _db = "QUANLY_KHOHANG";
        public static bool cIsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {

                if (!Char.IsDigit(c))
                    return false;


            }
            return true;
        }
        public static bool sIsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
    }
}
