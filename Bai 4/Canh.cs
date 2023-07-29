using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Canh
    {
        private double d;

        public Canh()
        {
        }

        public Canh(double d)
        {
            this.d = d;
        }

        public double D { get => d; set => d = value; }
    }
}
