using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLabBookLab2Q1
{
    struct Number
    {
        public int a;

        public Number(int a)
        {
            this.a = a;
        }

        public int square(int a)
        {
            return a * a;
        }
        public int cube(int a)
        {
            return a * a * a;
        }
    }
}
