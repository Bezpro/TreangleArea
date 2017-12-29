using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleArea
{
    public static class Treangle
    {
        public static double GetArea(double a, double b, double c)
        {
            double hypo = Math.Max(Math.Max(a, b), c);
            double katet1 = Math.Min(Math.Min(a, b), c);
            double katet2 = a + b + c - hypo - katet1;
            if (Math.Pow(hypo, 2) != Math.Pow(katet1, 2) + Math.Pow(katet2, 2)) return 0;
            return (katet1 * katet2) / 2;
        }
    }
}
