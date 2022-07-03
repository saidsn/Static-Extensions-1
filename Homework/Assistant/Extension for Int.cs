using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Assistant
{
    public static class Extension
    {
        public static double PowerNumbers(this int n,int m)
        {
            return Math.Pow(n, m);
        }
    }
}
