using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BARCODEEAN13
    {
        public BARCODEEAN13()
        {
        }
        public static string BuildEAN13(string code)
        {
            int iSum = 0;
            int iDigit = 0;
            for(int i = code.Length; i >= 1; i--)
            {
                iDigit = Convert.ToInt32(code.Substring(i - 1, 1));
                if((i % 2) == 0)
                {
                    iSum += iDigit * 3;
                }
                else
                {
                    iSum += iDigit * 1;
                }
            }
            int checkSum = (10 - (iSum % 10)) % 10;
            code += checkSum.ToString();
            return code;
        }
    }
}
