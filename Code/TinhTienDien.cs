using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class TinhTienDien
    {
        public static decimal Calculate(int NumberOfKWH)
        {
            decimal result = 0;
            int remainNumber = NumberOfKWH;
            if (remainNumber > 400)
            {
                result += (remainNumber - 400) * 2927;
                remainNumber = 400;
            }
            if (remainNumber > 300)
            {
                result += (remainNumber - 300) * 2834;
                remainNumber = 300;
            }
            if (remainNumber > 200)
            {
                result += (remainNumber - 200) * 2536;
                remainNumber = 200;
            }
            if (remainNumber > 100)
            {
                result += (remainNumber - 100) * 2014;
                remainNumber = 100;
            }
            if (remainNumber > 50)
            {
                result += (remainNumber - 50) * 1734;
                remainNumber = 50;
            }
            if (remainNumber > 0)
            {
                result += remainNumber * 1678;
            }

            return result + ((decimal)(result / 10));
        }
    }
}
