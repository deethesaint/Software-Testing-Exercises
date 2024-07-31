using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class KiemTraTamGiac
    {
        public static String Check(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a) &&
                    (a > 0) && (b > 0) && (c > 0))
            {
                if ((a == b) && (b == c))
                {
                    return global.TGDEU;
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    return global.TGCAN;
                }
                else if ((a * a == b * b + c * c) ||
                        (b * b == a * a + c * c) ||
                        (c * c == a * a + b * b))
                {
                    return global.TGVUONG;
                }
                else if (((a * a + b * b == c * c) && (a == b)) ||
                        ((a * a + c * c == b * b) && (a == c)) ||
                        ((b * b + c * c == a * a) && (b == c)))
                {
                    return global.TGVUONGCAN;
                }
                else
                {
                    return global.TGTHUONG;
                }
            }
            else
            {
                return global.KPTAMGIAC;
            }
        }
    }
}
