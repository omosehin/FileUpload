using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadExcelFile.NewFolder
{
    public static class Utility
    {
        public static double ConvertToDouble(this string str)
        {
            if (str == null || str == " ")
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(str, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }
    }
}
