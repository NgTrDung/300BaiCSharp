using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Diem
    {
        float x, y;

        public Diem()
        {
        }

        public Diem(float a, float b)
        {
            this.x = a;
            this.y = b;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
    }
}
